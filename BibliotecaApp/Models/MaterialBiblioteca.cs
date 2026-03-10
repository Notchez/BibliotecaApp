using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class MaterialBiblioteca
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int Anio { get; set; }

        public bool Disponible { get; set; }

        public virtual string MostrarInformacion()
        {
            return $"{Id} - {Titulo} - {Anio}";
        }

        public void Prestar()
        {
            Disponible = false;
        }

        public void Devolver()
        {
            Disponible = true;
        }
    }
}