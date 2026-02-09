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
    public partial class Form3 : Form
    {
        int contador = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar una lista de colores para el formulario//

            if (comboBox1.SelectedItem.ToString() == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedItem.ToString() == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedItem.ToString() == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar un elemento a la lista//

            lbxAgregar.Items.Add(txtAgregar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //el boton contara las veses qeu ha sido precionado//

            contador++;

            MessageBox.Show("El boton ha sido precionado " + contador + " veces");
        }

        private void btnPrecionar_Click(object sender, EventArgs e)
        {
            //agregar mensaje que al colocar un texto marque un error//

            int numero;

            if (!int.TryParse(txtPrecionar.Text, out numero))
            {
                MessageBox.Show("Error: Debes ingresar un número válido.");
            }
            else
            {
                e.Equals(numero);

                MessageBox.Show("Número ingresado correctamente: " + numero);
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            //Mostrar la fecha y hora actual destro de una etiqueta//

           MessageBox.Show("La fecha y hora actual es: " + DateTime.Now.ToString());

            dtpFecha.Value = DateTime.Now;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFecha.Enabled = true;
        }
    }
}
