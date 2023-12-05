using System.Diagnostics.CodeAnalysis;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);
            if (edad > 0 && edad < 11) MessageBox.Show("Eres un Niño");
            else if (edad > 12 && edad < 17) MessageBox.Show("Eres un Adolescente");
            else if (edad > 18 && edad < 60) MessageBox.Show("Eres un Adulto");
            else if (edad >= 60) MessageBox.Show("Eres un Adulto Mayor");
        }
    }
}