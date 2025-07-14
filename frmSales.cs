using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoMan.WinForm.Sales
{
    public partial class frmSales : Form
    {
        DAL.CommonCommands Command;
        int? EditSales;

        public frmSales()
        {
            InitializeComponent();
            Command = new DAL.CommonCommands();
            ClearForm();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DataTable dt = Command.GetData("SELECT ItemID, ItemName FROM tblItem ORDER BY ItemName");
            if (dt != null && dt.Rows.Count > 0)
            {
                cmbItem.DataSource = dt;
                cmbItem.DisplayMember = "ItemName";
                cmbItem.ValueMember = "ItemID";
                cmbItem.SelectedIndex = -1;
            }
        }

        private string GenerateSalesNoByItem(int itemId)
        {
            string query = "SELECT MAX(CAST(SalesNo AS INT)) FROM tblSales WHERE ItemID = @ItemID";
            SqlParameter param = new SqlParameter("@ItemID", itemId);
            DataTable dt = Command.GetData(query, param);

            int maxNo = 0;
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                maxNo = Convert.ToInt32(dt.Rows[0][0]);

            return (maxNo + 1).ToString();
        }

        private void cmbItem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbItem.SelectedValue != null && int.TryParse(cmbItem.SelectedValue.ToString(), out int ItemID))
            {
                SqlParameter param1 = new SqlParameter("@ItemID", ItemID);
                SqlParameter param2 = new SqlParameter("@ItemID", ItemID);

                object unitResult = Command.ExecuteScalar("SELECT UnitName FROM tblItem WHERE ItemID = @ItemID", param1);
                lblUnit.Text = unitResult?.ToString() ?? "";

                object rateResult = Command.ExecuteScalar("SELECT TOP 1 SalesRate FROM tblSales WHERE ItemID = @ItemID ORDER BY SalesID DESC", param2);
                txtSalesRate.Text = rateResult?.ToString() ?? "0";

                txtSalesNo.Text = GenerateSalesNoByItem(ItemID);
            }
            else
            {
                lblUnit.Text = "";
                txtSalesRate.Text = "0";
                txtSalesNo.Text = "";
            }
        }

        private void cmbItem_Validating(object sender, CancelEventArgs e)
        {
            if (cmbItem.SelectedValue == null || cmbItem.SelectedIndex == -1)
                errorProvider1.SetError(cmbItem, "Please Select Item");
            else
                errorProvider1.SetError(cmbItem, null);
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !decimal.TryParse(txtQuantity.Text, out decimal val) || val == 0)
                errorProvider1.SetError(txtQuantity, "Please enter valid quantity");
            else
                errorProvider1.SetError(txtQuantity, null);
        }

        private void txtSalesRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalesRate.Text) || !decimal.TryParse(txtSalesRate.Text, out decimal val) || val == 0)
                errorProvider1.SetError(txtSalesRate, "Please enter valid sales rate");
            else
                errorProvider1.SetError(txtSalesRate, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            string errorMessages = null;
            Control focusControl = null;

            string Error = errorProvider1.GetError(cmbItem);
            if (!string.IsNullOrWhiteSpace(Error)) { errorMessages += Error + "\r\n"; if (focusControl == null) focusControl = cmbItem; }

            Error = errorProvider1.GetError(txtQuantity);
            if (!string.IsNullOrWhiteSpace(Error)) { errorMessages += Error + "\r\n"; if (focusControl == null) focusControl = txtQuantity; }

            Error = errorProvider1.GetError(txtSalesRate);
            if (!string.IsNullOrWhiteSpace(Error)) { errorMessages += Error + "\r\n"; if (focusControl == null) focusControl = txtSalesRate; }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorMessages += "Please enter customer name.\r\n";
                if (focusControl == null) focusControl = txtCustomerName;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                errorMessages += "Sales date cannot be in the future.\r\n";
                if (focusControl == null) focusControl = dateTimePicker1;
            }

            if (!string.IsNullOrWhiteSpace(errorMessages))
            {
                MessageBox.Show("Please fix the following validation errors:\r\n" + errorMessages,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                focusControl?.Focus();
                return;
            }

            string checkQuery = "SELECT * FROM tblSales WHERE SalesNo = @SalesNo AND ItemID = @ItemID";
            SqlParameter[] checkParams = {
                new SqlParameter("@SalesNo", txtSalesNo.Text),
                new SqlParameter("@ItemID", (int)cmbItem.SelectedValue)
            };
            DataTable dt = Command.GetData(checkQuery, checkParams);
            if (dt.Rows.Count > 0 && EditSales == null)
            {
                MessageBox.Show("This Sales Number already exists for the selected item.",
                    "Duplicate Sales No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalesNo.Focus();
                return;
            }

            SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@SalesID", EditSales ?? 0),
                new SqlParameter("@ItemID", (int)cmbItem.SelectedValue),
                new SqlParameter("@SalesNo", txtSalesNo.Text),
                new SqlParameter("@Quantity", decimal.Parse(txtQuantity.Text)),
                new SqlParameter("@SalesRate", decimal.Parse(txtSalesRate.Text)),
                new SqlParameter("@SalesDate", dateTimePicker1.Value.Date),
                new SqlParameter("@Narration", txtNarration.Text),
                new SqlParameter("@CustomerName", txtCustomerName.Text)
            };

            string sqlCommandText = EditSales == null ?
                @"INSERT INTO tblSales(SalesDate, SalesNo, ItemID, SalesRate, Quantity, Narration, CustomerName, rcdt)
                  VALUES(@SalesDate, @SalesNo, @ItemID, @SalesRate, @Quantity, @Narration, @CustomerName, GETDATE())"
                :
                @"UPDATE tblSales 
                  SET SalesDate = @SalesDate, 
                      SalesNo = @SalesNo, 
                      ItemID = @ItemID, 
                      SalesRate = @SalesRate, 
                      Quantity = @Quantity, 
                      Narration = @Narration,
                      CustomerName = @CustomerName
                  WHERE SalesID = @SalesID";

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
            if (!preventItem) cmbItem.SelectedIndex = -1;

            EditSales = null;
            txtQuantity.Text = "0";
            txtSalesRate.Text = "0";
            txtCustomerName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtNarration.Text = "";
            txtSalesNo.Text = "";
            btnSave.Text = "Save";
            lblUnit.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSalesSearch frmsearch = new frmSalesSearch();
            DialogResult result = frmsearch.ShowDialog();
            if (result == DialogResult.OK && frmsearch.SalesID != null)
            {
                var editdt = Command.GetData("SELECT * FROM tblSales WHERE SalesID = @SalesID",
                    new SqlParameter("@SalesID", frmsearch.SalesID));
                if (editdt != null && editdt.Rows.Count > 0)
                {
                    DataRow row = editdt.Rows[0];
                    EditSales = (int)row["SalesID"];
                    dateTimePicker1.Value = (DateTime)row["SalesDate"];
                    txtSalesNo.Text = row["SalesNo"].ToString();
                    cmbItem.SelectedValue = (int)row["ItemID"];
                    txtQuantity.Text = ((decimal)row["Quantity"]).ToString("n2");
                    txtSalesRate.Text = ((decimal)row["SalesRate"]).ToString("n2");
                    txtNarration.Text = row["Narration"].ToString();
                    txtCustomerName.Text = row["CustomerName"].ToString();
                    btnSave.Text = "Update";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int result = Command.ExecuteNonQuery("DELETE FROM tblSales WHERE SalesID = @SalesID",
                    new SqlParameter("@SalesID", EditSales ?? 0));
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
        }


        private void frmSales_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
