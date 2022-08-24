using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThuoc.Cap_nhat
{
    public partial class CNTTmathang : Form
    {
        public CNTTmathang()
        {
            InitializeComponent();
        }
        QuanLyThuocEntities db = new QuanLyThuocEntities();
        private void load_dulieu()
        {
            thuocDataGridView.AutoGenerateColumns = false;
            thuocDataGridView.DataSource = db.Thuocs.ToList();
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        //Hàm chuyển đổi từ byte sang ảnh
        private Image ConvertBytetoImage(byte[] anh)
        {
            Image newImage;
            using (MemoryStream ms = new MemoryStream(anh, 0, anh.Length))
            {
                ms.Write(anh, 0, anh.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
            //lấy ảnh từ csdl hthi lên PictureBox
            string ma;
            var q = db.Thuocs.Where(d => d.MaThuoc.Equals(ma));
            Thuoc sv = new Thuoc();
            sv = q.FirstOrDefault();
            pictureBox1.Image = ConvertBytetoImage(sv.Anh);
        }
        //Hàm chuyển đổi sang kiểu byte
        private byte[] ConverFiletobyte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fstream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numBytes);
            return data;
            //Cách gọi hàm và thêm vào csdl
            Thuoc t = new Thuoc();
            t.MaThuoc = maThuocTextBox.Text;
            t.TenThuoc = tenThuocTextBox.Text;
            t.NhaSanXuat = nhaSanXuatTextBox.Text;
            t.DonViTinh = donViTinhTextBox.Text;
            t.TonKho = int.Parse(tonKhoTextBox.Text);
            t.DonGia = int.Parse(donGiaTextBox.Text);
            t.Anh = ConverFiletobyte(pictureBox1.ImageLocation);
            db.Thuocs.Add(t);
            db.SaveChanges();
        }
        void vohieuhoa(bool e)
        {
            tenThuocTextBox.Enabled = e;
            nhaSanXuatTextBox.Enabled = e;
            donViTinhTextBox.Enabled = e;
            tonKhoTextBox.Enabled = e;
            donGiaTextBox.Enabled = e;
          

        }
        void resettext()
        {
            tenThuocTextBox.ResetText();

            nhaSanXuatTextBox.ResetText();
            donViTinhTextBox.ResetText();
            tonKhoTextBox.ResetText();
            donGiaTextBox.ResetText();
         

        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            else return false;
        }
        bool kiemtra_chuoi()
        {
            if (kiemtra(maThuocTextBox.Text) || kiemtra(tenThuocTextBox.Text) || kiemtra(nhaSanXuatTextBox.Text) || kiemtra(donViTinhTextBox.Text) || kiemtra(donGiaTextBox.Text) || kiemtra(tonKhoTextBox.Text)) return false;
            return true;
        }

        private void CNTTmathang_Load(object sender, EventArgs e)
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
                var qr = db.Thuocs.Where(c => c.MaThuoc == maThuocTextBox.Text);
                var course = qr.SingleOrDefault();
                if (course == null)
                {
                    if (kiemtra_chuoi())
                    {
                        Thuoc t = new Thuoc();
                        t.MaThuoc = maThuocTextBox.Text;
                        t.TenThuoc = tenThuocTextBox.Text;
                        t.NhaSanXuat = nhaSanXuatTextBox.Text;
                        t.DonViTinh = donViTinhTextBox.Text;
                        t.TonKho = int.Parse(tonKhoTextBox.Text);
                        t.DonGia = int.Parse(donGiaTextBox.Text);
                      

                        t.Anh = ConverFiletobyte(pictureBox1.ImageLocation);
                        db.Thuocs.Add(t);
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
                    MessageBox.Show("Mã thuốc này đã tồn tại!", "Thông báo");
                    maThuocTextBox.ResetText();
                }
            }
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            op.Multiselect = false;
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = op.FileName;

            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Sửa")
            {
                bt_sua.Text = "Lưu";
                maThuocTextBox.Enabled = false;
                vohieuhoa(true);
                bt_them.Enabled = false;
                bt_xoa.Enabled = false;
            }
            else
            {
                if (kiemtra_chuoi())
                {
                    Thuoc sv = new Thuoc();
                    var qr1 = db.Thuocs.Where(c => c.MaThuoc == maThuocTextBox.Text);
                    sv = qr1.FirstOrDefault();
                    sv.TenThuoc = tenThuocTextBox.Text;
                    sv.DonViTinh = donViTinhTextBox.Text;
                    sv.DonGia = int.Parse(donGiaTextBox.Text);
                    sv.TonKho = int.Parse(tonKhoTextBox.Text);
                    sv.Anh = ImageToByte(pictureBox1.Image);
                    db.SaveChanges();
                    maThuocTextBox.Enabled = true;
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var qr2 = db.Thuocs.Where(c => c.MaThuoc == maThuocTextBox.Text);
                db.Thuocs.Remove(qr2.FirstOrDefault());
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
            }
            load_dulieu();
        }

        private void thuocDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (thuocDataGridView.SelectedRows.Count > 0)
            {
                string ma = thuocDataGridView.CurrentRow.Cells[0].Value.ToString();
                var qr1 = db.Thuocs.Where(x => x.MaThuoc.Equals(ma));
                Thuoc qr3 = new Thuoc();
                qr3 = qr1.FirstOrDefault();
                maThuocTextBox.Text = qr3.MaThuoc;
                tenThuocTextBox.Text = qr3.TenThuoc;
                donViTinhTextBox.Text = qr3.DonViTinh;
                donGiaTextBox.Text = qr3.DonGia.ToString();
                nhaSanXuatTextBox.Text = qr3.NhaSanXuat;
                tonKhoTextBox.Text = qr3.TonKho.ToString();

                pictureBox1.Image = ConvertBytetoImage(qr3.Anh);
            }
            

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        public static string mat;
        private void bt_in_Click(object sender, EventArgs e)
        {
            mat = maThuocTextBox.Text;
            Frmrpdanhthuocthuoc f = new Frmrpdanhthuocthuoc();
            f.ShowDialog();
        }

        private void maThuocTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
