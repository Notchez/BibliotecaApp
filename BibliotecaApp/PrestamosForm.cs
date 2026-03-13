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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem == null || cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un libro y un usuario.");
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
    }
}
