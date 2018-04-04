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
        public PartidaHS(Vencedor vencedor, Champion heroi) 
            : base(vencedor, heroi)
        {
        }

        
        private string deckOponente { get; set; }        
        private string deckUsuario { get; set; }
    }
}
