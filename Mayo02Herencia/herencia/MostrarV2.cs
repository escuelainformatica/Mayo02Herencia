using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.herencia
{
    class MostrarV2 : Contenedor
    {
        public static string MostrarAlert(string texto,string tipoAlerta)
        {
            return Bordes("mensaje: "+"["+tipoAlerta+"] "+ texto);
        }

    }
}
