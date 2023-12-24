using NganHang.Form_Phụ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang.FROM_Trang_Chính
{
    public partial class DangNhap : Form
    {
        bool MoRong = true;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slideBar_Tick(object sender, EventArgs e)
        {

        }

        

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void slideTu_Tick(object sender, EventArgs e)
        {
            if ( MoRong)
            {
                slideBar.Width -= 10;
                if (slideBar.Width == slideBar.MinimumSize.Width)
                {
                    MoRong = false;
                    slideTu.Stop();
                }
            }
            else
            {
                slideBar.Width += 10;
                if ( slideBar.Width == slideBar.MaximumSize.Width)
                {
                    MoRong = true;
                    slideTu.Stop();
                }
            }
        }
        private void addUserControl( UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            slideBar.Controls.Clear();
            slideBar.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slideTu.Start();
            TienIch tienIch = new TienIch();
            addUserControl(tienIch);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slideTu.Start();
            Reward reward = new Reward();
            addUserControl( reward);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
        }

        private void DangNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
