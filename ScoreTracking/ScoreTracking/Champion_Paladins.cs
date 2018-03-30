using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTracking
{
    public class Champion_Paladins : Champion
    {
        private const string IMAGE_PATH = @".\Images\Paladins\";

        public Champion_Paladins(string nome, string classe) 
            : base(nome, classe)
        {
        }

        public override string GetImage()
        {
            return IMAGE_PATH + this.Nome + ".png";
        }
    }
}
