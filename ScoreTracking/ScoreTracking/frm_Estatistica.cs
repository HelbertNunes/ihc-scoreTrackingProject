using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
    public partial class frm_Estatistica : Form
    {
        private List<Champion> champions = new List<Champion>();
        private List<Partida> partidas = new List<Partida>();
        private const string JSON_HS_PATH = @".\partidas_hs.json";
        private const string JSON_PALADINS_PATH = @".\partidas_paladins.json";
        Form sender;

        public frm_Estatistica(Form sender)
        {
            InitializeComponent();
            this.sender = sender;
            PreencheComboBoxes();
        }

        private void PreencheComboBoxes()
        {                       
            if (sender.Name.Contains("HS"))
            {
                LeArquivo(Properties.Resources.classes);
                Champion_HS[] championsTemp = new Champion_HS[champions.Count];
                champions.OrderBy(x => x.Nome).ToList().CopyTo(championsTemp);

                cb_por_heroi.DataSource = championsTemp;
                cb_por_heroi.DisplayMember = "Nome";                
            }
            else
            {
                LeArquivo(Properties.Resources.champions_paladins);
                Champion_Paladins[] championsTemp = new Champion_Paladins[champions.Count];
                champions.CopyTo(championsTemp);
                cb_por_heroi.DataSource = championsTemp;
                cb_por_heroi.DisplayMember = "Nome";
            }

            CalculaEstatistica();
        }

        private void CalculaEstatistica()
        {
            int numPartidasGeral, numPartidasHeroi;
            List<PartidaHS> partidasHS;
            List<PartidaPaladins> partidasPaladins;
            JsonConverter[] converters = { new ChampionConverter() };

            if (sender.Name.Contains("HS"))
            {
                partidasHS = JsonConvert.DeserializeObject<List<PartidaHS>>(File.ReadAllText(JSON_HS_PATH), new JsonSerializerSettings() { Converters = converters });

                if (partidasHS is null || partidasHS[0].SeuHeroi is null) partidas = new List<Partida>();
                else
                {
                    foreach(var partida in partidasHS)
                    {
                        partidas.Add(partida);
                    }
                }
            }
            else
            {
                partidasPaladins = JsonConvert.DeserializeObject<List<PartidaPaladins>>(File.ReadAllText(JSON_PALADINS_PATH), new JsonSerializerSettings() { Converters = converters });

                if (partidasPaladins is null || partidasPaladins[0].SeuHeroi is null) partidas = new List<Partida>();
                else
                {
                    foreach (var partida in partidasPaladins)
                    {
                        partidas.Add(partida);
                    }
                }
            }                               

            Champion champion = (Champion)cb_por_heroi.SelectedItem;

            numPartidasGeral = partidas.Count;
            numPartidasHeroi = partidas.Count(x => x.SeuHeroi.Nome.Contains(champion.Nome));

            double percent_Heroi = 0, percent_Geral = 0;

            if (numPartidasHeroi != 0) percent_Heroi = (partidas.Count(x => x.SeuHeroi.Nome.Contains(champion.Nome) && x.Ganhador == Partida.Vencedor.Aliado) / Convert.ToDouble(numPartidasHeroi)) * 100;

            if (numPartidasGeral != 0) percent_Geral = (partidas.Count(x => x.Ganhador == Partida.Vencedor.Aliado) / Convert.ToDouble(numPartidasGeral)) * 100;

            lb_num_partidas_geral.Text = numPartidasGeral.ToString();
            lb_num_partidas_heroi.Text = numPartidasHeroi.ToString();

            lb_val_win_rate_geral.Text = string.Format($"{percent_Geral} %");
            lb_val_win_rate_heroi.Text = string.Format($"{percent_Heroi} %");
        }

        private void LeArquivo(string file)
        {
            string[] infos;

            foreach (var line in file.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.Contains(':'))
                {
                    infos = line.Split(':');
                    if (sender.Name.Contains("HS")) champions.Add(new Champion_HS(infos[0], infos[1]));
                    else champions.Add(new Champion_Paladins(infos[0], infos[1]));
                }
            }
        }

        private void cb_por_heroi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Champion champion = (Champion)cb_por_heroi.SelectedItem;
            int numPartidasHeroi = partidas.Count(x => x.SeuHeroi.Nome.Contains(champion.Nome));
            double percent_Heroi = 0;

            if (numPartidasHeroi != 0) percent_Heroi = (partidas.Count(x => x.SeuHeroi.Nome.Contains(champion.Nome) && x.Ganhador == Partida.Vencedor.Aliado) / Convert.ToDouble(numPartidasHeroi)) * 100;

            lb_num_partidas_heroi.Text = numPartidasHeroi.ToString();
            lb_val_win_rate_heroi.Text = string.Format($"{percent_Heroi} %");
        }

        private void limparEstatisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.sender.Name.Contains("HS"))
                File.WriteAllText(JSON_HS_PATH, string.Empty);
            else
                File.WriteAllText(JSON_PALADINS_PATH, string.Empty);

            Form notification = new frm_NotificationOK("Estatísticas foram reiniciadas");
            notification.Show();
            CalculaEstatistica();
        }
    }
}
