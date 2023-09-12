using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libreria
    {
        public List<Libros> Libros;

        public Libreria()
        {
            Libros = new List<Libros>();
            Console.WriteLine("Alta de la Libreria");
        }

        public void AltaLibro( String nombre, String titulo, String autor, String editorial, String fechaEdicion, String formato, String isbn, String capitulos, String tipo, String categoria, int stock)
        {
            Libros libro = new Libros(nombre, titulo, autor, editorial, fechaEdicion, formato, isbn, capitulos, tipo, categoria, stock);

            Libros.Add(libro);
        }

        public int NumLibros()
        {
            return Libros.Count();
        }

        public Libros BusquedaTituloLibro(String titulo)
        {                        
            bool check = false;

            foreach (var libro in Libros) 
            {
                if (libro.Titulo.Equals(titulo))
                {
                    check = true;
                    Console.WriteLine("El libro existe");
                    return libro;
                    break;
                }
            }                      
            if (!check)
            {
                Console.WriteLine("El libro no existe");                
            }
            return null;
        }

        public void VentaLibro(String titulo)
        {
            foreach (var libro in Libros)
            {
                if (libro.Titulo.Equals(titulo))
                {
                    libro.Stock -= libro.Stock;
                    break;
                }
            }
        }

        public void ListaLibros()
        {
            Console.WriteLine("------------------------");
            foreach (var libro in Libros)
            {
                Console.WriteLine("TITULO: " + libro.Titulo);
                Console.WriteLine("AUTORES: " + libro.Autor);
                Console.WriteLine("------------------------");
            }            
        }

        public void ExportaLibroFichero()
        {
            String path = "c:\\log\\fichero.txt";//Es necesario poner el archivo dentro de una carpeta
            File.WriteAllText(path, "------------------------" + "\n\r");

            foreach (var libro in Libros)
            {
                File.AppendAllText(path, "TITULO: ;" + libro.Titulo + ";" + libro.Autor + ";" + libro.Editorial + "\n\r");//Con ';' hacemos que al hacer un archivo .csv lo haga en celdas cada dato
                File.AppendAllText(path, "AUTORES: " + libro.Autor + "\n\r");
                File.AppendAllText(path, "------------------------" + "\n\r");
            }
        }
    }
}
