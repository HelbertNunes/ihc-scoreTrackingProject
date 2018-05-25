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
    public partial class frmSelecao : Form
    {
        Action<Partida> retornaPartida;
        Form sender;
        private const string JSON_HS_PATH = @".\partidas_hs.json";
        private const string JSON_PALADINS_PATH = @".\partidas_paladins.json";

        public frmSelecao(Action<Partida> retornaPartida, Form sender)
        {
            InitializeComponent();
            this.retornaPartida = retornaPartida;
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
      
    }
}
