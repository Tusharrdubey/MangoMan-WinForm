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
using System.Windows.Markup;

namespace MangoMan.WinForm.Transactions
{
    public partial class frmOpeningStock : Form
    {

        DAL.CommonCommands Commands;
        public frmOpeningStock()
        {
            InitializeComponent();
            Commands = new DAL.CommonCommands();
            ClearForm();

        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Application.DoEvents();
            GetItemData();
        }

        public void GetItemData()
        {

            cmbItem.ValueMember = "ItemID";
            cmbItem.DisplayMember = "ItemName";
            cmbItem.DataSource = Commands.GetData("Select ItemID, ItemName from tblItem Order by ItemName");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOpeningStock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        int EditingOpeningStockID;
        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditingOpeningStockID = 0;
            if (cmbItem.SelectedValue != null)
            {
                DataTable res = Commands.GetData("Select * from tblOpeningStock where ItemID = @ItemID", new SqlParameter("ItemId", (int)cmbItem.SelectedValue));

                if (res.Rows.Count > 0)
                {
                    DataRow row = res.Rows[0];

                    EditingOpeningStockID = (int)row["OpeningStockID"];
                    txtQuantity.Text = row["Quantity"].ToString();
                    txtPurchaseRate.Text = row["PurchaseRate"].ToString();
                    txtNarration.Text = row["Narration"].ToString();
                    btnDelete.Visible = true;
                }
                else
                {
                    ClearForm(true);
                }

            }
        }

        private void txtSelectedItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbItem_Validating(object sender, CancelEventArgs e)
        {
            if (cmbItem.SelectedValue == null)
            {
                errorProvider1.SetError(cmbItem, "Please select an Item.");
            }
            else
            {
                errorProvider1.SetError(cmbItem, null);
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            if (!decimal.TryParse(txtQuantity.Text, out value))
            {
                errorProvider1.SetError(txtQuantity, "Please Enter valid numeric Quantity.");
            }
            else if (value == 0)
            {
                errorProvider1.SetError(txtQuantity, "Zero not Accepted in Quantity.");
            }
            else
            {
                errorProvider1.SetError(txtQuantity, null);
            }
        }

        private void txtPurchaseRate_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            if (!decimal.TryParse(txtPurchaseRate.Text, out value))
            {
                errorProvider1.SetError(txtPurchaseRate, "Please Enter valid numeric Value.");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseRate, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            string Error = null;
            Control ErrorControl = null;
            string ErrorText = null;

            ErrorText = errorProvider1.GetError(cmbItem);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = cmbItem; }
            }

            ErrorText = errorProvider1.GetError(txtQuantity);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtQuantity; }
            }
            ErrorText = errorProvider1.GetError(txtPurchaseRate);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtPurchaseRate; }
            }

            if (Error != null)
            {
                MessageBox.Show($"Please fix Following validation error before saving..\r\n{Error}", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (ErrorControl != null)
                {
                    ErrorControl.Focus();
                }
                return;
            }

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("OpeningStockID", EditingOpeningStockID),
                new SqlParameter("ItemID", (int)cmbItem.SelectedValue),
                new SqlParameter("Quantity", decimal.Parse(txtQuantity.Text)),
                new SqlParameter("PurchaseRate", decimal.Parse(txtPurchaseRate.Text)),
                new SqlParameter("Narration", txtNarration.Text),
            };

            string CommandText;


            if (EditingOpeningStockID == 0)
            {
                CommandText = @"Insert into tblOpeningStock
(ItemID,
Quantity ,
PurchaseRate,
Narration,
rcdt) 
Values(@ItemID, @Quantity,@PurchaseRate,@Narration,GetDate())";
            }
            else
            {
                CommandText = @"Update tblOpeningStock SET
ItemID = @ItemID
,Quantity = @Quantity
,PurchaseRate =@PurchaseRate
,Narration = @Narration
,redt = GetDate()


Where OpeningStockID = @OpeningStockID";
            }


            int Result = Commands.ExecuteNonQuery(CommandText, paras);
            if (Result > 0)
            {
                MessageBox.Show("Saved Successfully", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error while saving. \r\n " + (Commands.CurrentException != null ? Commands.CurrentException.Message : ""), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            cmbItem.Focus();

        }

        void ClearForm(bool PreventItem = false)
        {
            if (!PreventItem)
            {
                cmbItem.SelectedValue = 0;
            }

            txtQuantity.Text = "0";
            txtPurchaseRate.Text = "0";
            txtNarration.Text = "";
            EditingOpeningStockID = 0;
            btnDelete.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EditingOpeningStockID == 0)
            {
                return;
            }
            string DeleteCommandText = "Delete from tblOpeningStock where OpeningStockID = @OpeningStockID";
            int result = Commands.ExecuteNonQuery(DeleteCommandText ,new SqlParameter("@OpeningStockID", EditingOpeningStockID));


          
            if (result > 0)
            {
                MessageBox.Show("Deleted Successfully", "Delete.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error while deleting. \r\n " + (Commands.CurrentException != null ? Commands.CurrentException.Message : ""), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            cmbItem.Focus();
        }
    }
}
