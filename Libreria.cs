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
            int posicion = BusquedaTituloLibro(titulo);

            if (posicion == -1)
            {                
                Libros libro = new Libros(nombre, titulo, autor, editorial, fechaEdicion, formato, isbn, capitulos, tipo, categoria, stock);
                Libros.Add(libro); ;
            }
            else
            {               
                Libros.ElementAt(posicion).SetStock(stock);
            }
        }

        public int NumLibros()
        {
            return Libros.Count();
        }

        public int BusquedaTituloLibro(String titulo)
        {                        
            bool check = false;
            int posicion = -1;
            foreach (var libro in Libros) 
            {
                posicion++;
                if (libro.Titulo.Equals(titulo))
                {
                    check = true;
                    Console.WriteLine("El libro existe");                    
                    break;
                }
            }                      
            if (!check)
            {
                Console.WriteLine("El libro no existe");                
            }
            return posicion;
        }

        public void AddStock(String titulo, int stock)
        {
            int posicion = BusquedaTituloLibro(titulo);
            Libros.ElementAt(posicion).SetStock(stock);
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
