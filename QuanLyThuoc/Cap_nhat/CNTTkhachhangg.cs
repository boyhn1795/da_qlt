using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc.Cap_nhat
{
    public partial class CNTTkhachhangg : Form
    {
        public CNTTkhachhangg()
        {
            InitializeComponent();
        }
        QuanLyThuocEntities db = new QuanLyThuocEntities();
        private void load_luoi()
        {
            khachHangDataGridView.AutoGenerateColumns = false;
            khachHangDataGridView.DataSource = db.KhachHangs.ToList();
        }
        void vohieuhoa(bool e)
        {
            tenKhachHangTextBox.Enabled = e;
            diaChiTextBox.Enabled = e;
            dienThoaiTextBox.Enabled = e;

        }
        void resettext()
        {
            tenKhachHangTextBox.ResetText();
            diaChiTextBox.ResetText();
            dienThoaiTextBox.ResetText();
            
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            else return false;
        }
        bool kiemtra_chuoi()
        {
            if (kiemtra(tenKhachHangTextBox.Text) || kiemtra(diaChiTextBox.Text) || kiemtra(dienThoaiTextBox.Text)) return false;
            return true;
        }
        private string AutoId()
        {
            return timid() < 10 ? "0" + timid() : timid().ToString();
        }
        private int timid()
        {
            int id;
            var q = (from m in db.KhachHangs
                     orderby m.MaKhachHang ascending
                     select m.MaKhachHang).Max();
            id = int.Parse(q.Replace("kh", ""));
            return id + 1;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

            if (bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                maKhachHangTextBox.Enabled = false;
                vohieuhoa(true);
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
            }
            else
            {
                if (kiemtra_chuoi())
                {
                    KhachHang sv = new KhachHang();
                    var qr1 = db.KhachHangs.Where(c => c.MaKhachHang == maKhachHangTextBox.Text);
                    sv = qr1.FirstOrDefault();
                    sv.TenKhachHang = tenKhachHangTextBox.Text;
                    sv.DiaChi = diaChiTextBox.Text;
                    sv.DienThoai = dienThoaiTextBox.Text;
                    
                    db.SaveChanges();
                    maKhachHangTextBox.Enabled = true;
                    bt_sua.Text = "Sửa";
                    resettext();
                    vohieuhoa(false);
                    load_luoi();
                    bt_xoa.Enabled = true;
                    bt_them.Enabled = true;
                    MessageBox.Show("Sửa thành công");
                }

            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            var q = from m in db.KhachHangs
                    where m.MaKhachHang == maKhachHangTextBox.Text
                    select m;
            kh = q.FirstOrDefault();
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
            MessageBox.Show("Xóa thành công");
            load_luoi();
        }

        private void khachHangDataGridView_SelectionChanged(object sender, EventArgs e)
        {
           

            if (khachHangDataGridView.SelectedRows.Count != 0)
            {
                maKhachHangTextBox.Text = khachHangDataGridView.CurrentRow.Cells[0].Value.ToString();
                tenKhachHangTextBox.Text = khachHangDataGridView.CurrentRow.Cells[1].Value.ToString();
                diaChiTextBox.Text = khachHangDataGridView.CurrentRow.Cells[2].Value.ToString();
                dienThoaiTextBox.Text = khachHangDataGridView.CurrentRow.Cells[3].Value.ToString();
              
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                bt_them.Text = "Lưu";
                vohieuhoa(true);
                resettext();
                bt_sua.Enabled = false;
                bt_xoa.Enabled = false;
            }
            else
            {
                var qr = db.KhachHangs.Where(c => c.MaKhachHang == maKhachHangTextBox.Text);
                var course = qr.SingleOrDefault();
                if (course == null)
                {
                    if (kiemtra_chuoi())
                    {
                        KhachHang dg = new KhachHang();
                        dg.MaKhachHang = "kh" + AutoId();
                        dg.TenKhachHang = tenKhachHangTextBox.Text;
                        dg.DiaChi = diaChiTextBox.Text;
                        
                        dg.DienThoai = dienThoaiTextBox.Text;
                        db.KhachHangs.Add(dg);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                        resettext();
                        bt_them.Text = "Thêm";
                        vohieuhoa(false);
                        load_luoi();
                        bt_sua.Enabled = true;
                        bt_xoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập thiếu dữu liệu!", "Thông báo");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Mã mặt hàng này đã tồn tại!", "Thông báo");
                        maKhachHangTextBox.ResetText();
                    }
                
            }
        }

        private void CNTTkhachhangg_Load(object sender, EventArgs e)
        {
            load_luoi();
        }
    }
    
}
