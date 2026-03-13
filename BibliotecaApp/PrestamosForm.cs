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
using BibliotecaApp.Models;

namespace BibliotecaApp
{
    public partial class PrestamosForm : Form
    {
        private int filaSeleccionada = -1;
        public PrestamosForm()
        {
            InitializeComponent();
            CargarLibros();
            CargarUsuarios();
        }

        private void CargarLibros()
        {
            cmbLibros.Items.Clear();

            foreach (Libro libro in BibliotecaData.Libros)
            {
                if (libro.Disponible)
                {
                    cmbLibros.Items.Add(libro);
                }
            }

            cmbLibros.DisplayMember = "Titulo";
        }

        private void CargarUsuarios()
        {
            cmbUsuarios.Items.Clear();

            foreach (Usuario usuario in BibliotecaData.Usuarios)
            {
                cmbUsuarios.Items.Add(usuario);
            }

            cmbUsuarios.DisplayMember = "Nombre";
        }

        private bool ValidarPrestamo()
        {
            if (cmbLibros.SelectedItem == null || cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un libro y un usuario.");
                return false;
            }

            if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser antes que la fecha de préstamo.");
                return false;
            }

            return true;
        }

        private void ActualizarMatrizPrestamos(Libro libro, Usuario usuario, int valor)
        {
            int filaUsuario = usuario.Id - 1;
            int columnaLibro = libro.Id - 1;

            if (filaUsuario >= 0 && filaUsuario < 10 &&
                columnaLibro >= 0 && columnaLibro < 10)
            {
                BibliotecaData.MatrizPrestamos[filaUsuario, columnaLibro] = valor;
            }
        }

        private void ActualizarEstadisticasLibros()
        {
            int disponibles = 0;
            int prestados = 0;

            foreach (Libro libro in BibliotecaData.Libros)
            {
                if (libro.Disponible)
                {
                    disponibles++;
                }
                else
                {
                    prestados++;
                }
            }

            BibliotecaData.EstadisticasLibros["Disponibles"] = disponibles;
            BibliotecaData.EstadisticasLibros["Prestados"] = prestados;
            BibliotecaData.EstadisticasLibros["Total"] = BibliotecaData.Libros.Count;
        }

        private void ActualizarMatrizPrestamos(Libro libro, Usuario usuario, int valor)
        {
            int filaUsuario = usuario.Id - 1;
            int columnaLibro = libro.Id - 1;

            if (filaUsuario >= 0 && filaUsuario < 10 &&
                columnaLibro >= 0 && columnaLibro < 10)
            {
                BibliotecaData.MatrizPrestamos[filaUsuario, columnaLibro] = valor;
            }
        }

        private void ActualizarEstadisticasLibros()
        {
            int disponibles = 0;
            int prestados = 0;

            foreach (Libro libro in BibliotecaData.Libros)
            {
                if (libro.Disponible)
                {
                    disponibles++;
                }
                else
                {
                    prestados++;
                }
            }

            BibliotecaData.EstadisticasLibros["Disponibles"] = disponibles;
            BibliotecaData.EstadisticasLibros["Prestados"] = prestados;
            BibliotecaData.EstadisticasLibros["Total"] = BibliotecaData.Libros.Count;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarPrestamo())
            {
                return;
            }

            Libro libroSeleccionado = (Libro)cmbLibros.SelectedItem;
            Usuario usuarioSeleccionado = (Usuario)cmbUsuarios.SelectedItem;

            Prestamo nuevoPrestamo = new Prestamo();

            nuevoPrestamo.Id = BibliotecaData.Prestamos.Count + 1;
            nuevoPrestamo.LibroPrestado = libroSeleccionado;
            nuevoPrestamo.UsuarioPrestamo = usuarioSeleccionado;
            nuevoPrestamo.FechaPrestamo = dtpFechaPrestamo.Value;
            nuevoPrestamo.FechaDevolucion = dtpFechaDevolucion.Value;

            BibliotecaData.Prestamos.Add(nuevoPrestamo);

            libroSeleccionado.Prestar();
            ActualizarMatrizPrestamos(libroSeleccionado, usuarioSeleccionado, 1);
            ActualizarEstadisticasLibros();

            dgvPrestamos.Rows.Add(
                nuevoPrestamo.Id,
                nuevoPrestamo.LibroPrestado.Titulo,
                nuevoPrestamo.UsuarioPrestamo.Nombre,
                nuevoPrestamo.FechaPrestamo.ToShortDateString(),
                nuevoPrestamo.FechaDevolucion.ToShortDateString()
            );

            CargarLibros();

            MessageBox.Show("Préstamo registrado correctamente.");
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un préstamo para devolver.");
                return;
            }

            Prestamo prestamoSeleccionado = BibliotecaData.Prestamos[filaSeleccionada];

            prestamoSeleccionado.LibroPrestado.Devolver();
            ActualizarMatrizPrestamos(prestamoSeleccionado.LibroPrestado, prestamoSeleccionado.UsuarioPrestamo, 0);
            ActualizarEstadisticasLibros();

            BibliotecaData.Prestamos.RemoveAt(filaSeleccionada);
            dgvPrestamos.Rows.RemoveAt(filaSeleccionada);

            filaSeleccionada = -1;

            CargarLibros();

            MessageBox.Show("Libro devuelto correctamente.");
        }
    }
}
