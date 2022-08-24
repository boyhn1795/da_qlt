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
    public partial class Frmrpdanhthuocthuoc : Form
    {
        public Frmrpdanhthuocthuoc()
        {
            InitializeComponent();
        }
        QuanLyThuocEntities db = new QuanLyThuocEntities();
         
        private void Frmrpdanhthuocthuoc_Load(object sender, EventArgs e)
        {
            Danhsachthuoc rp = new Danhsachthuoc();
            rp.SetParameterValue("MaThuoc", Cap_nhat.CNTTmathang.mat);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
