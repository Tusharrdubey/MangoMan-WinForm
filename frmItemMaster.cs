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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MangoMan.WinForm.Items
{

    public partial class frmItemMaster : Form
    {
        int? PrimaryKeyValue = null;
        MangoMan.DAL.CommonCommands cmd;
        private object cmdInsert;
        private string message;

        public object ErrorProvider1 { get; private set; }

        public frmItemMaster()
        {
            InitializeComponent();
            cmd = new DAL.CommonCommands();

            LoadItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren(ValidationConstraints.None);

            string Error = null;
            Control ErrorControl = null;
            string ErrorText = null;

            ErrorText = errorProvider1.GetError(txtHSN1);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtHSN1; }
            }

            ErrorText = errorProvider1.GetError(txtItemName);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtItemName; }
            }
            ErrorText = errorProvider1.GetError(txtUnitName);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtUnitName; }
            }

            ErrorText = errorProvider1.GetError(txtPurchaseRate);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtPurchaseRate; }
            }
            ErrorText = errorProvider1.GetError(txtSaleRate);
            if (!string.IsNullOrWhiteSpace(ErrorText))
            {
                Error += (Error != null ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtSaleRate; }
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

            //System.Data.SqlClient.SqlConnection Conn = new System.Data.SqlClient.SqlConnection();


            //Conn.ConnectionString = CommonProperties.ConnectionString;
            //Conn.Open();

            //System.Data.SqlClient.SqlCommand cmdNewItemID = new System.Data.SqlClient.SqlCommand("Select Top 1 ItemID from tblItem Order by ItemID Desc", Conn);
            //System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter(cmdNewItemID);
            //System.Data.DataTable dtItemID = new DataTable();
            //DA.Fill(dtItemID);

            //int NewItemID = 0;
            //if (dtItemID.Rows.Count > 0)
            //{
            //    NewItemID = (int)dtItemID.Rows[0][0];
            //}
            //NewItemID = NewItemID + 1;

            //System.Data.SqlClient.SqlCommand cmdInsert = new System.Data.SqlClient.SqlCommand();
            //cmdInsert.Connection = Conn;
            // cmdInsert.Parameters.AddWithValue("ItemID", NewItemID);


            SqlParameter[] myParas = new SqlParameter[]
            {
                new SqlParameter("ItemID", PrimaryKeyValue ?? 0),
                new SqlParameter("HSN1", txtHSN1.Text),
                new SqlParameter("ItemName", txtItemName.Text),
                new SqlParameter("UnitName", txtUnitName.Text),
                new SqlParameter("Descr", txtDescr.Text),
                new SqlParameter("PurchaseRate", decimal.Parse(txtPurchaseRate.Text)),
                new SqlParameter("SaleRate", decimal.Parse(txtSaleRate.Text)),
           };

            string CommandText = " ";


            int result = 0;

            if (PrimaryKeyValue == null)
            {
                CommandText = $@"INSERT INTO tblItem(HSN1,ItemName,UnitName,Descr,PurchaseRate,SaleRate,rcdt)
            VALUES(@HSN1 , @ItemName , @UnitName ,@Descr , @PurchaseRate , @SaleRate , GETDATE())";

            }
            else
            {

                CommandText = $@"Update tblItem SET HSN1 = @HSN1 ,
                ItemName = @ItemName ,
                UnitName = @UnitName ,
                Descr = @Descr,
                PurchaseRate = @PurchaseRate ,
                SaleRate =  @SaleRate ,
                redt = GETDATE()
                Where ItemID = @ItemID";
                message = "Record Edited";

            }



            result = cmd.ExecuteNonQuery(CommandText, myParas);


            if (result > 0)
            {
                MessageBox.Show("Record Added.", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadItems();
            }

        }

        void ClearForm()
        {
            PrimaryKeyValue = null;
            btnDelete.Visible = false;
            txtHSN1.Clear();
            txtItemName.Clear();
            txtUnitName.Clear();
            txtDescr.Clear();
            txtPurchaseRate.Clear();
            txtSaleRate.Clear();

            txtHSN1.Focus();
        }

        private void txtHSN1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHSN1.Text))
            {
                errorProvider1.SetError(txtHSN1, "Please Enter HSN.");
            }
            else
            {
                errorProvider1.SetError(txtHSN1, null);
            }
        }

        private void txtItem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                errorProvider1.SetError(txtItemName, "Please Enter Item Name.");
            }
            else
            {
                errorProvider1.SetError(txtItemName, null);
            }
        }

        private void txtUnit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                errorProvider1.SetError(txtUnitName, "Please Enter Unit Name.");
            }
            else
            {
                errorProvider1.SetError(txtUnitName, null);
            }
        }

        private void txtPurchase_Validating(object sender, CancelEventArgs e)
        {
            decimal v;
            if (!decimal.TryParse(txtPurchaseRate.Text, out v))
            {
                errorProvider1.SetError(txtPurchaseRate, "Please enter Valid numeric Purchase rate");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseRate, null);
            }
        }

        private void txtSale_Validating(object sender, CancelEventArgs e)
        {
            decimal v;
            if (!decimal.TryParse(txtSaleRate.Text, out v))
            {
                errorProvider1.SetError(txtSaleRate, "Please enter Valid numeric Sale rate");
            }
            else
            {
                errorProvider1.SetError(txtSaleRate, null);
            }
        }

        private void LoadItems()
        {
            LoadItems(cmdInsert);
        }

        void LoadItems(object cmdInsert)

        {

            dataGridView1.DataSource = cmd.GetData("Select * from tblItem Order by ItemName");
            dataGridView1.Columns["ItemID"].Visible = false;


        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //    btnSave.Text = "Edit";
            btnDelete.Visible = true;
            int ItemID = (int)dataGridView1.Rows[e.RowIndex].Cells["ItemID"].Value;

            DataTable dt = cmd.GetData($"SELECT * FROM tblItem WHERE ItemID = {ItemID.ToString()}");


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No record found ", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow dr = dt.Rows[0];
            PrimaryKeyValue = (int)dr["ItemID"];
            txtHSN1.Text = dr["HSN1"].ToString();
            txtItemName.Text = dr["ItemName"].ToString();
            txtUnitName.Text = dr["UnitName"].ToString();
            txtDescr.Text = dr["Descr"].ToString();
            txtPurchaseRate.Text = dr["PurchaseRate"].ToString();
            txtSaleRate.Text = dr["SaleRate"].ToString();

            btnDelete.Visible = true;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ? Do you want to delete ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }


            int result = cmd.ExecuteNonQuery($@"Delete from tblItem Where ItemID = @ItemID",
                new SqlParameter("ItemID", PrimaryKeyValue.Value));





            if (result > 0)
            {
                MessageBox.Show("Record Deleted ", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadItems();
            }
        }

        private void txtHSN1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

