using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.biblioteca
{
    class Libro : IDocumento, IUbicacion
    {
        public string Autor { set; get; }
        public string Titulo { set; get; }
        public int NumPaginas { set; get; }
        public string Estante { get ; set ; }
        public string Posicion { get ; set ; }

        public int Precio {set; get;}
    }
}
