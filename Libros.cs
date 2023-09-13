using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libros
    {
        public String Nombre { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Editorial { get; set; }
        public String FechaEdicion { get; set; }
        public String Formato { get; set; }
        public String ISBN { get; set; }
        public String Capitulos { get; set; }
        public String Tipo { get; set; }
        public String Categoria { get; set; }
        public bool Estado { get; set; }
        public int Stock { get; set; }

        public Libros(  String nombre,
                        String titulo,
                        String autor,
                        String edicion,
                        String fechaEdicion,
                        String formato,
                        String isbn,
                        String capitulos,
                        String tipo,
                        String categoria,
                        int stock)
        {            
            this.Nombre = nombre;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = edicion;
            this.FechaEdicion = fechaEdicion;
            this.Formato = formato;
            this.ISBN = isbn;
            this.Capitulos = capitulos;
            this.Tipo = tipo;
            this.Categoria = categoria;
            this.Estado = true;
            this.Stock = 0;
        }

        public void SetStock(int stock)
        {
            Stock += stock;            
        }

    }    

}
