using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class quahan : Form
    {
        public quahan()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");

        private void LoadDataSachQUaHAn()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  s.ten, s.ma FROM phieumuon pm JOIN sach s ON pm.sachma = s.ma WHERE s.ten  LIKE  N'%" + textBox1.Text + "%' AND pm.ngayhentra < GETDATE() and pm.ngaytra is null", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;

            dataGridView1.Columns["ma"].Visible = false;
            dataGridView1.Columns["ten"].HeaderText = "Tên";

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "ma");

        }

        private void LoadDataSachQUaHAnMuonboi()
        {


            SqlDataAdapter sda = new SqlDataAdapter("SELECT  s.ten , s.msv    FROM phieumuon pm JOIN nguoimuon s ON s.ma = pm.nguoimuonma WHERE pm.sachma ='" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView2.DataSource = dt;
            dataGridView2.Columns["ten"].HeaderText = "Tên";
            dataGridView2.Columns["msv"].HeaderText = "Mã sinh viên";
        }

        private void quahan_Load(object sender, EventArgs e)
        {
            LoadDataSachQUaHAn();
            LoadDataSachQUaHAnMuonboi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDataSachQUaHAn();
            LoadDataSachQUaHAnMuonboi();
        }
    }
}
