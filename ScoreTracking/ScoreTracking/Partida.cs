using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public class Partida
    {
        protected int Ganhador { get; set; }
        protected TimeSpan Duracao { get; set; }
        protected bool ModoDeJogo { get; set; }        
        
        protected enum ModoJogo
        {
            Normal,
            Ranqueado
        };

        protected enum Vencedor
        {
            Aliado,
            Inimigo
        };
    }        
}
