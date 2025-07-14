namespace MangoMan.WinForm.Items
{
    partial class frmItemMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemMaster));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            txtSaleRate = new TextBox();
            label6 = new Label();
            txtPurchaseRate = new TextBox();
            label5 = new Label();
            txtDescr = new TextBox();
            label4 = new Label();
            txtUnitName = new TextBox();
            label3 = new Label();
            txtItemName = new TextBox();
            label2 = new Label();
            txtHSN1 = new TextBox();
            txtHSN = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1262, 37);
            label1.TabIndex = 0;
            label1.Text = "Item Master";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtSaleRate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPurchaseRate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDescr);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUnitName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtItemName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHSN1);
            groupBox1.Controls.Add(txtHSN);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 444);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Master";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 40);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(641, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(621, 422);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSaleRate
            // 
            txtSaleRate.Location = new Point(135, 333);
            txtSaleRate.MaxLength = 18;
            txtSaleRate.Name = "txtSaleRate";
            txtSaleRate.Size = new Size(125, 29);
            txtSaleRate.TabIndex = 11;
            txtSaleRate.TextAlign = HorizontalAlignment.Right;
            txtSaleRate.Validating += txtSale_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 336);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 10;
            label6.Text = "Sale Rate";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Location = new Point(135, 272);
            txtPurchaseRate.MaxLength = 18;
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(125, 29);
            txtPurchaseRate.TabIndex = 9;
            txtPurchaseRate.TextAlign = HorizontalAlignment.Right;
            txtPurchaseRate.Validating += txtPurchase_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 275);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 8;
            label5.Text = "Purchase Rate";
            // 
            // txtDescr
            // 
            txtDescr.Location = new Point(135, 180);
            txtDescr.MaxLength = 500;
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(500, 75);
            txtDescr.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(135, 133);
            txtUnitName.MaxLength = 10;
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(150, 29);
            txtUnitName.TabIndex = 5;
            txtUnitName.Validating += txtUnit_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 4;
            label3.Text = "Unit Name";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(135, 82);
            txtItemName.MaxLength = 50;
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(450, 29);
            txtItemName.TabIndex = 3;
            txtItemName.Validating += txtItem_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "&Item Name";
            // 
            // txtHSN1
            // 
            txtHSN1.Location = new Point(135, 34);
            txtHSN1.MaxLength = 20;
            txtHSN1.Name = "txtHSN1";
            txtHSN1.Size = new Size(300, 29);
            txtHSN1.TabIndex = 1;
            txtHSN1.TextChanged += txtHSN1_TextChanged;
            txtHSN1.Validating += txtHSN1_Validating;
            // 
            // txtHSN
            // 
            txtHSN.AutoSize = true;
            txtHSN.Location = new Point(12, 37);
            txtHSN.Name = "txtHSN";
            txtHSN.Size = new Size(43, 21);
            txtHSN.TabIndex = 0;
            txtHSN.Text = "&HSN";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmItemMaster
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 481);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmItemMaster";
            Text = "Item Master";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDescr;
        private Label label4;
        private TextBox txtUnitName;
        private Label label3;
        private TextBox txtItemName;
        private Label label2;
        private TextBox txtHSN1;
        private Label txtHSN;
        private TextBox txtSaleRate;
        private Label label6;
        private TextBox txtPurchaseRate;
        private Label label5;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private Button btnDelete;
    }
}