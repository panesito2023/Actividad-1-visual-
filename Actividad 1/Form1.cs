namespace Actividad_1
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

        private void desicion_Click(object sender, EventArgs e)
        {
            double Cal;
            Cal = double.Parse(cal.Text);
            if (Cal <= 3.0){
                MessageBox.Show(" Reprobado");
            }else{
                MessageBox.Show(" Aprobado");
            }
        }
    }
}