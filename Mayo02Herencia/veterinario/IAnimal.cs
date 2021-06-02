using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.veterinario
{
    // prefijo "I" interface.  IAnimal = interface, Animal=Clase.
    //                         Animal= interface, AnimalImpl = Clase (impl = implementacion)

    // clase abstracta
    // 1) no tiene ni publico ni privado dentro de la interface
    // 2) no tiene campos, pero si tiene propiedades.
    // 3) los metodos no tiene codigo.


    // para que nos sirve?
    // Las interfaces por un lado, son un contrato.
    // Las interfaces nos sirven para generalizar el codigo.

    interface IAnimal
    {
        string Nombre {set; get;}
        string Raza {set; get;}
        int Peso {set; get;}

        void FuncionEjemplo();
    }
}
