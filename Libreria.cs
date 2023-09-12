using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libreria
    {
        List<Libros> libros;

        public void AltaLibro()
        {
            Libros l1 = new Libros("NOMBRE", "TITULO", "AUTOR1, AUTOR2", "EDITORIAL", "2023", "DURA", "123456", "42", "NOVELA", "JUVENIL", 10);

            this.libros.Add(l1);
        }

        public void VentaLibro( int id , int numLibros )
        {
            if (this.libros.ElementAt(id - 1).stock >= numLibros)
            {
                this.libros.ElementAt(id - 1).stock = this.libros.ElementAt(id - 1).stock - numLibros;
            }
            else
            {
                Console.WriteLine("No hay libros suficientes");
            }            
        }

        public Libros BusquedaLibro( String nom )
        {
            String busqueda = "";
            Libros libroDevuelto = null;
            for (int i = 0; i < libros.Count; i++)
            {
                if (this.libros.ElementAt(i).titulo == nom)
                {
                    busqueda = "El libro existe";
                    libroDevuelto = this.libros.ElementAt(i);
                }
                else
                {
                    busqueda = "El libro NO existe";
                }
            }          

            return libroDevuelto;
        }
    }
}
