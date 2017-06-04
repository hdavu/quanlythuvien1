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
    public partial class nguoidoc : Form
    {
        public nguoidoc()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");


        private void LoadData()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, msv FROM nguoimuon WHERE ten LIKE N'%" + textBox1Ten.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "ma");
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "ten");
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "msv");

        }


        public void trangthaidau()
        {
            LoadData();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            button2Xoa.Enabled = true;
            button1Sua.Enabled = true;
            button4Luu.Enabled = false;
            button3Them.Enabled = true;
        }

    

        private void nguoidoc_Load(object sender, EventArgs e)
        {
            trangthaidau();
        }

        private void button1Sua_Click_1(object sender, EventArgs e)
        {
            button2Xoa.Enabled = false;
            button3Them.Enabled = false;
            button4Luu.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;

        }

        private void button2Xoa_Click_1(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sua = string.Format("delete from nguoimuon where ma={0}", textBox3.Text);
                SqlCommand cmd = new SqlCommand(sua, con);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    con.Close();
                    trangthaidau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }

        }

        private void button3Them_Click_1(object sender, EventArgs e)
        {
            button2Xoa.Enabled = false;
            button1Sua.Enabled = false;
            button4Luu.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Them";

        }

        private void button4Luu_Click_1(object sender, EventArgs e)
        {

            //them

            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.Text == "Them")
            {

                if ((MessageBox.Show("Bạn muốn thêm người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into nguoimuon(ten,msv) select N'{0}',N'{1}'";
                    string them = string.Format(chuoisql, textBox1.Text, textBox2.Text);
                    SqlCommand cmd = new SqlCommand(them, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();
                        trangthaidau();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                    trangthaidau();
            }


            //sua


            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.Text != "Them")
            {

                if ((MessageBox.Show("Bạn muốn sửa người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = string.Format("update nguoimuon set ten = N'{0}', msv = N'{1}' WHERE ma = N'{2}' ", textBox1.Text, textBox2.Text, textBox3.Text);
                    SqlCommand cmd = new SqlCommand(chuoisql, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
                        con.Close();
                        trangthaidau();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                    trangthaidau();
            }

        }

        private void textBox1Ten_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

