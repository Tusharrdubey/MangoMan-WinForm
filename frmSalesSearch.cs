using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoMan.WinForm.Sales
{

    public partial class frmSalesSearch : Form
    {
        DAL.CommonCommands Command;

        public int? SalesID { get; private set; }

        public frmSalesSearch()
        {
            InitializeComponent();

            Command = new DAL.CommonCommands();

            DataTable dt = Command.GetData(@"
                SELECT 
                    SalesID, 
                    SalesDate, 
                    SalesNo, 
                    s.ItemID, 
                    s.CustomerName,
                    i.ItemName, 
                    Quantity,
                    i.UnitName,    
                    s.SalesRate,
                    LEFT(Narration, 25) AS Narration
                FROM tblSales s
                LEFT OUTER JOIN tblItem i ON i.ItemID = s.ItemID");

            dataGridView1.DefaultCellStyle.Font = new Font("Aerial", 9f, FontStyle.Bold);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Aerial", 11f, FontStyle.Bold);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["SalesID"].Visible = false;
            dataGridView1.Columns["ItemID"].Visible = false;

            dataGridView1.Columns["SalesDate"].HeaderText = "Sales Date";
            dataGridView1.Columns["SalesDate"].Width = 100;

            dataGridView1.Columns["SalesNo"].HeaderText = "Sales No.";
            dataGridView1.Columns["SalesNo"].Width = 100;
            dataGridView1.Columns["SalesNo"].DefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.Columns["SalesNo"].DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dataGridView1.Columns["SalesNo"].DefaultCellStyle.Font = new Font("Aerial", 12f, FontStyle.Bold);

            dataGridView1.Columns["CustomerName"].HeaderText = "Customer";
            dataGridView1.Columns["CustomerName"].Width = 180;

            dataGridView1.Columns["ItemName"].HeaderText = "Item Name";
            dataGridView1.Columns["ItemName"].Width = 200;

            dataGridView1.Columns["Quantity"].HeaderText = "Qty";
            dataGridView1.Columns["Quantity"].Width = 75;
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["SalesRate"].HeaderText = "Rate";
            dataGridView1.Columns["SalesRate"].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns["SalesRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["Narration"].Width = 250;
            dataGridView1.Columns["Narration"].MinimumWidth = 100;
            dataGridView1.Columns["Narration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SalesID = (int)dataGridView1.CurrentRow.Cells["SalesID"].Value;
            }
            else
            {
                SalesID = null;
            }
            base.DialogResult = DialogResult.OK;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
