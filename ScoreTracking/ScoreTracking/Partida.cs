using Newtonsoft.Json;
using System;

namespace ScoreTracking
{
    public class Partida
    {
        protected Partida(Vencedor vencedor, DateTime dateTime)
        {            
            Ganhador = vencedor;
            DataHora = dateTime;
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
