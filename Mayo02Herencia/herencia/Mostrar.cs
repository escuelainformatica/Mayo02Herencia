using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.herencia
{
    class Mostrar : Contenedor
    {
        public static string Despliegue(string texto)
        {
            var resultado="";
            resultado=Bordes(texto.ToUpper());
            return resultado;
        }
    }
}
