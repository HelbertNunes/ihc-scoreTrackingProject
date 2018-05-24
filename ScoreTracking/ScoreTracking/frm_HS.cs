using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls.Primitives;
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
        private const string JSON_PATH = @".\partidas_hs.json";
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
            if (!File.Exists(JSON_PATH))
            {
                FileStream file = File.Create(JSON_PATH);
                file.Close();
            }

            LeArquivo(Properties.Resources.classes);
            
            form_Controls = this.Controls;
            List<ComboBox> comboBoxes = form_Controls.OfType<ComboBox>().ToList().Where(x => !x.Name.Contains("vencedor")).ToList();
            List<PictureBox> pictureBoxes = form_Controls.OfType<PictureBox>().ToList();            

            for (int i = 0; i < comboBoxes.Count; i++)
            {
                Champion_HS[] championsTemp = new Champion_HS[champions.Count];
                champions.OrderBy(x => x.Nome).ToList().CopyTo(championsTemp);
                
                comboBoxes[i].DataSource = championsTemp;
                comboBoxes[i].DisplayMember = "Nome";
                comboBoxes[i].SelectedIndexChanged += new EventHandler(AtualizaDados);


                PictureBox pictureBox = pictureBoxes.Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3,4))).ToArray()[0];                
                pictureBox.Image = championsTemp[0].GetImage();                                                   
            }

            ComboBox comboVencedor = form_Controls.OfType<ComboBox>().ToList().Where(x => x.Name.Contains("vencedor")).ToList()[0];
            comboVencedor.SelectedIndex = 0;
        }

        private void AtualizaDados(object sender, EventArgs e)
        {            
            ComboBox comboBox = (ComboBox)sender;
            Champion champion = (Champion_HS)comboBox.SelectedItem;

            PictureBox pictureBox = form_Controls.OfType<PictureBox>().ToList().Where(x => x.Name.Contains(comboBox.Name.Substring(3,4))).ToList()[0];         

            pictureBox.Image = champion.GetImage();
        }

        private void LeArquivo(string file)
        {
            string[] infos;

            foreach (var line in file.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
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
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private List<PartidaHS> LeJSON()
        {
            JsonConverter[] converters = { new ChampionConverter() };
            List<PartidaHS> partidas = JsonConvert.DeserializeObject<List<PartidaHS>>(File.ReadAllText(JSON_PATH), new JsonSerializerSettings() { Converters = converters });

            if (partidas is null || partidas[0].Seu_Heroi is null) partidas = new List<PartidaHS>();

            return partidas;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Partida.Vencedor vencedor = (cb_vencedor.SelectedIndex == 0) ? Partida.Vencedor.Aliado : Partida.Vencedor.Inimigo;
            Champion_HS seu_heroi = (Champion_HS)cb_ally_hero.SelectedItem;

            PartidaHS partida = new PartidaHS(vencedor, seu_heroi, DateTime.Now);

            List<PartidaHS> partidas = LeJSON();

            partidas.Add(partida);

            File.WriteAllText(JSON_PATH, JsonConvert.SerializeObject(partidas));

            Form alert = new frm_Notification("Salvo com sucesso");
            alert.Show();
        }

        private void estatísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEstatistica = new frm_Estatistica(this);
            formEstatistica.ShowDialog();
        }
    }
}
