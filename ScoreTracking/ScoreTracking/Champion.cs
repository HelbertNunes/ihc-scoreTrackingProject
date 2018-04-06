using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    
    public abstract class Champion
    {
        protected Champion(string nome, string classe, string jogo)
        {
            this.Jogo = jogo;
            this.Nome = nome;
            this.Classe = classe;
        }

        [JsonProperty]
        public string Jogo { get; protected set; }
        [JsonProperty]
        public string Nome { get; protected set; }
        [JsonProperty]
        public string Classe { get; protected set; }

        public abstract Bitmap GetImage();
    }
}
