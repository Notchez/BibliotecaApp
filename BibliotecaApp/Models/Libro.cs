using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Libro
    {
        public string Autor { get; set; }

        public int Anio { get; set; }

        public bool Disponible { get; set; }
    }
}
