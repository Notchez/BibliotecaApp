using BibliotecaApp.Data;
using BibliotecaApp.Models;
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
    public partial class UsuariosForm : Form
    {
        private int filaSeleccionada = -1;
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
    string.IsNullOrWhiteSpace(txtCarnet.Text) ||
    string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Id = BibliotecaData.Usuarios.Count + 1;
            nuevoUsuario.Nombre = txtNombre.Text;
            nuevoUsuario.Carnet = txtCarnet.Text;
            nuevoUsuario.Correo = txtCorreo.Text;

            BibliotecaData.Usuarios.Add(nuevoUsuario);

            dgvUsuarios.Rows.Add(
                nuevoUsuario.Id,
                nuevoUsuario.Nombre,
                nuevoUsuario.Carnet,
                nuevoUsuario.Correo
            );

            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCarnet.Clear();
            txtCorreo.Clear();
        }
    }
}
