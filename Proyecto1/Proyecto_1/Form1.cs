using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, resultado = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = double.Parse(txtPantalla.Text);
                operacion = "/";
                txtPantalla.Clear();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = double.Parse(txtPantalla.Text);
                operacion = "*";
                txtPantalla.Clear();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = double.Parse(txtPantalla.Text);
                operacion = "-";
                txtPantalla.Clear();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = double.Parse(txtPantalla.Text);
                operacion = "+";
                txtPantalla.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                    return;

                valor2 = double.Parse(txtPantalla.Text);

                switch (operacion)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        if (valor2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        resultado = valor1 / valor2;
                        break;
                    default:
                        resultado = valor2;
                        break;
                }

                txtPantalla.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}

