using System;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_NotificationOK : Form
    {
        public frm_NotificationOK(string mensagem)
        {
            InitializeComponent();            
            lb_message.Text = mensagem;
            timer_close.Start();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
