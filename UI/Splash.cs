using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.UI;
using Blood_Bank.UI_Helper;

namespace Blood_Bank
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.Paint += (s, e) => GradientBackgroundHelper.DrawDefaultGradient(s, e);
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

            MyProgress.BackColor = Color.Transparent;
            MyProgress.ForeColor = Color.White; 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 2;
            MyProgress.Value = startpos;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
    }
}
