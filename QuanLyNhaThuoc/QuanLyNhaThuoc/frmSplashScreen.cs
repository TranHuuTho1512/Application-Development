using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelChay.Width += 2;

            if (panelChay.Width >= 700)
            {
                timer1.Stop();
                frmDangNhap F = new frmDangNhap();
                F.Show();
                this.Hide();
            }

        }
    }
}
