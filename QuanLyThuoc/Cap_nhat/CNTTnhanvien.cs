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
    public partial class CNTTnhanvien : Form
    {
        public CNTTnhanvien()
        {
            InitializeComponent();
        }
        QuanLyThuocEntities db = new QuanLyThuocEntities();
        private void load_dulieu()
        {
            nhanVienDataGridView.AutoGenerateColumns = false;
            nhanVienDataGridView.DataSource = db.NhanViens.ToList();
        }
        void vohieuhoa(bool e)
        {
            tenNhanVienTextBox.Enabled = e;
            diaChiTextBox.Enabled = e;
            dienThoaiTextBox.Enabled = e;
            ngaySinhDateTimePicker.Enabled = e;
            gioiTinhComboBox.Enabled = e;
            chucVuTextBox.Enabled = e;
            matKhauTextBox.Enabled = e;
            matKhauCap2TextBox.Enabled = e;


        }
        void resettext()
        {
            tenNhanVienTextBox.ResetText();
            diaChiTextBox.ResetText();
            dienThoaiTextBox.ResetText();
            ngaySinhDateTimePicker.ResetText();
            gioiTinhComboBox.ResetText();
            chucVuTextBox.ResetText();
            matKhauTextBox.ResetText();
            matKhauCap2TextBox.ResetText();


        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            else return false;
        }
        bool kiemtra_chuoi()
        {
            if (kiemtra(maNhanVienTextBox.Text) || kiemtra(tenNhanVienTextBox.Text) || kiemtra(dienThoaiTextBox.Text) || kiemtra(diaChiTextBox.Text) || kiemtra(ngaySinhDateTimePicker.Text) || kiemtra(chucVuTextBox.Text) || kiemtra(matKhauTextBox.Text)|| kiemtra(matKhauCap2TextBox.Text)|| kiemtra(gioiTinhComboBox.Text))  return false;
            return true;
        }
        private void CNTTnhanvien_Load(object sender, EventArgs e)
        {
            load_dulieu();
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
                var qr = db.NhanViens.Where(c => c.MaNhanVien == maNhanVienTextBox.Text);
                var course = qr.SingleOrDefault();
                if (course == null)
                {
                    if (kiemtra_chuoi())
                    {
                        NhanVien nv = new NhanVien();
                        nv.MaNhanVien = maNhanVienTextBox.Text;
                        nv.TenNhanVien = tenNhanVienTextBox.Text;
                        nv.DiaChi = diaChiTextBox.Text;
                        nv.DienThoai = dienThoaiTextBox.Text;
                        nv.GioiTinh = gioiTinhComboBox.Text;
                        nv.MatKhau = matKhauTextBox.Text;
                        nv.NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text);
                        nv.MatKhauCap2 = matKhauCap2TextBox.Text;
                        nv.ChucVu = chucVuTextBox.Text;
                        db.NhanViens.Add(nv);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                        resettext();
                        bt_them.Text = "Thêm";
                        vohieuhoa(false);
                        load_dulieu();
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
                    MessageBox.Show("Mã nhân viên này đã tồn tại!", "Thông báo");
                    maNhanVienTextBox.ResetText();
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                maNhanVienTextBox.Enabled = false;
                vohieuhoa(true);
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
            }
            else
            {
                if (kiemtra_chuoi())
                {
                    NhanVien nv = new NhanVien();
                    var qr1 = db.NhanViens.Where(c => c.MaNhanVien == maNhanVienTextBox.Text);
                    nv = qr1.FirstOrDefault();
                    nv.TenNhanVien = tenNhanVienTextBox.Text;
                    nv.DiaChi = diaChiTextBox.Text;
                    nv.DienThoai = dienThoaiTextBox.Text;
                    nv.GioiTinh = gioiTinhComboBox.Text;
                    nv.NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text);
                    nv.ChucVu = chucVuTextBox.Text;
                    nv.MatKhau = matKhauTextBox.Text;
                    nv.MatKhauCap2 = matKhauCap2TextBox.Text;
                    db.SaveChanges();
                    maNhanVienTextBox.Enabled = true;
                    bt_sua.Text = "Sửa";
                    resettext();
                    vohieuhoa(false);
                    load_dulieu();
                    bt_xoa.Enabled = true;
                    bt_them.Enabled = true;
                    MessageBox.Show("Sửa thành công");
                }

            }
        }

        private void nhanVienDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (nhanVienDataGridView.SelectedRows.Count != 0)
            {
                maNhanVienTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[0].Value.ToString();
                tenNhanVienTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[1].Value.ToString();
                matKhauTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[2].Value.ToString();
                gioiTinhComboBox.Text = nhanVienDataGridView.CurrentRow.Cells[3].Value.ToString();
                ngaySinhDateTimePicker.Text = nhanVienDataGridView.CurrentRow.Cells[4].Value.ToString();
                dienThoaiTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[5].Value.ToString();
                diaChiTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[5].Value.ToString();
                matKhauCap2TextBox.Text = nhanVienDataGridView.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var qr2 = db.NhanViens.Where(c => c.MaNhanVien == maNhanVienTextBox.Text);
                db.NhanViens.Remove(qr2.FirstOrDefault());
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
            }
            load_dulieu();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {

        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            FrmrpNhanvien f = new FrmrpNhanvien();
            f.ShowDialog();
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
