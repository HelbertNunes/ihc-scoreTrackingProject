using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public class PartidaPaladins : Partida
    {
        private string Mapa { get; set; }       
        private int pontosAliado { get; set; }
        private int pontosInimigo { get; set; }
    }
}
