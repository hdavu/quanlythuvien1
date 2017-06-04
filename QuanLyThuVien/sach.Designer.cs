namespace QuanLyThuVien
{
    partial class sach
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loaisachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.loaisachTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.loaisachTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Ten = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6ma = new System.Windows.Forms.TextBox();
            this.button4Luu = new System.Windows.Forms.Button();
            this.textBox5sl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox45xb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3tg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2nxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3Them = new System.Windows.Forms.Button();
            this.button2Xoa = new System.Windows.Forms.Button();
            this.button1Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaisachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loaisachBindingSource
            // 
            this.loaisachBindingSource.DataMember = "loaisach";
            this.loaisachBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaisachTableAdapter
            // 
            this.loaisachTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Size = new System.Drawing.Size(689, 526);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách";
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
            this.tacgia,
            this.namxb,
            this.nhaxb,
            this.loaisach});
            this.dataGridView1.Location = new System.Drawing.Point(8, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 402);
            this.dataGridView1.TabIndex = 5;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            // 
            // namxb
            // 
            this.namxb.DataPropertyName = "namxb";
            this.namxb.HeaderText = "Năm xuất bản";
            this.namxb.Name = "namxb";
            // 
            // nhaxb
            // 
            this.nhaxb.DataPropertyName = "nhaxb";
            this.nhaxb.HeaderText = "Nhà xuất bản";
            this.nhaxb.Name = "nhaxb";
            // 
            // loaisach
            // 
            this.loaisach.DataPropertyName = "ten1";
            this.loaisach.HeaderText = "Loại sách";
            this.loaisach.Name = "loaisach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm tên";
            // 
            // textBox1Ten
            // 
            this.textBox1Ten.Location = new System.Drawing.Point(130, 53);
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
            this.groupBox2.Controls.Add(this.textBox6ma);
            this.groupBox2.Controls.Add(this.button4Luu);
            this.groupBox2.Controls.Add(this.textBox5sl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox45xb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox3tg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2nxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3Them);
            this.groupBox2.Controls.Add(this.button2Xoa);
            this.groupBox2.Controls.Add(this.button1Sua);
            this.groupBox2.Location = new System.Drawing.Point(707, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 518);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // textBox6ma
            // 
            this.textBox6ma.Location = new System.Drawing.Point(371, 272);
            this.textBox6ma.Name = "textBox6ma";
            this.textBox6ma.ReadOnly = true;
            this.textBox6ma.Size = new System.Drawing.Size(165, 20);
            this.textBox6ma.TabIndex = 16;
            // 
            // button4Luu
            // 
            this.button4Luu.Location = new System.Drawing.Point(461, 321);
            this.button4Luu.Name = "button4Luu";
            this.button4Luu.Size = new System.Drawing.Size(75, 66);
            this.button4Luu.TabIndex = 15;
            this.button4Luu.Text = "Lưu";
            this.button4Luu.UseVisualStyleBackColor = true;
            this.button4Luu.Click += new System.EventHandler(this.button4Luu_Click);
            // 
            // textBox5sl
            // 
            this.textBox5sl.Location = new System.Drawing.Point(371, 218);
            this.textBox5sl.Name = "textBox5sl";
            this.textBox5sl.Size = new System.Drawing.Size(165, 20);
            this.textBox5sl.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.loaisachBindingSource;
            this.comboBox1.DisplayMember = "ten";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(371, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loại sách";
            // 
            // textBox45xb
            // 
            this.textBox45xb.Location = new System.Drawing.Point(96, 358);
            this.textBox45xb.Name = "textBox45xb";
            this.textBox45xb.Size = new System.Drawing.Size(153, 20);
            this.textBox45xb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Năm xuất bản";
            // 
            // textBox3tg
            // 
            this.textBox3tg.Location = new System.Drawing.Point(96, 283);
            this.textBox3tg.Name = "textBox3tg";
            this.textBox3tg.Size = new System.Drawing.Size(153, 20);
            this.textBox3tg.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tác giả";
            // 
            // textBox2nxb
            // 
            this.textBox2nxb.Location = new System.Drawing.Point(96, 218);
            this.textBox2nxb.Name = "textBox2nxb";
            this.textBox2nxb.Size = new System.Drawing.Size(153, 20);
            this.textBox2nxb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà xuất bản";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách";
            // 
            // button3Them
            // 
            this.button3Them.Location = new System.Drawing.Point(368, 45);
            this.button3Them.Name = "button3Them";
            this.button3Them.Size = new System.Drawing.Size(75, 23);
            this.button3Them.TabIndex = 2;
            this.button3Them.Text = "Thêm";
            this.button3Them.UseVisualStyleBackColor = true;
            this.button3Them.Click += new System.EventHandler(this.button3Them_Click);
            // 
            // button2Xoa
            // 
            this.button2Xoa.Location = new System.Drawing.Point(206, 45);
            this.button2Xoa.Name = "button2Xoa";
            this.button2Xoa.Size = new System.Drawing.Size(75, 23);
            this.button2Xoa.TabIndex = 1;
            this.button2Xoa.Text = "Xóa";
            this.button2Xoa.UseVisualStyleBackColor = true;
            this.button2Xoa.Click += new System.EventHandler(this.button2Xoa_Click);
            // 
            // button1Sua
            // 
            this.button1Sua.Location = new System.Drawing.Point(54, 45);
            this.button1Sua.Name = "button1Sua";
            this.button1Sua.Size = new System.Drawing.Size(75, 23);
            this.button1Sua.TabIndex = 0;
            this.button1Sua.Text = "Sửa";
            this.button1Sua.UseVisualStyleBackColor = true;
            this.button1Sua.Click += new System.EventHandler(this.button1Sua_Click);
            // 
            // sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "sach";
            this.Text = "sach";
            this.Load += new System.EventHandler(this.sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaisachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource loaisachBindingSource;
        private QuanLyThuVienDataSetTableAdapters.loaisachTableAdapter loaisachTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Ten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6ma;
        private System.Windows.Forms.Button button4Luu;
        private System.Windows.Forms.TextBox textBox5sl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox45xb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3tg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2nxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3Them;
        private System.Windows.Forms.Button button2Xoa;
        private System.Windows.Forms.Button button1Sua;
    }
}