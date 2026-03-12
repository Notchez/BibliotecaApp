using BibliotecaApp.Models;
using BibliotecaApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class LibrosForm : Form
    {
        private int filaSeleccionada = -1;

        public LibrosForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            int anio;

            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("El año debe ser un número válido.");
                return;
            }

            Libro nuevoLibro = new Libro();

            nuevoLibro.Id = BibliotecaData.Libros.Count + 1;
            nuevoLibro.Titulo = txtTitulo.Text;
            nuevoLibro.Autor = txtAutor.Text;
            nuevoLibro.Anio = anio;
            nuevoLibro.Disponible = true;

            BibliotecaData.Libros.Add(nuevoLibro);

            dgvLibros.Rows.Add(
                nuevoLibro.Id,
                nuevoLibro.Titulo,
                nuevoLibro.Autor,
                nuevoLibro.Anio,
                nuevoLibro.Disponible
            );

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }
    }
}
