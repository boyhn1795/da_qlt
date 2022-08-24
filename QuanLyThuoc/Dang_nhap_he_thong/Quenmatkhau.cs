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
    public partial class Quenmatkhau : Form
    {
        public Quenmatkhau()
        {
            InitializeComponent();
        }

        private void bt_xn_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text == "" || txt_mk.Text == "" || txt_lmk.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu!");
            }
            else
            {
                if (txt_mk.Text != txt_lmk.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác!");
                }
                else
                {
                    QuanLyThuocEntities db = new QuanLyThuocEntities();
                    var query = db.NhanViens.Where(c => c.TenNhanVien == txt_ten.Text);
                    var course = query.SingleOrDefault();
                    if (course == null)
                    {
                        MessageBox.Show("Thông tin chưa chính xác!");
                    }
                    else
                    {
                        NhanVien nv = db.NhanViens.Single(c => c.TenNhanVien == txt_ten.Text);
                        nv.MatKhau = txt_mk.Text;
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Quenmatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
