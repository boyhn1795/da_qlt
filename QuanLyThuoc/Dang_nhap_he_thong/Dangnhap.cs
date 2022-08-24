using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc.Dang_nhap_he_thong
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        QuanLyThuocEntities db = new QuanLyThuocEntities();
        public static string Tennv = "";
        public static string chucvu = "";
        void vaotrangchu()
        {
            var q = db.NhanViens.Where(d => d.TenNhanVien == txt_ten.Text).Where(c => c.MatKhau == txt_mk.Text);
            var kt = q.SingleOrDefault();
            if (kt == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác");
            }
            else
            {
                NhanVien nv = new NhanVien();
                var q1 = from d in db.NhanViens
                         where d.TenNhanVien == txt_ten.Text
                         select d;
                nv = q1.FirstOrDefault();
                string cv = nv.ChucVu.ToString();
                chucvu = cv;
                
                string tennv = nv.TenNhanVien.ToString();
                Tennv = tennv;
               Trangchu tc = new Trangchu();
                tc.Show();
                this.Hide();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            vaotrangchu();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau f = new Quenmatkhau();
            f.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hien.Checked)
            {
                txt_mk.PasswordChar = (char)0;
            }
            else
            {
                txt_mk.PasswordChar = '☺';
            }

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
