using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTracking
{
    public partial class frm_Selecao : Form
    {
        Action<PartidaPaladins> retornaPartidaPaladins;
        Action<PartidaHS> retornaPartidaHS;
        Form sender;
        private const string JSON_HS_PATH = @".\partidas_hs.json";
        private const string JSON_PALADINS_PATH = @".\partidas_paladins.json";

        public frm_Selecao(Action<PartidaPaladins> retornaPartida, Form sender)
        {
            InitializeComponent();
            this.retornaPartidaPaladins = retornaPartida;
            this.sender = sender;
            RecuperaPartidas();
        }
        public frm_Selecao(Action<PartidaHS> retornaPartida, Form sender)
        {
            InitializeComponent();
            this.retornaPartidaHS = retornaPartida;
            this.sender = sender;
            RecuperaPartidas();
        }

        public void RecuperaPartidas()
        {
            string file = (sender.Name.Contains("HS")) ? File.ReadAllText(JSON_HS_PATH) : File.ReadAllText(JSON_PALADINS_PATH);

            List<PartidaHS> partidaHS;
            List<PartidaPaladins> partidaPaladins;

            JsonConverter[] converters = { new ChampionConverter() };

            if (sender.Name.Contains("HS"))
            {
                partidaHS = JsonConvert.DeserializeObject<List<PartidaHS>>(file, new JsonSerializerSettings() { Converters = converters });
                dataGridPartida.DataSource = partidaHS;
            }
            else
            {
                partidaPaladins = JsonConvert.DeserializeObject<List<PartidaPaladins>>(file, new JsonSerializerSettings() { Converters = converters });
                dataGridPartida.DataSource = partidaPaladins;
            }             
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            if (this.sender.Name.Contains("HS"))
            {
                PartidaHS partida = (PartidaHS)dataGridPartida.SelectedRows[0].DataBoundItem;
                retornaPartidaHS(partida);
            }
            else
            {
                PartidaPaladins partida = (PartidaPaladins)dataGridPartida.SelectedRows[0].DataBoundItem;
                retornaPartidaPaladins(partida);
            }

            Close();
        }
    }
}
