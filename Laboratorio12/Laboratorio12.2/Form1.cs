using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnProm_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double nota3 = Convert.ToDouble(txtNota3.Text);


                double prom = (nota1+nota2+nota3)/3;

                txtResultado.Text = prom.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Pro favor, inserta cantidades validas en los campos de notas");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
