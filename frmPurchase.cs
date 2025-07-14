using MangoMan.DAL;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MangoMan.WinForm.Transactions
{
    public partial class frmPurchase : Form
    {
        DAL.CommonCommands Command;
        int? EditPurchase;

        public frmPurchase()
        {
            InitializeComponent();
            Command = new DAL.CommonCommands();
            ClearForm();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Load Items in ComboBox
            DataTable dt = Command.GetData("SELECT ItemID, ItemName FROM tblItem ORDER BY ItemName");

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbItem.DataSource = dt;
                cmbItem.DisplayMember = "ItemName";
                cmbItem.ValueMember = "ItemID";
                cmbItem.SelectedIndex = -1;
            }
        }

        private string GeneratePurchaseNoByItem(int itemId)
        {
            string CommandText = "SELECT MAX(CAST(PurchaseNo AS INT)) FROM tblPurchase WHERE ItemID = @ItemID";
            SqlParameter param = new SqlParameter("@ItemID", itemId);
            DataTable dt = Command.GetData(CommandText, param);

            int maxPurchaseNo = 0;

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                maxPurchaseNo = Convert.ToInt32(dt.Rows[0][0]);
            }

            int newPurchaseNo = maxPurchaseNo + 1;
            return newPurchaseNo.ToString();
        }

        private void cmbItem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbItem.SelectedValue != null && int.TryParse(cmbItem.SelectedValue.ToString(), out int ItemID))
            {
                // Use different SqlParameter instances
                SqlParameter param1 = new SqlParameter("@ItemID", ItemID);
                SqlParameter param2 = new SqlParameter("@ItemID", ItemID);

                // Get Unit Name from tblItem
                object unitResult = Command.ExecuteScalar("SELECT UnitName FROM tblItem WHERE ItemID = @ItemID", param1);
                lblUnit.Text = unitResult?.ToString() ?? "";

                // Get Last Purchase Rate from tblPurchase
                object rateResult = Command.ExecuteScalar(
                    "SELECT TOP 1 PurchaseRate FROM tblPurchase WHERE ItemID = @ItemID ORDER BY PurchaseID DESC", param2);
                txtPurchaseRate.Text = rateResult?.ToString() ?? "0";

                // Generate purchase number for this item
                txtPurchaseNo.Text = GeneratePurchaseNoByItem(ItemID);
            }
            else
            {
                lblUnit.Text = "";
                txtPurchaseRate.Text = "0";
                txtPurchaseNo.Text = "";
            }
        }

        private void cmbItem_Validating(object sender, CancelEventArgs e)
        {
            if (cmbItem.SelectedValue == null || cmbItem.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbItem, "Please Select Item");
            }
            else
            {
                errorProvider1.SetError(cmbItem, null);
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !decimal.TryParse(txtQuantity.Text, out decimal value) || value == 0)
            {
                errorProvider1.SetError(txtQuantity, "Please enter valid quantity");
            }
            else
            {
                errorProvider1.SetError(txtQuantity, null);
            }
        }

        private void txtPurchaseRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurchaseRate.Text) || !decimal.TryParse(txtPurchaseRate.Text, out _))
            {
                errorProvider1.SetError(txtPurchaseRate, "Please enter valid purchase rate");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseRate, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            string errorMessages = null;
            Control focusControl = null;

            string Error = errorProvider1.GetError(cmbItem);
            if (!string.IsNullOrWhiteSpace(Error))
            {
                errorMessages += Error + "\r\n";
                if (focusControl == null) focusControl = cmbItem;
            }

            Error = errorProvider1.GetError(txtQuantity);
            if (!string.IsNullOrWhiteSpace(Error))
            {
                errorMessages += Error + "\r\n";
                if (focusControl == null) focusControl = txtQuantity;
            }

            Error = errorProvider1.GetError(txtPurchaseRate);
            if (!string.IsNullOrWhiteSpace(Error))
            {
                errorMessages += Error + "\r\n";
                if (focusControl == null) focusControl = txtPurchaseRate;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                errorMessages += "Purchase date cannot be in the future.\r\n";
                if (focusControl == null) focusControl = dateTimePicker1;
            }

            if (!string.IsNullOrWhiteSpace(errorMessages))
            {
                MessageBox.Show("Please fix the following validation errors:\r\n" + errorMessages,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                focusControl?.Focus();
                return;
            }

            // Check duplicate
            string checkQuery = "SELECT * FROM tblPurchase WHERE PurchaseNo = @PurchaseNo AND ItemID = @ItemID";
            SqlParameter[] checkParams = {
                new SqlParameter("@PurchaseNo", txtPurchaseNo.Text),
                new SqlParameter("@ItemID", (int)cmbItem.SelectedValue)
            };
            DataTable dt = Command.GetData(checkQuery, checkParams);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This Purchase Number already exists for the selected item.",
                    "Duplicate Purchase No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPurchaseNo.Focus();
                return;
            }

            SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@PurchaseID", EditPurchase == null ? 0 : EditPurchase),
                new SqlParameter("@ItemID", (int)cmbItem.SelectedValue),
                new SqlParameter("@PurchaseNo", txtPurchaseNo.Text),
                new SqlParameter("@Quantity", decimal.Parse(txtQuantity.Text)),
                new SqlParameter("@Rate", decimal.Parse(txtPurchaseRate.Text)),
                new SqlParameter("@PurchaseDate", dateTimePicker1.Value.Date),
                new SqlParameter("@Narration", txtNarration.Text)
            };

            string sqlCommandText = null;

            if (EditPurchase == null)
            {
                sqlCommandText = @"INSERT INTO tblPurchase(PurchaseDate, PurchaseNo, ItemID, PurchaseRate, Quantity, Narration, rcdt)
                       VALUES(@PurchaseDate, @PurchaseNo, @ItemID, @Rate, @Quantity, @Narration, GETDATE())";
            }
            else
            {
                sqlCommandText = @"UPDATE tblPurchase 
                       SET PurchaseDate = @PurchaseDate, 
                           PurchaseNo = @PurchaseNo, 
                           ItemID = @ItemID, 
                           PurchaseRate = @Rate, 
                           Quantity = @Quantity, 
                           Narration = @Narration 
                       WHERE PurchaseID = @PurchaseID";
            }


            int result = Command.ExecuteNonQuery(sqlCommandText, paras);

            if (result > 0)
            {
                MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cmbItem.Focus();
            }
            else
            {
                MessageBox.Show("Error while saving:\r\n" +
                    (Command.CurrentException != null ? Command.CurrentException.Message : "Unknown error."),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm(bool preventItem = false)
        {
            if (!preventItem)
            {
                cmbItem.SelectedIndex = -1;
            }

            EditPurchase = null;
            txtQuantity.Text = "0";
            txtPurchaseRate.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            txtNarration.Text = "";
            txtPurchaseNo.Text = "";
            btnSave.Text = "Save";
            lblUnit.Text = "";
        }

        // Optional event handlers
        private void frmPurchase_Load(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtPurchaseRate_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmPurchaseSearch frmsearch = new frmPurchaseSearch();
            DialogResult result = frmsearch.ShowDialog();
            if (result == DialogResult.OK && frmsearch.PurchaseID != null)
            {
                var editdt = Command.GetData("Select * from tblPurchase where PurchaseID = @PurchaseID",
                    new SqlParameter("@PurchaseID", frmsearch.PurchaseID));
                if (editdt != null)
                {
                    DataRow Row = editdt.Rows[0];

                    EditPurchase = (int)Row["PurchaseID"];
                    dateTimePicker1.Value = (DateTime)Row["PurchaseDate"];
                    txtPurchaseNo.Text = Row["PurchaseNo"].ToString();
                    cmbItem.SelectedValue = (int)Row["ItemID"];
                    txtQuantity.Text = ((decimal)Row["Quantity"]).ToString("n2");
                    txtPurchaseRate.Text = ((decimal)Row["PurchaseRate"]).ToString("n2");
                    txtNarration.Text = Row["Narration"].ToString();

                    btnSave.Text = "Update";

                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Confirm Exit",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int result = Command.ExecuteNonQuery("Delete from tblPurchase where PurchaseID = @PurchaseID ", new SqlParameter("@PurchaseID", EditPurchase ?? 0));
                if (result > 0)
                {
                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    cmbItem.Focus();
                }
                else
                {
                    MessageBox.Show("Error while deleting:\r\n" +
                        (Command.CurrentException != null ? Command.CurrentException.Message : "Unknown error."),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
