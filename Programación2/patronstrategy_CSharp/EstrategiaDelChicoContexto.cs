using System;
using System.Collections.Generic;
using System.Text;

namespace Programación2
{
    class EstrategiaDelChicoContexto
    {
        private Chico Galan;
        public enum comportamiento
        {
            HacerGestos, InvitarBebidas, HacerCaraDeEnamorado
        }
        public EstrategiaDelChicoContexto()
        {
            this.Galan = new EstrategiaGestos();
        }
        public void Conquistar(comportamiento opcion)
        {
            switch (opcion)
            {
                case comportamiento.HacerGestos:
                    {
                        this.Galan = new EstrategiaGestos();
                    }
                    break;
                case comportamiento.InvitarBebidas:
                    {
                        this.Galan = new Estrategia_Invitarbebida();
                    }
                    break;
                case comportamiento.HacerCaraDeEnamorado:
                    {
                        this.Galan = new EstrategiaHacerCaraDeEnamorado();
                    }
                    break;
            }
            this.Galan.Conquistar();
        }
    }
}
