using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaApp.Data;

namespace BibliotecaApp
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            int totalLibros = BibliotecaData.Libros.Count;

            int disponibles = 0;
            int prestados = 0;

            foreach (var libro in BibliotecaData.Libros)
            {
                if (libro.Disponible)
                    disponibles++;
                else
                    prestados++;
            }

            int totalUsuarios = BibliotecaData.Usuarios.Count;
            int totalPrestamos = BibliotecaData.Prestamos.Count;

            int usuariosConPrestamo = 0;

            foreach (var usuario in BibliotecaData.Usuarios)
            {
                foreach (var prestamo in BibliotecaData.Prestamos)
                {
                    if (prestamo.UsuarioPrestamo.Id == usuario.Id)
                    {
                        usuariosConPrestamo++;
                        break;
                    }
                }
            }

            int usuariosSinPrestamo = totalUsuarios - usuariosConPrestamo;

            lblTotalLibros.Text = $"Total Libros: {totalLibros}";
            lblLibrosDisponibles.Text = $"Libros Disponibles: {disponibles}";
            lblLibrosPrestados.Text = $"Libros Prestados: {prestados}";
            lblTotalUsuarios.Text = $"Total Usuarios: {totalUsuarios}";
            lblUsuariosConPrestamo.Text = $"Usuarios con Prestamo: {usuariosConPrestamo}";
            lblUsuariosSinPrestamo.Text = $"Usuarios sin Prestamo: {usuariosSinPrestamo}";
            lblTotalPrestamos.Text = $"Total Prestamos: {totalPrestamos}";

            CargarGraficoLibros(disponibles, prestados);
        }

        private void CargarGraficoLibros(int disponibles, int prestados)
        {
            chartLibros.Series.Clear();

            var serie = chartLibros.Series.Add("Libros");

            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            serie.Points.AddXY("Disponibles", disponibles);
            serie.Points.AddXY("Prestados", prestados);
        }
    }
}
