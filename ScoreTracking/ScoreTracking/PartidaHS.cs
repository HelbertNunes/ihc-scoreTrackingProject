using Newtonsoft.Json;
using System;

namespace ScoreTracking
{
    public class PartidaHS : Partida
    {
        public PartidaHS(Vencedor vencedor, Champion_HS champion, Champion_HS champion_inimigo, DateTime dateTime) 
            : base(vencedor, dateTime)
        {
            SeuHeroi = champion;
            HeroiInimigo = champion_inimigo;
        }

        public void Altera(Vencedor vencedor, Champion_HS champion, Champion_HS champion_inimigo)
        {
            Ganhador = vencedor;
            SeuHeroi = champion;
            HeroiInimigo = champion_inimigo;
        }

        [JsonProperty]
        public Champion_HS HeroiInimigo { get; private set; }

        private string deckOponente { get; set; }        
        private string deckUsuario { get; set; }
    }
}
