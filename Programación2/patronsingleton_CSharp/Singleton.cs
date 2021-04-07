using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación2
{
    public class Singleton
    {
        private static Singleton instancia = null;
        public string mensaje = "";

        protected Singleton()
        {
            mensaje = "Hola Mundo";
        }
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Singleton();

                return instancia;
            }
        }
    }
}
