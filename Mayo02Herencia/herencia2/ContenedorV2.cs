using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.herencia2
{
    class ContenedorV2
    {
        public int Largo { set; get; }
        public int Alto { set; get; }
        public string Mensaje { set; get; }

        public string Contenedor()
        {
            int medioAlto=Alto/2;
            Largo=Mensaje.Length;
            var r = "";
            r = "-" + new string('-', Largo) + "-\n";
            for(int i=0;i<medioAlto;i++) {
                r = r + "|" + new string(' ', Largo) + "|\n";
            }
            r = r + "|" + Mensaje + "|\n";
            for(int i=0;i<medioAlto;i++) {
                r = r + "|" + new string(' ', Largo) + "|\n";
            }
            r = r + "-" + new string('-', Largo) + "-\n";
            return r;
        }

    }
}
