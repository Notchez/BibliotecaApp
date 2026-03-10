using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Data
{
    public static class BibliotecaData
    {
        public static List<Libro> Libros = new List<Libro>();

        public static List<Usuario> Usuarios = new List<Usuario>();

        public static List<Prestamo> Prestamos = new List<Prestamo>();

        public static Dictionary<string, int> EstadisticasLibros = new Dictionary<string, int>();

        public static Dictionary<string, int> EstadisticasUsuarios = new Dictionary<string, int>();

        public static int[,] MatrizPrestamos = new int[10, 10];
    }
}
