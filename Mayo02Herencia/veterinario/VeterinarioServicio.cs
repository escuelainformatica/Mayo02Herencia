using Mayo02Herencia.veterinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia
{
    class VeterinarioServicio
    {
        public static int CostoConsulta(IAnimal animal)
        {
            var r=0;
            r=animal.Peso*100;
            return r;
        }

    }
}
