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
            if (!ValidarCampos())
            {
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            return true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCarnet.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            BibliotecaData.Usuarios[filaSeleccionada].Nombre = txtNombre.Text;
            BibliotecaData.Usuarios[filaSeleccionada].Carnet = txtCarnet.Text;
            BibliotecaData.Usuarios[filaSeleccionada].Correo = txtCorreo.Text;

            dgvUsuarios.Rows[filaSeleccionada].Cells[1].Value = txtNombre.Text;
            dgvUsuarios.Rows[filaSeleccionada].Cells[2].Value = txtCarnet.Text;
            dgvUsuarios.Rows[filaSeleccionada].Cells[3].Value = txtCorreo.Text;

            LimpiarCampos();
            filaSeleccionada = -1;

            MessageBox.Show("Usuario editado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                BibliotecaData.Usuarios.RemoveAt(filaSeleccionada);
                dgvUsuarios.Rows.RemoveAt(filaSeleccionada);

                LimpiarCampos();
                filaSeleccionada = -1;

                MessageBox.Show("Usuario eliminado correctamente.");
            }
        }
    }
}
