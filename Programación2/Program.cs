using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            Console.WriteLine(Singleton.Instancia.mensaje);
            Singleton.Instancia.mensaje = "Hola Lunes";
            Console.WriteLine(Singleton.Instancia.mensaje);

            //Prototype
            Prototype Animal = new Prototype() { Nombre="Obeja", Patas=4};
            Prototype AnimalClonado = Animal.Clone() as Prototype;
            AnimalClonado.Patas = 5;

            Console.WriteLine(Animal.Patas);

            //Strategy
            EstrategiaDelChicoContexto Galan = new EstrategiaDelChicoContexto();
            Galan.Conquistar(EstrategiaDelChicoContexto.comportamiento.HacerGestos);
            Galan.Conquistar(EstrategiaDelChicoContexto.comportamiento.InvitarBebidas);
            Galan.Conquistar(EstrategiaDelChicoContexto.comportamiento.HacerCaraDeEnamorado);


        }
    }
}
