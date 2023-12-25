using NganHang.Form_Phụ;
using NganHang.Form_Từng_Tính_Năng;
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
        FormMeNu MeNu;
        FormRewards Rewards;

        
        bool MoRong = true;
        public DangNhap()
        {
            InitializeComponent();
        }

        

        private void slideTu_Tick(object sender, EventArgs e)
        {
            if ( MoRong)
            {
                slideBar.Width -= 50;
                if (slideBar.Width == slideBar.MinimumSize.Width)
                {
                    MoRong = false;
                    slideTu.Stop();
                }
            }
            else
            {
                slideBar.Width += 50;
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

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slideTu.Start();
            Reward reward = new Reward();
            addUserControl( reward);
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            slideTu.Start();
            TienIch tienIch = new TienIch();
            addUserControl(tienIch);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            slideTu.Start();
            Reward reward = new Reward();
            addUserControl(reward);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( MeNu == null )
            {
                MeNu = new FormMeNu();
                if (MeNu.Parent != null)
                {
                    // Nếu có parent form, hủy bỏ liên kết với parent form
                    MeNu.Parent = null;
                }
                MeNu.MdiParent = this;
                MeNu.FormClosed += MeNu_FormClosed;
                MeNu.Dock = DockStyle.Fill;
                MeNu.Show();
            }
        }

        private void MeNu_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeNu = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ( Rewards == null )
            {
                Rewards = new FormRewards();
                if (Rewards.Parent != null)
                {
                    Rewards.Parent = null;
                }   
                Rewards.MdiParent = this;
                Rewards.FormClosed += Rewards_FormClosed;
                Rewards.Dock = DockStyle.Fill;
                Rewards.Show();
            }
        }

        private void Rewards_FormClosed(object sender, FormClosedEventArgs e)
        {
            Rewards = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConnect connect = new FormConnect();
            connect.ShowDialog();
        }
    }
}
