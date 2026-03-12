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
        public LibrosForm()
        {
            InitializeComponent();
        }

        private void LibrosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro nuevoLibro = new Libro();

            nuevoLibro.Id = BibliotecaData.Libros.Count + 1;
            nuevoLibro.Titulo = txtTitulo.Text;
            nuevoLibro.Autor = txtAutor.Text;
            nuevoLibro.Anio = int.Parse(txtAnio.Text);
            nuevoLibro.Disponible = true;

            BibliotecaData.Libros.Add(nuevoLibro);

            dgvLibros.Rows.Add(
                nuevoLibro.Id,
                nuevoLibro.Titulo,
                nuevoLibro.Autor,
                nuevoLibro.Anio,
                nuevoLibro.Disponible
            );

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }
    }
}
