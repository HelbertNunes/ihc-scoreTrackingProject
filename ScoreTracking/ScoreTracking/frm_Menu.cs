using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Paladins_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => {
                frm_Paladins frm_Paladins = new frm_Paladins();
                frm_Paladins.Show();
                Application.Run(frm_Paladins);
            });

            thread.Start();
            this.Close();
        }
    }
}
