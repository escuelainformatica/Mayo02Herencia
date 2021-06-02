using Mayo02Herencia.herencia;
using Mayo02Herencia.herencia2;
using Mayo02Herencia.veterinario;
using System;

namespace Mayo02Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

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
