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
        }
    }
}