using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            return (rm.GetObject(this.Nome.Contains("'") ? this.Nome.Replace("'","_") : this.Nome )as Bitmap);
        }
    }
}
