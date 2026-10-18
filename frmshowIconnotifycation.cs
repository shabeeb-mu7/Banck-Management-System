using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBanckDeskTop2
{
    public partial class frmshowIconnotifycation : Form
    {
        public  string sTitle = "Title";
        public  string Description = "Description";
        public frmshowIconnotifycation()
        {
            InitializeComponent();
            
        }

        private void _SetNotifyPosition()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width - 10;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height - 10;

            this.Location = new Point(x, y);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmshowIconnotifycation_Load(object sender, EventArgs e)
        {
            lbTitle.Text = sTitle;
            lbText.Text = Description;
            this.Opacity = 0;
            _SetNotifyPosition();
            timerFadeIn.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timerFadeOut.Start();
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0.1)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timerFadeOut.Stop();
                this.Close();
            }
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                this.Opacity = 1;
                timerFadeIn.Stop();
                timer1.Start();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timerFadeIn.Stop();
            timerFadeOut.Stop();
            timer1.Stop();

            timerFadeIn.Dispose();
            timerFadeOut.Dispose();
            timer1.Dispose();

            base.OnFormClosed(e);
        }
    }
}
