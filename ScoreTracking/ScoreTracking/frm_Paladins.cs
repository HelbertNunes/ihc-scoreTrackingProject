using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_Paladins : Form
    {        
        private List<Champion_Paladins> champions = new List<Champion_Paladins>();
        private List<string> mapas = new List<string>();
        private Control.ControlCollection form_Controls;

        public frm_Paladins()
        {
            InitializeComponent();
            PreencheComboBoxes();
        }

        private void PreencheComboBoxes()
        {            
            LeArquivo(Properties.Resources.champions_paladins);

            form_Controls = this.Controls;
            List<ComboBox> comboBoxes = form_Controls.OfType<ComboBox>().ToList().Where(x => !x.Name.Contains("mapa")).ToList();
            List<PictureBox> pictureBoxes = form_Controls.OfType<PictureBox>().ToList();
            
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                Champion_Paladins[] championsTemp = new Champion_Paladins[champions.Count];
                champions.CopyTo(championsTemp);
                comboBoxes[i].DataSource = championsTemp;                
                comboBoxes[i].DisplayMember = "Nome";
                comboBoxes[i].SelectedIndexChanged += new EventHandler(AtualizaDados);

                PictureBox pictureBox = pictureBoxes.Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3))).ToArray()[0];
                pictureBox.Image = champions[0].GetImage();

                Label label = form_Controls.OfType<Label>().ToList().Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3))).ToList()[0];
                label.Text = champions[0].Classe;
            }
        }

        private void AtualizaDados(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Champion champion = (Champion_Paladins)comboBox.SelectedItem;

            PictureBox pictureBox = form_Controls.OfType<PictureBox>().ToList().Where(x => x.Name.Contains(comboBox.Name.Substring(3))).ToList()[0];
            Label label = form_Controls.OfType<Label>().ToList().Where(x => x.Name.Contains(comboBox.Name.Substring(3))).ToList()[0];

            label.Text = champion.Classe;

            pictureBox.Image = champion.GetImage();
        }

        private void LeArquivo(string file)
        {
            string[] infos;

            foreach(var line in file.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.Contains(':'))
                {
                    infos = line.Split(':');
                    champions.Add(new Champion_Paladins(infos[0], infos[1]));
                }
                else
                {
                    mapas.Add(line);
                }
            }            
        }
    }
}
