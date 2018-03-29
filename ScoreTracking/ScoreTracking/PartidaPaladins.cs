using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    class PartidaPaladins : Partida
    {
        private string mapa { get; set; }
        private int baixas { get; set; }
        private string mortes { get; set; }
        private long cura { get; set; }
        private int assistencias { get; set; }
        private int dano { get; set; }
    }
}
