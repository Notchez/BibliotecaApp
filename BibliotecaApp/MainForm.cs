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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            LibrosForm librosForm = new LibrosForm();
            librosForm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamosForm prestamosForm = new PrestamosForm();
            prestamosForm.Show();
        }
    }
}
