using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap_he_thong.Dangnhap f = new Dang_nhap_he_thong.Dangnhap();
            f.ShowDialog();
        }

        private void lấyLạiMặtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap_he_thong.Quenmatkhau f = new Dang_nhap_he_thong.Quenmatkhau();
            f.ShowDialog();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap_nhat.CNTTkhachhangg f = new Cap_nhat.CNTTkhachhangg();
            f.ShowDialog();
        }

        private void thôngTinMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap_nhat.CNTTmathang f = new Cap_nhat.CNTTmathang();
            f.ShowDialog();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap_nhat.CNTTnhanvien f = new Cap_nhat.CNTTnhanvien();
            f.ShowDialog();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            lb_tendn.Text = "Xin Chào:" + Dang_nhap_he_thong.Dangnhap.Tennv;
            lb_cv.Text = "Chức vụ:" + Dang_nhap_he_thong.Dangnhap.chucvu;
            if (Dang_nhap_he_thong.Dangnhap.chucvu == "Nhân viên")
            {
              
            }
        }

        private void bt_dx_Click(object sender, EventArgs e)
        {
            Dang_nhap_he_thong.Dangnhap f = new Dang_nhap_he_thong.Dangnhap();
            f.Show();
            this.Hide();
        }
    }
}
