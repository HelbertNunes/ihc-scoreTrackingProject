using System;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_NotificationDel : Form
    {
        public frm_NotificationDel()
        {
            InitializeComponent();
            timer_close.Start();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
