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
    public partial class sach : Form
    {
        public sach()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");


        private void LoadData()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT s.ma, s.ten, s.soluong, s.namxb, s.nhaxb, s.tacgia , ls.ten  FROM sach s JOIN loaisach ls ON s.loaisachma = ls.ma WHERE s.ten LIKE N'%" + textBox1Ten.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ma"].Visible = false;
            dataGridView1.Columns["soluong"].Visible = false;
            textBox1.DataBindings.Clear();
            textBox2nxb.DataBindings.Clear();
            textBox3tg.DataBindings.Clear();
            textBox45xb.DataBindings.Clear();
            textBox5sl.DataBindings.Clear();
            textBox6ma.DataBindings.Clear();
            comboBox1.DataBindings.Clear();


            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "ten");
            textBox3tg.DataBindings.Add("Text", dataGridView1.DataSource, "tacgia");
            textBox2nxb.DataBindings.Add("Text", dataGridView1.DataSource, "nhaxb");
            textBox45xb.DataBindings.Add("Text", dataGridView1.DataSource, "namxb");
            textBox5sl.DataBindings.Add("Text", dataGridView1.DataSource, "soluong");
            comboBox1.DataBindings.Add("Text", dataGridView1.DataSource, "ten1");
            textBox6ma.DataBindings.Add("Text", dataGridView1.DataSource, "ma");

        }


        public void trangthaidau()
        {
            LoadData();
            textBox1.ReadOnly = true;
            textBox2nxb.ReadOnly = true;
            textBox3tg.ReadOnly = true;
            textBox45xb.ReadOnly = true;
            textBox5sl.ReadOnly = true;
            textBox6ma.ReadOnly = true;

            comboBox1.Enabled = false;

            button2Xoa.Enabled = true;
            button1Sua.Enabled = true;
            button4Luu.Enabled = false;
            button3Them.Enabled = true;
        }

        private void sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.loaisach' table. You can move, or remove it, as needed.
            this.loaisachTableAdapter.Fill(this.quanLyThuVienDataSet.loaisach);
            trangthaidau();
        }

        private void button1Sua_Click(object sender, EventArgs e)
        {

            button2Xoa.Enabled = false;
            button3Them.Enabled = false;
            button4Luu.Enabled = true;

            textBox1.ReadOnly = false;
            textBox2nxb.ReadOnly = false;
            textBox3tg.ReadOnly = false;
            textBox45xb.ReadOnly = false;
            textBox5sl.ReadOnly = false;
            comboBox1.Enabled = true;

        }

        private void button2Xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sua = string.Format("delete from sach where ma={0}", textBox6ma.Text);
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

        private void button3Them_Click(object sender, EventArgs e)
        {


            button2Xoa.Enabled = false;
            button1Sua.Enabled = false;
            button4Luu.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2nxb.ReadOnly = false;
            textBox3tg.ReadOnly = false;
            textBox45xb.ReadOnly = false;
            textBox5sl.ReadOnly = false;

            textBox1.Clear();
            textBox2nxb.Clear();
            textBox3tg.Clear();
            textBox45xb.Clear();
            textBox5sl.Clear();
            textBox6ma.Text = "Them";
            comboBox1.Enabled = true;

        }

        private void textBox1Ten_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4Luu_Click(object sender, EventArgs e)
        {
            //them

            if (textBox1.TextLength > 0 && textBox2nxb.TextLength > 0 && textBox3tg.TextLength > 0 && textBox45xb.TextLength > 0 && textBox5sl.TextLength > 0 && textBox6ma.Text == "Them")
            {

                if ((MessageBox.Show("Bạn muốn thêm người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into sach( ten, namxb, nhaxb, soluong, tacgia, loaisachma) select N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',loaisach.ma FROM loaisach where loaisach.ten = N'{5}' ";
                    string them = string.Format(chuoisql, textBox1.Text, textBox45xb.Text, textBox2nxb.Text, textBox5sl.Text, textBox3tg.Text, comboBox1.Text);
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


            if (textBox1.TextLength > 0 && textBox2nxb.TextLength > 0 && textBox3tg.TextLength > 0 && textBox45xb.TextLength > 0 && textBox5sl.TextLength > 0 && textBox6ma.Text != "Them")
            {

                if ((MessageBox.Show("Bạn muốn sửa người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = string.Format("update sach set ten =N'{0}', namxb =N'{1}', nhaxb =N'{2}', soluong=N'{3}' , tacgia=N'{4}', loaisachma= ( select loaisach.ma FROM loaisach where loaisach.ten = N'{5}')  WHERE ma = N'{6}' ", textBox1.Text, textBox45xb.Text, textBox2nxb.Text, textBox5sl.Text, textBox3tg.Text, comboBox1.Text, textBox6ma.Text);
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
    }
}
