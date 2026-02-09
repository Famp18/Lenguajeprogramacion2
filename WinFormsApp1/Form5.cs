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
    public partial class Form5 : Form
    {
        string input = String.Empty;
        string operacion1 = String.Empty;
        string operacion2 = String.Empty;
        Char operacion;
        double result = 0.0;


        public Form5()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operacion = '+';
            input = String.Empty;

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operacion = '-';
            input = String.Empty;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operacion = '*';
            input = String.Empty;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operacion = '/';
            input = String.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            operacion2 = input;
            double valor1, valor2;
            double.TryParse(operacion1, out valor1);
            double.TryParse(operacion2, out valor2);
            
            if (operacion == '+')
            {
                result = valor1 + valor2;
                txtvalor1.Text = result.ToString();
            }
            else if (operacion == '-')
            {
                result = valor1 - valor2;
                txtvalor1.Text = result.ToString();
            }
            else if (operacion == '*')
            {
                result = valor1 * valor2;
                txtvalor1.Text = result.ToString();
            }
            else if (operacion == '/')
            {
                if (valor2 != 0)
                {
                    result = valor1 / valor2;
                    txtvalor1.Text = result.ToString();
                }
                else
                {
                    txtvalor1.Text = "Error: División por cero";
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //agregar un boton que borre los valores de los text box//

            this.txtvalor1.Text = "";
            this.input = String.Empty;
            this.operacion1 = String.Empty;
            this.operacion2 = String.Empty;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtvalor1.Clear();


        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            txtvalor1.Focus();

        }

        private void button0_Click(object sender, EventArgs e)
        {
            //agregar un boton que al precionarlo coloque un 0 en el text box//

            this.txtvalor1.Text = "";
            input += "0";
            this.txtvalor1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "1";
            this.txtvalor1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "2";
            this.txtvalor1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "3";
            this.txtvalor1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "4";
            this.txtvalor1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "5";
            this.txtvalor1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "6";
            this.txtvalor1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "7";
            this.txtvalor1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "8";
            this.txtvalor1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = "";
            input += "9";
            this.txtvalor1.Text += input;
        }
    }
}
