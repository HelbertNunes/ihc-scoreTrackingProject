using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public class Partida
    {
        public Partida(Vencedor vencedor, Champion heroi)
        {
            this.Ganhador = vencedor;
            this.Seu_Heroi = heroi;
        }

        [JsonProperty]
        protected Vencedor Ganhador { get; set; }
        [JsonProperty]
        public Champion Seu_Heroi { get; protected set; }

        public enum Vencedor
        {
            Aliado,
            Inimigo
        };
    }        
}
