namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comprobar_Click(object sender, EventArgs e)
        {
            double Cal1, Cal2, Cal3, Cal4; 
            Cal1 = double.Parse(Cam1.Text);
            Cal2 = double.Parse(Cam2.Text);
            Cal3 = double.Parse(Cam3.Text);
            Cal4 = double.Parse(Cam4.Text);
            double prom = Cal1 + Cal2 + Cal3 + Cal4 / 4;

            if ((Cal1 >= 6) && (Cal2 >= 6) && (Cal3 >= 6) && (Cal4 >= 6) && (prom >= 6))
            MessageBox.Show(" Felicidades Aprobaste");
            else {
            MessageBox.Show(" Suerte Para la Proxima Reprobaste");
            }

        }
    }
}