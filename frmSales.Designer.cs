namespace MangoMan.WinForm.Sales
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNarration = new TextBox();
            label9 = new Label();
            txtSalesRate = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            lblUnit = new Label();
            label5 = new Label();
            cmbItem = new ComboBox();
            txtCustomerName = new TextBox();
            label4 = new Label();
            txtSalesNo = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 44);
            label1.TabIndex = 0;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNarration);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSalesRate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblUnit);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbItem);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSalesNo);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 44);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(914, 465);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtNarration
            // 
            txtNarration.Location = new Point(151, 243);
            txtNarration.Multiline = true;
            txtNarration.Name = "txtNarration";
            txtNarration.Size = new Size(428, 108);
            txtNarration.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(17, 246);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 14;
            label9.Text = "Narration";
            // 
            // txtSalesRate
            // 
            txtSalesRate.Location = new Point(151, 159);
            txtSalesRate.Name = "txtSalesRate";
            txtSalesRate.Size = new Size(185, 29);
            txtSalesRate.TabIndex = 13;
            txtSalesRate.Validating += txtSalesRate_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(17, 162);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 12;
            label8.Text = "Sales Rate";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(151, 199);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(185, 29);
            txtQuantity.TabIndex = 11;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(17, 199);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 10;
            label7.Text = "Quantity";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(532, 123);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(40, 21);
            lblUnit.TabIndex = 9;
            lblUnit.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 122);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 8;
            label5.Text = "Select Item";
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(152, 119);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(375, 29);
            cmbItem.TabIndex = 7;
            cmbItem.Validating += cmbItem_Validating;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(151, 81);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(428, 29);
            txtCustomerName.TabIndex = 6;
            txtCustomerName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 85);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 5;
            label4.Text = "Customer Name";
            // 
            // txtSalesNo
            // 
            txtSalesNo.Location = new Point(367, 33);
            txtSalesNo.Name = "txtSalesNo";
            txtSalesNo.Size = new Size(212, 29);
            txtSalesNo.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 29);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(288, 36);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Sales No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Sales Date";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(4, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(906, 75);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(807, 23);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(708, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(126, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(93, 36);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 509);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSales";
            Text = "Sales";
            WindowState = FormWindowState.Maximized;
            Load += frmSales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label4;
        private TextBox txtSalesNo;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label5;
        private ComboBox cmbItem;
        private TextBox txtSalesRate;
        private Label label8;
        private TextBox txtQuantity;
        private Label label7;
        private Label lblUnit;
        private TextBox txtNarration;
        private Label label9;
        private Button btnSave;
        private Button btnExit;
        private Button btnDelete;
        private Button btnSearch;
        private ErrorProvider errorProvider1;
    }
}