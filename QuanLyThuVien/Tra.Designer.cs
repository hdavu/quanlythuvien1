namespace QuanLyThuVien
{
    partial class Tra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgDssachdamuon = new System.Windows.Forms.DataGridView();
            this.button1Tra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgNguoimuon = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtManguoimuon = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBanDoc = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.bynTrahet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDssachdamuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNguoimuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dtgDssachdamuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 316);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách đã mượn";
            // 
            // dtgDssachdamuon
            // 
            this.dtgDssachdamuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDssachdamuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDssachdamuon.Location = new System.Drawing.Point(6, 45);
            this.dtgDssachdamuon.Name = "dtgDssachdamuon";
            this.dtgDssachdamuon.Size = new System.Drawing.Size(399, 265);
            this.dtgDssachdamuon.TabIndex = 0;
            // 
            // button1Tra
            // 
            this.button1Tra.Location = new System.Drawing.Point(387, 472);
            this.button1Tra.Name = "button1Tra";
            this.button1Tra.Size = new System.Drawing.Size(75, 23);
            this.button1Tra.TabIndex = 15;
            this.button1Tra.Text = "Trả";
            this.button1Tra.UseVisualStyleBackColor = true;
            this.button1Tra.Click += new System.EventHandler(this.button1Tra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgNguoimuon);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 316);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người trả";
            // 
            // dtgNguoimuon
            // 
            this.dtgNguoimuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNguoimuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNguoimuon.Location = new System.Drawing.Point(6, 45);
            this.dtgNguoimuon.Name = "dtgNguoimuon";
            this.dtgNguoimuon.Size = new System.Drawing.Size(410, 265);
            this.dtgNguoimuon.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(32, 403);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.ReadOnly = true;
            this.txtMasach.Size = new System.Drawing.Size(243, 20);
            this.txtMasach.TabIndex = 17;
            // 
            // txtManguoimuon
            // 
            this.txtManguoimuon.Location = new System.Drawing.Point(549, 403);
            this.txtManguoimuon.Name = "txtManguoimuon";
            this.txtManguoimuon.ReadOnly = true;
            this.txtManguoimuon.Size = new System.Drawing.Size(202, 20);
            this.txtManguoimuon.TabIndex = 18;
            this.txtManguoimuon.TextChanged += new System.EventHandler(this.txtManguoimuon_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 377);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtBanDoc
            // 
            this.txtBanDoc.Location = new System.Drawing.Point(549, 362);
            this.txtBanDoc.Name = "txtBanDoc";
            this.txtBanDoc.ReadOnly = true;
            this.txtBanDoc.Size = new System.Drawing.Size(202, 20);
            this.txtBanDoc.TabIndex = 20;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(32, 362);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.ReadOnly = true;
            this.txtTensach.Size = new System.Drawing.Size(243, 20);
            this.txtTensach.TabIndex = 21;
            // 
            // bynTrahet
            // 
            this.bynTrahet.Location = new System.Drawing.Point(663, 489);
            this.bynTrahet.Name = "bynTrahet";
            this.bynTrahet.Size = new System.Drawing.Size(118, 79);
            this.bynTrahet.TabIndex = 22;
            this.bynTrahet.Text = "Trả hết";
            this.bynTrahet.UseVisualStyleBackColor = true;
            this.bynTrahet.Click += new System.EventHandler(this.bynTrahet_Click);
            // 
            // Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 581);
            this.Controls.Add(this.bynTrahet);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.txtBanDoc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtManguoimuon);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1Tra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tra";
            this.Text = "Tra";
            this.Load += new System.EventHandler(this.Tra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDssachdamuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNguoimuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDssachdamuon;
        private System.Windows.Forms.Button button1Tra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgNguoimuon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtManguoimuon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBanDoc;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Button bynTrahet;
    }
}