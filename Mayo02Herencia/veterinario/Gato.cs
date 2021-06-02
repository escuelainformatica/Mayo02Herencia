using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// herencias de las clases nacio hace mas de 30 años.
// 640kb


namespace Mayo02Herencia.veterinario
{
    class Gato : IAnimal
    {
        public string Nombre {set; get;}
        public string Raza {set; get;}
        public int Peso {set; get;}

        public void FuncionEjemplo()
        {
            
        }
        //public bool Muerde {set; get;}
    }
}
