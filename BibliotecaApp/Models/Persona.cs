using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public string Correo { get; set; }

        public virtual string MostrarInformacion()
        {
            return $"{Id} - {Nombre} - {Correo}";
        }
    }
}
