using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public abstract class Champion
    {
        public Champion(string nome, string classe)
        {
            this.Nome = nome;
            this.Classe = classe;
        }

        public string Nome { get; protected set; }
        public string Classe { get; protected set; }

        public abstract Bitmap GetImage();
    }
}
