using System.Drawing;
using System.Resources;

namespace ScoreTracking
{
    public class Champion_HS : Champion
    {
        public Champion_HS(string nome, string classe) 
            : base(nome, classe, "HS")
        {            
        }

        
        public override Bitmap GetImage()
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            return (rm.GetObject(Classe) as Bitmap);
        }

        public override string ToString()
        {
            return Classe;
        }
    }
}
