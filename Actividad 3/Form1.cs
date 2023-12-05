namespace Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double sueldo,nsue;
            sueldo = double.Parse(ActSueldo.Text);
            if (sueldo < 400000.00) nsue = sueldo * 1.15; else nsue = sueldo * 1.08;
            NewSueldo.Text = nsue.ToString("0.##");
        }
    }
}