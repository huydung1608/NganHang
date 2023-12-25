using NganHang.Form_Trang_Chính;
using NganHang.FROM_Trang_Chính;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();



        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void picDatLichHen_Click(object sender, EventArgs e)
        {
            DatLichHen datLichHen = new DatLichHen();
            datLichHen.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            TrangDangNhap trangDangNhap = new TrangDangNhap();
            trangDangNhap.Show();
        }
    }
}
