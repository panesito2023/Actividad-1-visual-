namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Desicion_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3; 
            lado1 = double.Parse(LadoA.Text); 
            lado2 = double.Parse(LadoB.Text); 
            lado3 = double.Parse(LadoC.Text); 
            if ((lado1 == lado2) && (lado2 == lado3)) Triangulo.Text = "Equilatero"; 
            else if((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
                Triangulo.Text = "Isosceles"; 
            else Triangulo.Text = "Escaleno";
        }
    }
}