using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Libro : MaterialBiblioteca
    {
        public string Autor { get; set; }

        public override string MostrarInformacion()
        {
            return $"{Id} - {Titulo} - {Autor} - {Anio} - {(Disponible ? "Disponible" : "Prestado")}";
        }
    }
}
