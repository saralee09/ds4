using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_m2y_Click(object sender, EventArgs e)
        {

        }

        private void txt_m2y_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_m2y_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_m2y.Text, out double metros))
            {
                double yardas = metros * 1.09361;
                txt_m2yans.Text = yardas.ToString("F2");
                GuardarConversion("Metros a Yardas", metros, yardas);
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en metros.");
            }
        }
        

        private void txt_m2yans_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_y2m_Click(object sender, EventArgs e)
        {

        }

        private void txt_y2m_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_y2m_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_y2m.Text, out double yardas))
            {
                double metros = yardas / 1.09361;
                txt_y2mans.Text = metros.ToString("F2");
                GuardarConversion("Yardas a Metros", yardas, metros);
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en yardas.");
            }

        }

        private void txt_y2mans_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_m2y.Clear();
            txt_m2yans.Clear();
            txt_y2m.Clear();
            txt_y2mans.Clear();
            lst_historial.Items.Clear();
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            lst_historial.Items.Clear();
            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = "SELECT TipoConversion, ValorOriginal, ValorConvertido, Fecha FROM HistorialConversiones ORDER BY Fecha DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tipo = reader.GetString(0);
                    double original = reader.GetDouble(1);
                    double convertido = reader.GetDouble(2);
                    DateTime fecha = reader.GetDateTime(3);
                    lst_historial.Items.Add($"{fecha:g} - {tipo}: {original} → {convertido}");
                }
            }

        }

        private void lst_hitorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GuardarConversion(string tipo, double original, double convertido)
        {
            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = "INSERT INTO HistorialConversiones (TipoConversion, ValorOriginal, ValorConvertido, Fecha) VALUES (@tipo, @original, @convertido, @fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@original", original);
                cmd.Parameters.AddWithValue("@convertido", convertido);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
