using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "distancia recorrida";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double tiempo = Convert.ToDouble(txttiempo.Text);
                double velocidad = Convert.ToDouble(txtvelocidad.Text);

                double distancia = tiempo * velocidad;

                txtresultado.Text = distancia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en ambos campos.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txttiempo.Text = "";
            txtvelocidad.Text = "";
            txtresultado.Text = "";

            txttiempo.Focus();
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
