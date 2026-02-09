namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();

        public Form1()
        {
            InitializeComponent();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void BtnHola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Soy Francisco Mateo ");

            MessageBox.Show("y Mi matricula es SD-18-20045");
        }

        private void formulario4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fom4 = new Form4();
            fom4.ShowDialog();
        }

        private void fOrmulario5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
