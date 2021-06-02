using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.herencia
{
    class Contenedor
    {
        public static string Bordes(string contenido)
        {
            string texto = "";
            // \n = salto de linea
            // \t = tabulacion
            string ruta=@"c:\carpeta\ncarpeta";

            texto = "-------------------------\n";
            texto = texto + "|      " + contenido + "       |\n";
            texto = texto + "-------------------------\n";
            return texto;
        }
    }
}
