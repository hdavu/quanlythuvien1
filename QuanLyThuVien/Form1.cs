using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        quahan fqh = new quahan();
        muon fmuon = new muon();
        Tra frmtra = new Tra();
        nguoidoc frmnd = new nguoidoc();
        sach frmsach = new sach();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsach.ShowDialog();
        }

        private void quảnLýNgườiĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnd.ShowDialog();
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmuon.ShowDialog();
        }

        private void trảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtra.ShowDialog();
        }

        private void sáchQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fqh.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine("G:\\QuanLyThuVien\\huongdan.htm"));
        }
    }
}
