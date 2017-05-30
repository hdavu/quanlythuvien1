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
    public partial class muon : Form
    {
        public muon()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");


        private void LoadDataNguoidoc()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, msv FROM nguoimuon WHERE ten LIKE N'%" + timten.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            datNguoiDoc.DataSource = dt;

            textMuon.DataBindings.Clear();
            maNG.DataBindings.Clear();

            textMuon.DataBindings.Add("Text", datNguoiDoc.DataSource, "ten");
            maNG.DataBindings.Add("Text", datNguoiDoc.DataSource, "ma");

        }



        private void LoadDataSach()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT s.ma, s.ten, s.soluong, s.namxb, s.nhaxb, s.tacgia , ls.ten  FROM sach s JOIN loaisach ls ON s.loaisachma = ls.ma WHERE s.ten LIKE N'%" + timsach.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dtSach.DataSource = dt;
            dtSach.Columns["ma"].Visible = false;
            dtSach.Columns["soluong"].Visible = false;
            texSach.DataBindings.Clear();
            maSACH.DataBindings.Clear();
            txtSoluong.DataBindings.Clear();

            texSach.DataBindings.Add("Text", dtSach.DataSource, "ten");
            maSACH.DataBindings.Add("Text", dtSach.DataSource, "ma");
            txtSoluong.DataBindings.Add("Text", dtSach.DataSource, "soluong");

        }

        private void LoadDataSachDaMuon()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  s.ten, s.tacgia   FROM sach s JOIN phieumuon pm ON s.ma = pm.sachma WHERE pm.nguoimuonma = '" + maNG.Text + "' AND pm.ngaytra IS NULL", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dsMuon.DataSource = dt;
           

           

        }



        private void Muon_Load(object sender, EventArgs e)
        {
            LoadDataSach();
            LoadDataNguoidoc();
            LoadDataSachDaMuon();
        }

        private void timten_TextChanged(object sender, EventArgs e)
        {
            LoadDataNguoidoc();
        }

        private void timsach_TextChanged(object sender, EventArgs e)
        {
            LoadDataSach();
        }

        public int hetsach()
        {
            if (txtSoluong.Text == "0")
                return 1;
            else
                return 0;

        }

        public int damuon()
        {
            SqlDataAdapter da;
            con.Open();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("select * from phieumuon where sachma =  '" + maSACH.Text + "' and nguoimuonma = '" + maNG.Text + "' and ngaytra is null", con);
            da = new SqlDataAdapter(cmd);

            con.Close();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
                return 1;
            else
                return 0;
        }


        private void buttonM_Click(object sender, EventArgs e)
        {

            if (hetsach() == 1)
                MessageBox.Show("Hết sách");
            else if (damuon() == 1)
                MessageBox.Show("Đã mượn");
            else if (dtpMuon.Value.ToString() == dtpTra.Value.ToString())
                MessageBox.Show("Chưa chọn ngày trả sách");
            else


            if (texSach.TextLength > 0 && textMuon.TextLength > 0)
            {

                if ((MessageBox.Show("OK?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into phieumuon( sachma,nguoimuonma,soluong, ngaymuon, ngayhentra) select N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'";
                    string them = string.Format(chuoisql, maSACH.Text, maNG.Text, "1", dtpMuon.Value.ToString("MM-dd-yyyy"), dtpTra.Value.ToString("MM-dd-yyyy"));
                    SqlCommand cmd = new SqlCommand(them, con);


                    string chuoisql2 = "UPDATE sach SET soluong = soluong - 1 WHERE ma = N'{0}'";
                    string them2 = string.Format(chuoisql2, maSACH.Text);
                    SqlCommand cmd2 = new SqlCommand(them2, con);


                    try
                    {
                        cmd2.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thành công");
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = damuon();

            MessageBox.Show(i.ToString());
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void maNG_TextChanged(object sender, EventArgs e)
        {
            LoadDataSachDaMuon();

        }
    }
}

