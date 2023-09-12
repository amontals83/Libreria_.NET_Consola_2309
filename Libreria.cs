using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libreria
    {
        List<Libros> libros = new List<Libros>();

        public void AltaLibro( String nombre, String titulo, String autores, String editorial, String fechaCreacion, String formato, String osmr, String capitulos, String tipo, String categoria, int stock)
        {
            Libros libro1 = new Libros(nombre, titulo, autores, editorial, fechaCreacion, formato, osmr, capitulos, tipo, categoria, stock);

            this.libros.Add(libro1);
        }        
    }
}
