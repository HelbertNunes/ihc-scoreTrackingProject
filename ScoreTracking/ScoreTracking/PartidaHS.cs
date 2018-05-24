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
        public PartidaHS(Vencedor vencedor, Champion_HS champion, DateTime dateTime) 
            : base(vencedor, dateTime)
        {
            this.Seu_Heroi = champion;
        }
        
        private string deckOponente { get; set; }        
        private string deckUsuario { get; set; }
    }
}
