using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.veterinario
{
    class Loro : IAnimal
    {
        public string Nombre { get ; set ; }
        public string Raza { get ; set ; }
        public int Peso { get; set ; }
        public bool Exotico {get; set;}

        public void FuncionEjemplo()
        {
            
        }
    }
}
