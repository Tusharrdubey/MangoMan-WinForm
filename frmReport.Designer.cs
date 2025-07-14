namespace MangoMan.WinForm.Report
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnExit = new Button();
            btnPrintReport = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1256, 630);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnPrintReport);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 61);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(1134, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 44);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintReport.BackColor = SystemColors.ControlDark;
            btnPrintReport.Location = new Point(963, 15);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(165, 42);
            btnPrintReport.TabIndex = 5;
            btnPrintReport.Text = "&Print Report";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(198, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(163, 29);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new DateTime(2025, 7, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(9, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 29);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2025, 7, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 3);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 2;
            label4.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 288);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 3);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 0;
            label2.Text = "Start Date";
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 630);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmReport";
            Text = "View Report";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnPrintReport;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnExit;
    }
}