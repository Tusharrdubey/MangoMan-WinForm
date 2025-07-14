using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoMan.WinForm.Navigation
{
    public partial class frmNavigationDashboard : Form
    {
        public frmNavigationDashboard()
        {
            InitializeComponent();
        }

        private void frmNavigationDashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnItemMaster_Click(object sender, EventArgs e)
        {
            Items.frmItemMaster frm = new Items.frmItemMaster();
            frm.MdiParent = this;
            frm.Show();



        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnOpeningStock(object sender, EventArgs e)
        {
            Transactions.frmOpeningStock frm = new Transactions.frmOpeningStock();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnPurchaseRate(object sender, EventArgs e)
        {
            Transactions.frmPurchase frm = new Transactions.frmPurchase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSales(object sender, EventArgs e)
        {
            Sales.frmSales frm = new Sales.frmSales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Report.frmReport frm = new Report.frmReport();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
