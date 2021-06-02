using Mayo02Herencia.herencia;
using Mayo02Herencia.herencia2;
using Mayo02Herencia.veterinario;
using System;
using System.Collections.Generic;

namespace Mayo02Herencia
{
    class Program
    {
        static void Main(string[] args)
        { //                                          0     1            2
            List<string> paises=new List<string> {"Chile","Argentina","Peru"};
            paises.Add("Bolivia");
            var p=paises[2]; //peru

            // DbSet<string> paises3; base de datos
            
            HashSet<string> paisesArray=new HashSet<string> {"Chile","Argentina","Peru"};

            //paises=paisesArray.

            
            Stack<string> pila=new Stack<string>();
            pila.Push("Chile");
            pila.Push("Peru");
            pila.Push("Argentina");
            var quitar=pila.Pop(); // Argentina.

            Queue<string> fila=new Queue<string>();
            pila.Push("Chile");
            pila.Push("Peru");
            pila.Push("Argentina");
            var quitar2=pila.Pop(); // Chile
            quitar2=pila.Pop(); // Peru


            //         llave, valor
            Dictionary<string,string> dic=new Dictionary<string, string>();

            dic["primera"]="Chile";
            dic["segunda"]="Argentina";
            dic["tercera"]="Peru";

            var v2=dic["primera"]; // Chile

            Dictionary<int,string> dic2=new Dictionary<int, string>();
            dic2[0]="Chile";
            dic2[1]="Argentina";




            var mensaje=new GenerarAlerta();
            //mensaje.Alto=10;
            //mensaje.Mensaje="hola mundo 222222222222222";
            Console.WriteLine( mensaje.Mostrar("Sistema caido","Error critico") );

          //  Console.WriteLine(MostrarV2.MostrarAlert("hola mundo","error"));
            //Contenedor.Bordes("hola mundo");


            int v1;
            var v2=20;

            // IAnimal var3=new IAnimal();
            IAnimal perro=new Perro {Nombre="snoopy",Raza="Beagle",Muerde=false,Peso=700};
            IAnimal gato=new Gato {Nombre="garfield",Raza="normal",Peso=300};
            IAnimal loro=new Loro {Nombre="matias",Raza="argentina",Peso=100, Exotico=true};

            int costo=VeterinarioServicio.CostoConsulta(perro);
            int costo2=VeterinarioServicio.CostoConsulta(gato);
            int costo3=VeterinarioServicio.CostoConsulta(loro);


        }
    }
}
