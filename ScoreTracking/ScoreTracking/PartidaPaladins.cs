using Newtonsoft.Json;
using System;

namespace ScoreTracking
{
    public class PartidaPaladins : Partida
    {
        public PartidaPaladins(Vencedor vencedor, Champion_Paladins champion, Champion_Paladins[] aliados, Champion_Paladins[] inimigos, int pontosAliado, int pontosInimigo,string mapa, DateTime dateTime) 
            : base(vencedor, dateTime)
        {
            SeuHeroi = champion;
            this.pontosAliado = pontosAliado;
            this.pontosInimigo = pontosInimigo;
            Time_Aliado = aliados;
            Time_Inimigo = inimigos;
            Mapa = mapa;
        }

        [JsonProperty]
        public string Mapa { get; private set; }        
        [JsonProperty]
        public int pontosAliado { get; private set; }
        [JsonProperty]
        public int pontosInimigo { get; private set; }
        [JsonProperty]
        public Champion_Paladins[] Time_Aliado { get; private set; }
        [JsonProperty]
        public Champion_Paladins[] Time_Inimigo { get; private set; }

        public void Altera(Vencedor vencedor, Champion_Paladins champion, Champion_Paladins[] aliados, Champion_Paladins[] inimigos, int pontosAliado, int pontosInimigo, string mapa)
        {
            Ganhador = vencedor;
            SeuHeroi = champion;
            Time_Aliado = aliados;
            Time_Inimigo = inimigos;
            this.pontosAliado = pontosAliado;
            this.pontosInimigo = pontosInimigo;
            Mapa = mapa;
        }
    }
}
