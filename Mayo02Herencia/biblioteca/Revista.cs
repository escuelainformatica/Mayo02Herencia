using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo02Herencia.biblioteca
{
    class Revista : IDocumento
    {
        public string Autor { get; set ; }
        public int NumPaginas { get ; set ; }
        public string Titulo { get ; set; }
    }
    // 1 clase = 1 interface.
}
