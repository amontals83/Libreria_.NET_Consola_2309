/*
Se desea diseñar un programa que registre libros (técnicos y novelas) para una librería y permita buscarlos, venderlos y verificar su stock. 
Las novelas se clasifican como de ciencia ficción, romance misterio, juveniles y policiales. Los libros técnicos se clasifican como de ingeniería, ciencias naturales o ciencias sociales. 
Cada libro tiene un título, uno o más autores, una editorial, un año de edición y formato (tapa dura o blanda) . Los libros tienen además un código OSBN y capítulos. 
La librería obtiene los libros por medio de proveedores que representan a una o más editoriales. De cada libro tenemos un stock (puede ser 0). Al venderse el libro, se actualiza. Si un cliente requiere un libro cuyo stock es 0, se puede hacer un encargo.  
*/

namespace Libreria
{
    public class GestionLibreria 
    {
        public static void Main(String[] args)
        {
            Libreria CasaDelLibro = new Libreria();

            CasaDelLibro.AltaLibro("NOMBRE", "TITULO", "AUTOR1, AUTOR2", "EDITORIAL", "2023", "DURA", "123456", "42", "NOVELA", "JUVENIL", 10);

            Console.WriteLine(CasaDelLibro.NumLibros());

            CasaDelLibro.BusquedaTituloLibro("TITULO");

            CasaDelLibro.ExportaLibroFichero();
        }
    }
}