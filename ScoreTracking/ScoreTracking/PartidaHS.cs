using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public class PartidaHS : Partida
    {
        public PartidaHS(Vencedor vencedor, Champion_HS champion, Champion_HS champion_inimigo, DateTime dateTime) 
            : base(vencedor, dateTime)
        {
            this.SeuHeroi = champion;
            this.HeroiInimigo = champion_inimigo;
        }

        public void Altera(Vencedor vencedor, Champion_HS champion, Champion_HS champion_inimigo)
        {
            this.Ganhador = vencedor;
            this.SeuHeroi = champion;
            this.HeroiInimigo = champion_inimigo;
        }

        [JsonProperty]
        public Champion_HS HeroiInimigo { get; private set; }

        private string deckOponente { get; set; }        
        private string deckUsuario { get; set; }
    }
}
