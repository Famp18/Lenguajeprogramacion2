using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //agregar la coversion de grados celsius a fahrenheit & Viceversa//

            Double ValorEntrada;
            Double ValorConvertido;

            try
            {
                ValorEntrada = Double.Parse(txtagregar.Text);
                if (comboBox1.SelectedItem.ToString() == "Celsius a Fahrenheit")
                {
                    ValorConvertido = (ValorEntrada * 9 / 5) + 32;
                    MessageBox.Show("El resultado de la conversion es: " + ValorConvertido + " °F");
                }
                else if (comboBox1.SelectedItem.ToString() == "Fahrenheit a Celsius")
                {
                    ValorConvertido = (ValorEntrada - 32) * 5 / 9;
                    MessageBox.Show("El resultado de la conversion es: " + ValorConvertido + " °C");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Debes ingresar un número válido.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Celsius a Fahrenheit");
            comboBox1.Items.Add("Fahrenheit a Celsius");
            comboBox1.SelectedIndex = 0;
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            //agregar una barra de progreso que se llene al pulsar el botton de iniciar//

            progressBar1.Value = 0;

            progressBar1.Maximum = 100;

            progressBar1.Minimum = 0;
            progressBar1.Visible = false;
            progressBar1.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(50);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //agregar un mensaje que diga proceso cancelado//

            progressBar1.Value = 0;

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Visible = false;
            progressBar1.Visible = true;

            MessageBox.Show("Proceso Cancelado");


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //cada pestaña del tabcontrol mostrara un mensaje diferente//

            tabControl1.SelectedIndex = 0;

            MessageBox.Show("Bienvenido a la pestaña 1");

            tabControl1.SelectedIndex = 1;

            MessageBox.Show("Bienvenido a la pestaña 2");
        }
    }
}
