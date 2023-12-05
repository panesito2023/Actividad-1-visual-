namespace Actividad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void option_Click(object sender, EventArgs e)
        {
            double sueldo, aum, nsue;
            sueldo = double.Parse(ActSueldo.Text);
            if (sueldo < 400000.00)
            {
                aum = sueldo * 0.15;
                nsue = sueldo + aum;
                NewSueldo.Text = nsue.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ActSueldo.Text= "";
            NewSueldo.Text = "";
        }
    }
}