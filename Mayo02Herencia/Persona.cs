using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia
{
    class Persona
    {
        public string Rut {set; get;}
        public string Nombre {set; get;}
        public string Correo {set; get;}
        public string Telefono {set; get;}

        public void FuncionEjemplo()
        {

        }

        // virtual = funcion que puede sobreescribirse
        // abstract = funcion que debe sobreescribirse
        public virtual void FuncionEjemplo2()
        {

        }
        // public abstract void FuncionEjemplo3();

     
    }
}
