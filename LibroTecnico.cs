using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class LibroTecnico : Libros
    {
        public String categoria;

        public LibroTecnico(String categoria)
        {
            this.categoria = categoria;
        }
    }
    
}
