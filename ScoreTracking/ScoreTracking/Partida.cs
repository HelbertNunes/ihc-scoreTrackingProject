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
        protected Partida(Vencedor vencedor)
        {            
            this.Ganhador = vencedor;            
        }

        [JsonProperty]
        public Vencedor Ganhador { get; protected set; }
        [JsonProperty]
        public Champion Seu_Heroi { get; protected set; }

        public enum Vencedor
        {
            Aliado,
            Inimigo
        };
    }        
}
