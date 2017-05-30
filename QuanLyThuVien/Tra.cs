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
    public partial class Tra : Form
    {
        public Tra()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");


        private void LoadDataNguoidoc()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, msv FROM nguoimuon WHERE ten LIKE N'%" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dtgNguoimuon.DataSource = dt;
            dtgNguoimuon.Columns["ma"].Visible = false;

            txtManguoimuon.DataBindings.Clear();
            txtBanDoc.DataBindings.Clear();

            txtManguoimuon.DataBindings.Add("Text", dtgNguoimuon.DataSource, "ma");
            txtBanDoc.DataBindings.Add("Text", dtgNguoimuon.DataSource, "ten");
        }


        private void LoadDataSachDaMuon()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT s.ma, s.ten, s.tacgia   FROM sach s JOIN phieumuon pm ON s.ma = pm.sachma WHERE pm.nguoimuonma = '" + txtManguoimuon.Text + "' AND pm.ngaytra IS NULL", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dtgDssachdamuon.DataSource = dt;
            dtgDssachdamuon.Columns["ma"].Visible = false;

            txtMasach.DataBindings.Clear();
            txtTensach.DataBindings.Clear();
            txtMasach.DataBindings.Add("Text", dtgDssachdamuon.DataSource, "ma");
            txtTensach.DataBindings.Add("Text", dtgDssachdamuon.DataSource, "ten");


        }

        private void Tra_Load(object sender, EventArgs e)
        {
            LoadDataNguoidoc();
            LoadDataSachDaMuon();
        }

        private void txtManguoimuon_TextChanged(object sender, EventArgs e)
        {
            LoadDataSachDaMuon();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDataNguoidoc();
        }

        private void button1Tra_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(txtBanDoc.Text + " trả " +txtTensach.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                con.Open();

                string chuoisql = "update  phieumuon set ngaytra =  N'{0}' WHERE sachma = N'{1}' AND nguoimuonma = N'{2}'";
                string them = string.Format(chuoisql, dateTimePicker1.Value.ToString("MM-dd-yyyy"), txtMasach.Text, "1", txtManguoimuon.Text);
                SqlCommand cmd = new SqlCommand(them, con);


                string chuoisql2 = "UPDATE sach SET soluong = soluong + 1 WHERE ma = N'{0}'";
                string them2 = string.Format(chuoisql2, txtMasach.Text);
                SqlCommand cmd2 = new SqlCommand(them2, con);


                try
                {
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công");
                    LoadDataSachDaMuon();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void bynTrahet_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show(txtBanDoc.Text + " trả hết sách ?!!" , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                con.Open();

                string chuoisql = "update  p set p.ngaytra =  GETDATE() FROM phieumuon AS p INNER JOIN nguoimuon AS n ON p.nguoimuonma = n.ma WHERE n.ma = N'{0}' AND p.ngaytra IS NULL ";
                string them = string.Format(chuoisql,  txtManguoimuon.Text);
                SqlCommand cmd = new SqlCommand(them, con);


                string chuoisql2 = "UPDATE s SET s.soluong = s.soluong + 1 FROM sach AS s INNER JOIN phieumuon AS p ON p.sachma = s.ma WHERE p.nguoimuonma = N'{0}' ";
                string them2 = string.Format(chuoisql2, txtMasach.Text);
                SqlCommand cmd2 = new SqlCommand(them2, con);


                try
                {
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công");
                    LoadDataSachDaMuon();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }

        }
    }
}
