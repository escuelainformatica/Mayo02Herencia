using Mayo02Herencia.veterinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia
{

    // clinica veterinaria

    // Perro implementa IAnimal (Perro debe seguir el contrato IAnimal)

    class Perro : IAnimal
    {
        public string Nombre {set; get;}
        public string Raza {set; get;}
        public int Peso {set; get;}
        public bool Muerde {set; get;}

        public void FuncionEjemplo()
        {

        }
    }
}
