using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libros
    {
        public int id = 0;
        public String nombre { get; set; }
        public String titulo { get; set; }
        public String autores { get; set; }
        public String editorial { get; set; }
        public String fechaEdicion { get; set; }
        public String formato { get; set; }
        public String osbn { get; set; }
        public String capitulos { get; set; }
        public String tipo { get; set; }
        public String categoria { get; set; }
        public bool estado { get; set; }
        public int stock { get; set; }

        public Libros(  String nom,
                        String tit,
                        String aut,
                        String edi,
                        String fech,
                        String form,
                        String osbn,
                        String cap,
                        String tip,
                        String cat,
                        int stock)
        {
            this.id = id++;
            this.nombre = nom;
            this.titulo = tit;
            this.autores = aut;
            this.editorial = edi;
            this.fechaEdicion = fech;
            this.formato = form;
            this.osbn = osbn;
            this.capitulos = cap;
            this.tipo = tip;
            this.categoria = cat;
            this.estado = true;
            this.stock = stock;
        }

        public int SetStock( int stock)
        {
            this.stock = stock;
            return this.stock;
        }

    }    

}
