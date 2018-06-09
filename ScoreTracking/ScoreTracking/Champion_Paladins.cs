using System.Drawing;
using System.Resources;

namespace ScoreTracking
{
    public class Champion_Paladins : Champion
    {        
        public Champion_Paladins(string nome, string classe) 
            : base(nome, classe, "Paladins")
        {        
        }

        
        public override Bitmap GetImage()
        {
            ResourceManager rm = Properties.Resources.ResourceManager;            
            return (rm.GetObject(Nome.Contains("'") ? Nome.Replace("'","_") :Nome )as Bitmap);
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
