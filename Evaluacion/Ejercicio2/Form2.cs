using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        private models.Estudiante estudiante = new models.Estudiante();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                estudiante.AgregarNombre(txtNombre.Text);
                txtNombre.Clear();
                MessageBox.Show("Nombre agregado correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            lstNombres.Items.Clear();
            var nombresLargos = estudiante.ObtenerNombresLargos();
            foreach (var nombre in nombresLargos)
            {
                lstNombres.Items.Add(nombre);
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
