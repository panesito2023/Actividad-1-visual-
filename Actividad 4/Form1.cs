namespace Actividad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determinar_Click(object sender, EventArgs e)
        {
            int num1; 
            num1 = int.Parse(num.Text); if (num1 % 2 == 0) 
                MessageBox.Show(" EL NUMERO ES PAR"); else if(num1 % 3 == 0)   
                MessageBox.Show(" EL NUMERO ES IMPAR Y ES DIVISIBLE POR 3"); 
            else MessageBox.Show("EL NUMERO ES IMPAR Y ES NO ES DIVISIBLE POR 3");
        }
    }
}