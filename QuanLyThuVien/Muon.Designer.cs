namespace QuanLyThuVien
{
    partial class muon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.texSach = new System.Windows.Forms.TextBox();
            this.textMuon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.maSACH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maNG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsMuon = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timten = new System.Windows.Forms.TextBox();
            this.datNguoiDoc = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timsach = new System.Windows.Forms.TextBox();
            this.dtSach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMuon)).BeginInit();
            this.N.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datNguoiDoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.buttonC);
            this.groupBox2.Controls.Add(this.buttonM);
            this.groupBox2.Controls.Add(this.texSach);
            this.groupBox2.Controls.Add(this.textMuon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpMuon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpTra);
            this.groupBox2.Controls.Add(this.maSACH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maNG);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(456, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 269);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(434, 237);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 29;
            this.buttonC.Text = "Thôi";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(235, 237);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(75, 23);
            this.buttonM.TabIndex = 28;
            this.buttonM.Text = "Mượn";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // texSach
            // 
            this.texSach.Location = new System.Drawing.Point(388, 26);
            this.texSach.Name = "texSach";
            this.texSach.ReadOnly = true;
            this.texSach.Size = new System.Drawing.Size(121, 20);
            this.texSach.TabIndex = 27;
            // 
            // textMuon
            // 
            this.textMuon.Location = new System.Drawing.Point(136, 29);
            this.textMuon.Name = "textMuon";
            this.textMuon.ReadOnly = true;
            this.textMuon.Size = new System.Drawing.Size(121, 20);
            this.textMuon.TabIndex = 26;
          //  this.textMuon.TextChanged += new System.EventHandler(this.textMuon_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày mượn";
            // 
            // dtpMuon
            // 
            this.dtpMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMuon.Location = new System.Drawing.Point(139, 157);
            this.dtpMuon.Name = "dtpMuon";
            this.dtpMuon.Size = new System.Drawing.Size(121, 20);
            this.dtpMuon.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày hẹn trả";
            // 
            // dtpTra
            // 
            this.dtpTra.CustomFormat = "dd/MM/yyyy";
            this.dtpTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTra.Location = new System.Drawing.Point(389, 158);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(121, 20);
            this.dtpTra.TabIndex = 22;
            // 
            // maSACH
            // 
            this.maSACH.Location = new System.Drawing.Point(389, 63);
            this.maSACH.Name = "maSACH";
            this.maSACH.ReadOnly = true;
            this.maSACH.Size = new System.Drawing.Size(121, 20);
            this.maSACH.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên sách";
            // 
            // maNG
            // 
            this.maNG.Location = new System.Drawing.Point(136, 63);
            this.maNG.Name = "maNG";
            this.maNG.ReadOnly = true;
            this.maNG.Size = new System.Drawing.Size(121, 20);
            this.maNG.TabIndex = 14;
            this.maNG.TextChanged += new System.EventHandler(this.maNG_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Người mượn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dsMuon);
            this.groupBox1.Location = new System.Drawing.Point(456, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách đã mượn";
            // 
            // dsMuon
            // 
            this.dsMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMuon.Location = new System.Drawing.Point(6, 19);
            this.dsMuon.Name = "dsMuon";
            this.dsMuon.Size = new System.Drawing.Size(521, 181);
            this.dsMuon.TabIndex = 0;
            // 
            // N
            // 
            this.N.Controls.Add(this.button1);
            this.N.Controls.Add(this.timten);
            this.N.Controls.Add(this.datNguoiDoc);
            this.N.Location = new System.Drawing.Point(12, 12);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(438, 269);
            this.N.TabIndex = 14;
            this.N.TabStop = false;
            this.N.Text = "Người mượn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timten
            // 
            this.timten.Location = new System.Drawing.Point(118, 29);
            this.timten.Name = "timten";
            this.timten.Size = new System.Drawing.Size(152, 20);
            this.timten.TabIndex = 1;
            this.timten.TextChanged += new System.EventHandler(this.timten_TextChanged);
            // 
            // datNguoiDoc
            // 
            this.datNguoiDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datNguoiDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datNguoiDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datNguoiDoc.Location = new System.Drawing.Point(6, 74);
            this.datNguoiDoc.Name = "datNguoiDoc";
            this.datNguoiDoc.Size = new System.Drawing.Size(426, 189);
            this.datNguoiDoc.TabIndex = 0;
     ////       this.datNguoiDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datNguoiDoc_CellClick);
//this.datNguoiDoc.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.datNguoiDoc_CellStateChanged);
          //  this.datNguoiDoc.Click += new System.EventHandler(this.datNguoiDoc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.timsach);
            this.groupBox4.Controls.Add(this.dtSach);
            this.groupBox4.Location = new System.Drawing.Point(12, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 206);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên sách";
            // 
            // timsach
            // 
            this.timsach.Location = new System.Drawing.Point(118, 42);
            this.timsach.Name = "timsach";
            this.timsach.Size = new System.Drawing.Size(152, 20);
            this.timsach.TabIndex = 2;
            this.timsach.TextChanged += new System.EventHandler(this.timsach_TextChanged);
            // 
            // dtSach
            // 
            this.dtSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSach.Location = new System.Drawing.Point(6, 68);
            this.dtSach.Name = "dtSach";
            this.dtSach.Size = new System.Drawing.Size(426, 132);
            this.dtSach.TabIndex = 0;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(388, 103);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.ReadOnly = true;
            this.txtSoluong.Size = new System.Drawing.Size(121, 20);
            this.txtSoluong.TabIndex = 30;
            // 
            // muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.N);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "muon";
            this.Text = "Muon";
            this.Load += new System.EventHandler(this.Muon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMuon)).EndInit();
            this.N.ResumeLayout(false);
            this.N.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datNguoiDoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.TextBox maSACH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maNG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dsMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMuon;
        private System.Windows.Forms.TextBox texSach;
        private System.Windows.Forms.TextBox textMuon;
        private System.Windows.Forms.GroupBox N;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView datNguoiDoc;
        private System.Windows.Forms.DataGridView dtSach;
        private System.Windows.Forms.TextBox timten;
        private System.Windows.Forms.TextBox timsach;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoluong;
    }
}