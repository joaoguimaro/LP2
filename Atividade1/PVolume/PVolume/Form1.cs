using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
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

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVolume_Click(object sender, EventArgs e)
        {

        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if ((double.TryParse(txtAltura.Text, out altura)) &&
                (double.TryParse(txtRaio.Text, out raio)))
            {
                if ((txtRaio.Text.IndexOf(".") > 0) || (txtAltura.Text.IndexOf(".") > 0))
                {
                    MessageBox.Show("Não permitido o uso de '.'");
                }
                else
                {
                    if (altura >= 0 && raio >= 0)
                    {
                        double volume;
                        volume = Math.PI * Math.Pow(raio, 2) * altura;

                        txtVolume.Text = volume.ToString("N2");
                    }
                    else
                        MessageBox.Show("Valores não podem ser negativos!");
                }
            }
            else
                MessageBox.Show("Valores Inválidos!");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text = String.Empty;
        }
    }
}
