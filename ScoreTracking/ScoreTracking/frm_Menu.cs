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
        frm_Paladins frm_Paladins;
        frm_HS frm_HS;
        public frm_Menu()
        {
            InitializeComponent();
            frm_HS = new frm_HS(this);
            frm_Paladins = new frm_Paladins(this);
        }

        private void btn_Paladins_Click(object sender, EventArgs e)
        {
            frm_Paladins.Show();
            Hide();
        }
        private void btn_HS_Click(object sender, EventArgs e)
        {
            frm_HS.Show();
            Hide();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
