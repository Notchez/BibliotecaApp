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

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAnio.Text = dgvLibros.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un libro para editar.");
                return;
            }

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

            BibliotecaData.Libros[filaSeleccionada].Titulo = txtTitulo.Text;
            BibliotecaData.Libros[filaSeleccionada].Autor = txtAutor.Text;
            BibliotecaData.Libros[filaSeleccionada].Anio = anio;

            dgvLibros.Rows[filaSeleccionada].Cells[1].Value = txtTitulo.Text;
            dgvLibros.Rows[filaSeleccionada].Cells[2].Value = txtAutor.Text;
            dgvLibros.Rows[filaSeleccionada].Cells[3].Value = anio;

            LimpiarCampos();
            filaSeleccionada = -1;

            MessageBox.Show("Libro editado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este libro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                BibliotecaData.Libros.RemoveAt(filaSeleccionada);
                dgvLibros.Rows.RemoveAt(filaSeleccionada);

                LimpiarCampos();
                filaSeleccionada = -1;

                MessageBox.Show("Libro eliminado correctamente.");
            }
        }
    }
}
