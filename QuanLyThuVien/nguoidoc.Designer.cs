namespace QuanLyThuVien
{
    partial class nguoidoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Ten = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4Luu = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3Them = new System.Windows.Forms.Button();
            this.button2Xoa = new System.Windows.Forms.Button();
            this.button1Sua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1Ten);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 522);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người đọc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.msv});
            this.dataGridView1.Location = new System.Drawing.Point(8, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(426, 410);
            this.dataGridView1.TabIndex = 5;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.Name = "msv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm tên";
            // 
            // textBox1Ten
            // 
            this.textBox1Ten.Location = new System.Drawing.Point(84, 48);
            this.textBox1Ten.Name = "textBox1Ten";
            this.textBox1Ten.Size = new System.Drawing.Size(121, 20);
            this.textBox1Ten.TabIndex = 1;
            this.textBox1Ten.TextChanged += new System.EventHandler(this.textBox1Ten_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button4Luu);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3Them);
            this.groupBox2.Controls.Add(this.button2Xoa);
            this.groupBox2.Controls.Add(this.button1Sua);
            this.groupBox2.Location = new System.Drawing.Point(458, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 518);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 16;
            // 
            // button4Luu
            // 
            this.button4Luu.Enabled = false;
            this.button4Luu.Location = new System.Drawing.Point(235, 305);
            this.button4Luu.Name = "button4Luu";
            this.button4Luu.Size = new System.Drawing.Size(75, 66);
            this.button4Luu.TabIndex = 15;
            this.button4Luu.Text = "Lưu";
            this.button4Luu.UseVisualStyleBackColor = true;
            this.button4Luu.Click += new System.EventHandler(this.button4Luu_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên bạn đọc";
            // 
            // button3Them
            // 
            this.button3Them.Location = new System.Drawing.Point(343, 51);
            this.button3Them.Name = "button3Them";
            this.button3Them.Size = new System.Drawing.Size(75, 23);
            this.button3Them.TabIndex = 2;
            this.button3Them.Text = "Thêm";
            this.button3Them.UseVisualStyleBackColor = true;
            this.button3Them.Click += new System.EventHandler(this.button3Them_Click_1);
            // 
            // button2Xoa
            // 
            this.button2Xoa.Location = new System.Drawing.Point(235, 51);
            this.button2Xoa.Name = "button2Xoa";
            this.button2Xoa.Size = new System.Drawing.Size(75, 23);
            this.button2Xoa.TabIndex = 1;
            this.button2Xoa.Text = "Xóa";
            this.button2Xoa.UseVisualStyleBackColor = true;
            this.button2Xoa.Click += new System.EventHandler(this.button2Xoa_Click_1);
            // 
            // button1Sua
            // 
            this.button1Sua.Location = new System.Drawing.Point(125, 50);
            this.button1Sua.Name = "button1Sua";
            this.button1Sua.Size = new System.Drawing.Size(75, 23);
            this.button1Sua.TabIndex = 0;
            this.button1Sua.Text = "Sửa";
            this.button1Sua.UseVisualStyleBackColor = true;
            this.button1Sua.Click += new System.EventHandler(this.button1Sua_Click_1);
            // 
            // nguoidoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "nguoidoc";
            this.Text = "nguoidoc";
            this.Load += new System.EventHandler(this.nguoidoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Ten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4Luu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3Them;
        private System.Windows.Forms.Button button2Xoa;
        private System.Windows.Forms.Button button1Sua;
    }
}