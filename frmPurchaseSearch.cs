using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoMan.WinForm.Transactions
{
    public partial class frmPurchaseSearch : Form
    {
        DAL.CommonCommands Command;

        public int? PurchaseID { get; private set; }
        public frmPurchaseSearch()
        {
            InitializeComponent();

            Command = new DAL.CommonCommands();


            DataTable dt =
            Command.GetData(@"Select PurchaseID, PurchaseDate, PurchaseNo, p.ItemID, i.ItemName, i.UnitName, Quantity,
p.PurchaseRate, Left(Narration, 25) as Narration
from tblPurchase p Left Outer JOIN tblItem i on i.ItemID = p.ItemID");

            dataGridView1.DefaultCellStyle.Font = new Font("Aerial", 9f, FontStyle.Bold);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Aerial", 11f, FontStyle.Bold);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["PurchaseID"].Visible = false;
            dataGridView1.Columns["ItemID"].Visible = false;

            dataGridView1.Columns["PurchaseDate"].HeaderText = "Purchase Date";
            dataGridView1.Columns["PurchaseDate"].Width = 100;

            dataGridView1.Columns["PurchaseNO"].HeaderText = "Purchase No.";
            dataGridView1.Columns["PurchaseNo"].Width = 100;
            dataGridView1.Columns["PurchaseNo"].DefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.Columns["PurchaseNo"].DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dataGridView1.Columns["PurchaseNo"].DefaultCellStyle.Font = new Font("Aerial", 12f, FontStyle.Bold);

            dataGridView1.Columns["ItemName"].HeaderText = "Item Name";
            dataGridView1.Columns["ItemName"].Width = 250;

            dataGridView1.Columns["Quantity"].HeaderText = "Qty";
            dataGridView1.Columns["Quantity"].Width = 75;
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["PurchaseRate"].HeaderText = "Rate";
            dataGridView1.Columns["PurchaseRate"].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns["PurchaseRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["Narration"].Width = 300;
            dataGridView1.Columns["Narration"].MinimumWidth = 100;
            dataGridView1.Columns["Narration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                PurchaseID = (int)dataGridView1.CurrentRow.Cells["PurchaseID"].Value;
            }
            else
            {
                PurchaseID = null;
            }
            base.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
