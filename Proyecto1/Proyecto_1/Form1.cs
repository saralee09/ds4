using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

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
            txtPantalla.Text += "9";
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

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvbinario_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                int numero = (int)double.Parse(txtPantalla.Text);
                txtPantalla.Text = Convert.ToString(numero, 2);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            valor1 = valor2 = resultado = 0;
            operacion = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
        }

        private void btnConvdecimal_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                try
                {
                    int numeroDecimal = Convert.ToInt32(txtPantalla.Text, 2);
                    txtPantalla.Text = numeroDecimal.ToString();
                }
                catch
                {
                    MessageBox.Show("El valor no es un número binario válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRaizcuadrada_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                double num = double.Parse(txtPantalla.Text);
                resultado = Math.Sqrt(num);
                txtPantalla.Text = resultado.ToString();
            }
        }

        private void btnAlcuadrado_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                double num = double.Parse(txtPantalla.Text);
                resultado = Math.Pow(num, 2);
                txtPantalla.Text = resultado.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
            {
                if (txtPantalla.Text == "")
                    txtPantalla.Text = "0.";
                else
                    txtPantalla.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    string query = "SELECT Valor1, Operacion, Valor2, Resultado, Fecha FROM Historial ORDER BY Fecha DESC";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    lstHistorial.Items.Clear();

                    while (reader.Read())
                    {
                        string fila = $"{reader["Valor1"]} {reader["Operacion"]} {reader["Valor2"]} = {reader["Resultado"]}  ({reader["Fecha"]})";
                        lstHistorial.Items.Add(fila);
                    }

                    reader.Close();
                }

                lstHistorial.Visible = true;

                if (lstHistorial.Items.Count == 0)
                    MessageBox.Show("No hay operaciones guardadas aún.", "Historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el historial: " + ex.Message);
            }
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GuardarCalculo(double v1, string op, double v2, double res)
        {
            try
            {
                // Usa la conexión del App.config
                string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    string query = "INSERT INTO Historial (Valor1, Operacion, Valor2, Resultado) VALUES (@v1, @op, @v2, @res)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@v1", v1);
                    cmd.Parameters.AddWithValue("@op", op);
                    cmd.Parameters.AddWithValue("@v2", v2);
                    cmd.Parameters.AddWithValue("@res", res);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cálculo: " + ex.Message);
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                    return;

                // Si no hay operación , solo muestra el número
                if (string.IsNullOrEmpty(operacion))
                {
                    txtPantalla.Text = txtPantalla.Text;
                    return;
                }

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

                GuardarCalculo(valor1, operacion, valor2, resultado);

                // Reinicia la operación
                operacion = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

}

