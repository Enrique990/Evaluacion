using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        private Models.Registro registro = new Models.Registro();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNotas.Text, out int nota))
            {
                registro.AgregarNota(nota);
                tbNotas.Clear();
                tbNotas.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero entero");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMPromedio_Click(object sender, EventArgs e)
        {
            double promedio = registro.Promedio();
            textBox3.Text = "Promedio: " + promedio.ToString("F2");
        }

        private void btnMMejores_Click(object sender, EventArgs e)
        {
            int[] tresMejores = registro.TresMejores();
            lblPrimerLugar.Text = "1er Lugar: " + tresMejores[0];
            lblSegundoLugar.Text = "2do Lugar: " + tresMejores[1];
            lblTercerLugar.Text = "3er Lugar: " + tresMejores[2];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbNotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
