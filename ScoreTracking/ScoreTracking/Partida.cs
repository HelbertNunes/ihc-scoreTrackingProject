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
        protected Partida(Vencedor vencedor, DateTime dateTime)
        {            
            this.Ganhador = vencedor;
            this.DataHora = dateTime;
        }

        [JsonProperty]
        public Vencedor Ganhador { get; protected set; }
        [JsonProperty]
        public Champion SeuHeroi { get; protected set; }
        [JsonProperty]
        public DateTime DataHora { get; protected set; }
        public enum Vencedor
        {
            Aliado,
            Inimigo
        };      
    }        
}
