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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            //agregar un mensaje que diga Texto Cambiado//

            lblReflejo.Text = "Texto Cambiado";


        }

        private void btnPreciona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtPreciona.Text);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //sumar dos numeros//

            int numero1 = Convert.ToInt32(txtValor1.Text);
            int numero2 = Convert.ToInt32(txtValor2.Text);

            int resultado = numero1 + numero2;

            MessageBox.Show("El resultado de la suma es: " + resultado);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //formulario de seleccion //

                if (rb1.Checked)
                {
                    MessageBox.Show("Seleccionaste la Opcion 1");
                }
                else if (rb2.Checked)
                {
                    MessageBox.Show("Seleccionaste la Opcion 2");
                }
                else if (rb3.Checked)
                {
                    MessageBox.Show("Seleccionaste la Opcion 3");
                }
                else
                {
                    MessageBox.Show("No seleccionaste ninguna opción");
            }
        }
    }
}
