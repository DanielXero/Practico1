using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }    

        private void BGuardar_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = $"{txtApellido.Text} {txtNombre.Text}";
        }

        private void BEliminar_Click_1(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecta si se presion� Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Activa el bot�n que desees
                BSalir.PerformClick();
            }
        }
    }
}
