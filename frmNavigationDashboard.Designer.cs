namespace MangoMan.WinForm.Navigation
{
    partial class frmNavigationDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavigationDashboard));
            toolStrip1 = new ToolStrip();
            btnItemMaster = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnStripPurchase = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.White;
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnItemMaster, toolStripButton1, btnStripPurchase, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(956, 37);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnItemMaster
            // 
            btnItemMaster.Image = (Image)resources.GetObject("btnItemMaster.Image");
            btnItemMaster.ImageTransparentColor = Color.Magenta;
            btnItemMaster.Name = "btnItemMaster";
            btnItemMaster.Size = new Size(121, 34);
            btnItemMaster.Text = "&Item Master";
            btnItemMaster.Click += btnItemMaster_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(142, 34);
            toolStripButton1.Text = "&Opening Stock";
            toolStripButton1.Click += btnOpeningStock;
            // 
            // btnStripPurchase
            // 
            btnStripPurchase.Image = (Image)resources.GetObject("btnStripPurchase.Image");
            btnStripPurchase.ImageTransparentColor = Color.Magenta;
            btnStripPurchase.Name = "btnStripPurchase";
            btnStripPurchase.Size = new Size(137, 34);
            btnStripPurchase.Text = "&Purchase Rate";
            btnStripPurchase.Click += btnPurchaseRate;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(62, 34);
            toolStripButton2.Text = "&Sale";
            toolStripButton2.Click += btnSales;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(123, 34);
            toolStripButton3.Text = "View Report";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // frmNavigationDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(956, 480);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmNavigationDashboard";
            Text = "MangoMan1.0";
            WindowState = FormWindowState.Maximized;
            Load += frmNavigationDashboard_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnItemMaster;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnStripPurchase;
        private ToolStripButton toolStripButton3;
    }
}