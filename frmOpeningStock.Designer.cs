namespace MangoMan.WinForm.Transactions
{
    partial class frmOpeningStock
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpeningStock));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNarration = new TextBox();
            label5 = new Label();
            txtPurchaseRate = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            cmbItem = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnExit = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(564, 31);
            label1.TabIndex = 0;
            label1.Text = "Opening Stock";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNarration);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPurchaseRate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbItem);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtNarration
            // 
            txtNarration.Location = new Point(130, 184);
            txtNarration.Multiline = true;
            txtNarration.Name = "txtNarration";
            txtNarration.Size = new Size(407, 59);
            txtNarration.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 6;
            label5.Text = "Narration";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Location = new Point(130, 133);
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(159, 29);
            txtPurchaseRate.TabIndex = 5;
            txtPurchaseRate.Validating += txtPurchaseRate_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 4;
            label4.Text = "Purchase Rate";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(130, 84);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(159, 29);
            txtQuantity.TabIndex = 3;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(130, 41);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(407, 29);
            cmbItem.TabIndex = 1;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            cmbItem.Validating += cmbItem_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 0;
            label2.Text = "&Item";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(310, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(416, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 1;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmOpeningStock
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 336);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(580, 375);
            Name = "frmOpeningStock";
            Text = "Opening Stock";
            WindowState = FormWindowState.Maximized;
            Load += frmOpeningStock_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNarration;
        private Label label5;
        private TextBox txtPurchaseRate;
        private Label label4;
        private TextBox txtQuantity;
        private Label label3;
        private ComboBox cmbItem;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private Button btnDelete;
    }
}