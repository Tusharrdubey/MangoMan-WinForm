namespace MangoMan.WinForm.Transactions
{
    partial class frmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbItem = new ComboBox();
            lblUnit = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtNarration = new TextBox();
            label7 = new Label();
            txtPurchaseRate = new TextBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPurchaseNo = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
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
            label1.Size = new Size(629, 29);
            label1.TabIndex = 0;
            label1.Text = "Purchase";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbItem);
            groupBox1.Controls.Add(lblUnit);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtNarration);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPurchaseRate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPurchaseNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 415);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbItem
            // 
            cmbItem.DisplayMember = "ItemName";
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(134, 78);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(243, 29);
            cmbItem.TabIndex = 14;
            cmbItem.ValueMember = "ItemID";
            cmbItem.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbItem.SelectedValueChanged += cmbItem_SelectedValueChanged;
            cmbItem.Validating += cmbItem_Validating;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(383, 124);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(40, 21);
            lblUnit.TabIndex = 13;
            lblUnit.Text = "Unit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(3, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 79);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(128, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(512, 28);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(405, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(18, 28);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNarration
            // 
            txtNarration.Location = new Point(132, 218);
            txtNarration.Multiline = true;
            txtNarration.Name = "txtNarration";
            txtNarration.Size = new Size(490, 115);
            txtNarration.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 218);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 10;
            label7.Text = "Narration";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Location = new Point(132, 169);
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(245, 29);
            txtPurchaseRate.TabIndex = 9;
            txtPurchaseRate.TextChanged += txtPurchaseRate_TextChanged;
            txtPurchaseRate.Validating += txtPurchaseRate_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 174);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 8;
            label6.Text = "Purchase Rate";
            label6.Click += label6_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(132, 121);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(245, 29);
            txtQuantity.TabIndex = 7;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 4;
            label4.Text = "Item";
            // 
            // txtPurchaseNo
            // 
            txtPurchaseNo.Location = new Point(456, 25);
            txtPurchaseNo.Name = "txtPurchaseNo";
            txtPurchaseNo.Size = new Size(166, 29);
            txtPurchaseNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 2;
            label3.Text = "Purchase No.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 29);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 0;
            label2.Text = "Purchase Date";
            label2.Click += label2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPurchase
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 444);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmPurchase";
            Text = "Purchase";
            WindowState = FormWindowState.Maximized;
            Load += frmPurchase_Load;
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
        private Label label4;
        private TextBox txtPurchaseNo;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPurchaseRate;
        private Label label6;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtNarration;
        private Label label7;
        private Label lblUnit;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnDelete;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private ComboBox cmbItem;
        private Button btnSearch;
    }
}