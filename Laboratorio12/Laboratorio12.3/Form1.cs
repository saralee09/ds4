using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12._3
{
    public partial class lab12_3 : Form
    {
        public lab12_3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtSP.Text = string.Empty;
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double C = Convert.ToDouble(txtC.Text);


                double SP = (A+B+C) / 2;

                txtSP.Text = SP.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Pro favor, inserta cantidades validas para los lados");
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double C = Convert.ToDouble(txtC.Text);

                double SP = (A + B + C) / 2;
                double area = Math.Sqrt(SP * (SP - A) * (SP - B) * (SP - C));

                txtSP.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Pro favor, inserta cantidades validas para los lados");
            }
        }
    }
}
