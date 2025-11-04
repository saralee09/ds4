using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(connectionString);
            }

            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                }
            }
            else
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
        }

        private void CargarProductos()
        {
            listBox1.Items.Clear();
            string query = "SELECT ProductName FROM [dbo].[Products]";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["ProductName"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedProduct = listBox1.SelectedItem.ToString();
                MessageBox.Show("Producto seleccionado: " + selectedProduct);
            }
        }
    }
}
