using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia
{
    // Empleado hereda Persona
    // empleado depende de persona <-- dependencias son malas.
    class Empleado : Persona
    {        
        public void FuncionEjemplo()
        {
            Console.WriteLine("desde empleado");
        }
        public override void FuncionEjemplo2()
        {
            Console.WriteLine("desde empleado");
        }


    }
}
