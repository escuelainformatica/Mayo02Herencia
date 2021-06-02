using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Clase : Clase ( Heredar)
// Clase : Interface (implementar)


namespace Mayo02Herencia.herencia2
{
    class GenerarAlerta : ContenedorV2
    {
        public string Mostrar(string mensaje, string tipoAlerta)
        {
            var r="";
            Mensaje=" Hay un "+tipoAlerta+": "+mensaje+" ";
            Alto=5;
            r=Contenedor();
            return r;
        }

    }
}
