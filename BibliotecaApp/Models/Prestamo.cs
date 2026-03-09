using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro LibroPrestado { get; set; }
        public Usuario UsuarioPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
