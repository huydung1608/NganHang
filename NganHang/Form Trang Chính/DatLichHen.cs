using NganHang.Form_Phụ_của_Trang_Chính;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang.Form_Trang_Chính
{
    public partial class DatLichHen : Form
    {
        ChiNhanhCuaDatLichHen lichHen;
        public DatLichHen()
        {
            InitializeComponent();
        }

        private void DatLichHen_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ChiNhanhCuaDatLichHen chiNhanhCuaDatLich = new ChiNhanhCuaDatLichHen();
            chiNhanhCuaDatLich.ShowDialog(this);
        }

        
    }
}
