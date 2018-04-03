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
        private List<Champion_HS> champions = new List<Champion_HS>();
        private Control.ControlCollection form_Controls;
        Form formMenu;

        public frm_HS(Form form)
        {
            InitializeComponent();
            PreencheComboBoxes();
            formMenu = form;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Hide();
            formMenu.Show();
        }

        private void PreencheComboBoxes()
        {
            LeArquivo(Properties.Resources.classes);

            form_Controls = this.Controls;
            List<ComboBox> comboBoxes = form_Controls.OfType<ComboBox>().ToList().Where(x => !x.Name.Contains("Vencedor")).ToList();
            List<PictureBox> pictureBoxes = form_Controls.OfType<PictureBox>().ToList();            

            for (int i = 0; i < comboBoxes.Count; i++)
            {
                Champion_HS[] championsTemp = new Champion_HS[champions.Count];
                champions.OrderBy(x => x.Nome).ToList().CopyTo(championsTemp);
                
                comboBoxes[i].DataSource = championsTemp;
                comboBoxes[i].DisplayMember = "Nome";
                comboBoxes[i].SelectedIndexChanged += new EventHandler(AtualizaDados);


                PictureBox pictureBox = pictureBoxes.Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3,4))).ToArray()[0];
                Label label = form_Controls.OfType<Label>().ToList().Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3,4))).ToList()[0];
                pictureBox.Image = champions[0].GetImage();
                label.Text = champions[0].Classe;                                         
            }
        }

        private void AtualizaDados(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Champion champion = (Champion_HS)comboBox.SelectedItem;

            PictureBox pictureBox = form_Controls.OfType<PictureBox>().ToList().Where(x => x.Name.Contains(comboBox.Name.Substring(3,4))).ToList()[0];
            Label label = form_Controls.OfType<Label>().ToList().Where(x => x.Name.Contains(comboBox.Name.Substring(3,4))).ToList()[0];

            label.Text = champion.Classe;

            pictureBox.Image = champion.GetImage();
        }

        private void LeArquivo(string file)
        {
            string[] infos;

            foreach (var line in file.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.Contains(':'))
                {
                    infos = line.Split(':');
                    champions.Add(new Champion_HS(infos[0], infos[1]));
                }                
            }
        }

        private void frm_HS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            formMenu.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
