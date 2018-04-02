using System;
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
    public partial class frm_HS : Form
    {
        Form formMenu;

        public frm_HS(Form form)
        {
            InitializeComponent();
            formMenu = form;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();
        }
    }
}
