using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_HS : Form
    {
        private List<Champion_HS> champions = new List<Champion_HS>();
        private Control.ControlCollection form_Controls;
        private const string JSON_PATH = @".\partidas_hs.json";
        private PartidaHS partida;
        private List<PartidaHS> partidas;
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

            deleteStripButton.Visible = false;

            form_Controls = this.Controls;
            List<ComboBox> comboBoxes = form_Controls.OfType<ComboBox>().ToList().Where(x => !x.Name.Contains("vencedor")).ToList();
            List<PictureBox> pictureBoxes = form_Controls.OfType<PictureBox>().ToList();

            champions = champions.OrderBy(x => x.Nome).ToList<Champion_HS>();

            for (int i = 0; i < comboBoxes.Count; i++)
            {
                Champion_HS[] championsTemp = new Champion_HS[champions.Count];
                champions.CopyTo(championsTemp);

                comboBoxes[i].DataSource = championsTemp;
                comboBoxes[i].DisplayMember = "Nome";
                comboBoxes[i].SelectedIndexChanged += new EventHandler(AtualizaDados);


                PictureBox pictureBox = pictureBoxes.Where(x => x.Name.Contains(comboBoxes[i].Name.Substring(3,4))).ToArray()[0];                
                pictureBox.Image = championsTemp[0].GetImage();                                                   
            }

            ComboBox comboVencedor = form_Controls.OfType<ComboBox>().ToList().Where(x => x.Name.Contains("vencedor")).ToList()[0];
            comboVencedor.SelectedIndex = 0;
            partida = null;
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

            foreach (var line in file.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries)) 
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
            partidas = JsonConvert.DeserializeObject<List<PartidaHS>>(File.ReadAllText(JSON_PATH), new JsonSerializerSettings() { Converters = converters });

            if (partidas is null || partidas[0].SeuHeroi is null) partidas = new List<PartidaHS>();

            return partidas;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Partida.Vencedor vencedor = (cb_vencedor.SelectedIndex == 0) ? Partida.Vencedor.Aliado : Partida.Vencedor.Inimigo;
            Champion_HS seu_heroi = (Champion_HS)cb_ally_hero.SelectedItem;
            Champion_HS heroi_inimigo = (Champion_HS)cb_enemy_hero.SelectedItem;

            List<PartidaHS> partidas = LeJSON();

            if (this.partida == null)
                this.partida = new PartidaHS(vencedor, seu_heroi, heroi_inimigo, DateTime.Now);
            else
            {
                partidas.Remove(partida);
                this.partida.Altera(vencedor, seu_heroi, heroi_inimigo);
            }

            partidas.Add(partida);

            File.WriteAllText(JSON_PATH, JsonConvert.SerializeObject(partidas));

            deleteStripButton.Visible = true;

            Form alert = new frm_NotificationOK("Salvo com sucesso");
            alert.Show();
        }

        private void estatísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEstatistica = new frm_Estatistica(this);
            formEstatistica.ShowDialog();
        }

        public void PreenchePartida(PartidaHS partida)
        {
            this.partida = partida;
            deleteStripButton.Visible = true;

            List<ComboBox> comboBoxes_ally = form_Controls.OfType<ComboBox>().ToList().Where(x => x.Name.Contains("ally")).ToList();
            List<ComboBox> comboBoxes_enemy = form_Controls.OfType<ComboBox>().ToList().Where(x => x.Name.Contains("enemy")).ToList();

            cb_vencedor.SelectedIndex = (partida.Ganhador == Partida.Vencedor.Aliado) ? 0 : 1;
            cb_ally_hero.SelectedIndex = champions.FindIndex(x => x.Nome == partida.SeuHeroi.Nome);
            cb_enemy_hero.SelectedIndex = champions.FindIndex(x => x.Nome == partida.HeroiInimigo.Nome);
        }

        private void vizualizarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSelecao = new frm_Selecao(PreenchePartida, this);
            frmSelecao.ShowDialog();
        }

        private void deletaStripButton_Click(object sender, EventArgs e)
        {
            partidas.RemoveAt(partidas.FindIndex(x => x.DataHora == partida.DataHora));
            File.WriteAllText(JSON_PATH, JsonConvert.SerializeObject(partidas));
            if (partidas.Count == 0)
                File.WriteAllText(JSON_PATH, string.Empty);
            else
                File.WriteAllText(JSON_PATH, JsonConvert.SerializeObject(partidas));

            PreencheComboBoxes();
            frm_NotificationDel frmDel = new frm_NotificationDel();
            frmDel.ShowDialog();
        }
    }
}
