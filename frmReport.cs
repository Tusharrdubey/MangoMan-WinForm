using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MangoMan.WinForm.Report
{
    public partial class frmReport : Form
    {
        DAL.CommonCommands Command;

        public frmReport()
        {
            InitializeComponent();
            Command = new DAL.CommonCommands();

            // Optional styling setup (can also be done in Form_Load)
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // Set default date range
            dateTimePicker1.Value = DateTime.Today.AddDays(-7);
            dateTimePicker2.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            string dateFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DataTable dt = Command.GetData($@"
                SELECT 
                    p.PurchaseID AS TransactionID, 
                    p.PurchaseDate AS TransactionDate, 
                    p.PurchaseNo AS TransactionNo, 
                    i.ItemName, 
                    i.UnitName, 
                    p.Quantity, 
                    p.PurchaseRate AS ItemRate, 
                    ROUND(p.Quantity * p.PurchaseRate, 2) AS Amount, 
                    'Purchase' AS TransactionType,
                    p.Narration
                FROM tblPurchase p
                LEFT OUTER JOIN tblItem i ON p.ItemID = i.ItemID
                WHERE p.PurchaseDate BETWEEN '{dateFrom}' AND '{dateTo}'

                UNION

                SELECT 
                    s.SalesID AS TransactionID, 
                    s.SalesDate AS TransactionDate, 
                    s.SalesNo AS TransactionNo, 
                    i.ItemName, 
                    i.UnitName, 
                    s.Quantity, 
                    s.SalesRate AS ItemRate, 
                    ROUND(s.Quantity * s.SalesRate, 2) AS Amount,  
                    'Sales' AS TransactionType,
                    s.Narration
                FROM tblSales s
                LEFT OUTER JOIN tblItem i ON s.ItemID = i.ItemID
                WHERE s.SalesDate BETWEEN '{dateFrom}' AND '{dateTo}'

                ORDER BY TransactionDate, TransactionNo;");

            dataGridView1.DataSource = dt;
            SetupGridColumns();
        }

        private void SetupGridColumns()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

            dataGridView1.Columns["TransactionID"].Visible = false;

            dataGridView1.Columns["TransactionDate"].HeaderText = "Date";
            dataGridView1.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns["TransactionDate"].Width = 100;

            dataGridView1.Columns["TransactionNo"].HeaderText = "Number";
            dataGridView1.Columns["TransactionNo"].Width = 100;

            dataGridView1.Columns["ItemName"].HeaderText = "Item";
            dataGridView1.Columns["ItemName"].Width = 200;

            dataGridView1.Columns["UnitName"].HeaderText = "Unit";
            dataGridView1.Columns["UnitName"].Width = 80;

            dataGridView1.Columns["Quantity"].HeaderText = "Qty";
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Quantity"].Width = 80;

            dataGridView1.Columns["ItemRate"].HeaderText = "Rate";
            dataGridView1.Columns["ItemRate"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["ItemRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ItemRate"].Width = 80;

            dataGridView1.Columns["Amount"].HeaderText = "Amount";
            dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Amount"].Width = 100;

            dataGridView1.Columns["Narration"].HeaderText = "Narration";
            dataGridView1.Columns["Narration"].Width = 250;
            dataGridView1.Columns["Narration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["TransactionType"].HeaderText = "Type";
            dataGridView1.Columns["TransactionType"].Width = 80;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
