using Newtonsoft.Json;
using System.Drawing;

namespace ScoreTracking
{

    public abstract class Champion
    {
        protected Champion(string nome, string classe, string jogo)
        {
            Jogo = jogo;
            Nome = nome;
            Classe = classe;
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
