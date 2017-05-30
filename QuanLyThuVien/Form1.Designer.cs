namespace QuanLyThuVien
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiĐọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchQuáHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.quảnLýNgườiĐọcToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.sáchQuáHạnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.qToolStripMenuItem.Text = "Quản lý sách";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // quảnLýNgườiĐọcToolStripMenuItem
            // 
            this.quảnLýNgườiĐọcToolStripMenuItem.Name = "quảnLýNgườiĐọcToolStripMenuItem";
            this.quảnLýNgườiĐọcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýNgườiĐọcToolStripMenuItem.Text = "Quản lý người đọc";
            this.quảnLýNgườiĐọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiĐọcToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnToolStripMenuItem,
            this.trảToolStripMenuItem});
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn - Trả sách";
            // 
            // mượnToolStripMenuItem
            // 
            this.mượnToolStripMenuItem.Name = "mượnToolStripMenuItem";
            this.mượnToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.mượnToolStripMenuItem.Text = "Mượn";
            this.mượnToolStripMenuItem.Click += new System.EventHandler(this.mượnToolStripMenuItem_Click);
            // 
            // trảToolStripMenuItem
            // 
            this.trảToolStripMenuItem.Name = "trảToolStripMenuItem";
            this.trảToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.trảToolStripMenuItem.Text = "Trả";
            this.trảToolStripMenuItem.Click += new System.EventHandler(this.trảToolStripMenuItem_Click);
            // 
            // sáchQuáHạnToolStripMenuItem
            // 
            this.sáchQuáHạnToolStripMenuItem.Name = "sáchQuáHạnToolStripMenuItem";
            this.sáchQuáHạnToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sáchQuáHạnToolStripMenuItem.Text = "Sách quá hạn";
            this.sáchQuáHạnToolStripMenuItem.Click += new System.EventHandler(this.sáchQuáHạnToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 515);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiĐọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchQuáHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}

