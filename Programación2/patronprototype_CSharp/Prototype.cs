using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación2
{
    //Hago referencia a un animal
   public class Prototype:ICloneable
    {
        public string Nombre { get; set; }
        public int  Patas { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
