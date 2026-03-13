using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BibliotecaApp.Models
{
    public class Usuario : Persona
    {
        public string Carnet { get; set; }

        public override string MostrarInformacion()
        {
            return $"{Id} - {Nombre} - {Carnet} - {Correo}";
        }
    }
}
