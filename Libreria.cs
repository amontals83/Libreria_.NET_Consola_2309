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

        public int NumLibros()
        {
            return this.libros.Count();
        }

        public Libros BusquedaTituloLibro(String tit)
        {                        
            bool check = false;

            foreach (var libro in this.libros) 
            {
                if (libro.titulo.Equals(tit))
                {
                    check = true;
                    return libro;
                    break;
                }
            }                      
            if (check)
            {
                Console.WriteLine("El libro existe");                
            }
            return null;

            /*Otro bucle que no funcionaria si alguien durante el proceso añade o vende un libro en el List
            Libros libroDevuelto = null;
            for (int i = 0; i < libros.Count; i++)
            {
                if (this.libros.ElementAt(i).titulo == tit)
                {
                    Console.WriteLine("El libro existe");
                    libroDevuelto = this.libros.ElementAt(i);
                }
                else
                {
                   Console.WriteLine("El libro NO existe");
                }
            }
            return libroDevuelto;
            */
        }       


    }
}
