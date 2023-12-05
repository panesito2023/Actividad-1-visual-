namespace Actividad_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orden_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = int.Parse(Num1.Text); 
            B = int.Parse(Num2.Text); 
            C = int.Parse(Num3.Text);
            if (A > B) if (B > C) if (B > C) { NumA.Text = A.ToString(); NumB.Text = B.ToString(); NumC.Text = C.ToString(); } 
            else { NumA.Text = A.ToString(); NumB.Text = C.ToString(); NumC.Text = B.ToString(); } 
            else { NumA.Text = C.ToString(); NumB.Text = A.ToString(); NumC.Text = B.ToString(); }
            else if(B > C) 
            if (A > C) {NumA.Text = B.ToString(); NumB.Text = A.ToString(); NumC.Text = C.ToString(); } 
            else { NumA.Text = B.ToString(); NumB.Text = C.ToString(); NumC.Text = A.ToString(); }
            else { NumA.Text = C.ToString(); NumB.Text = B.ToString(); NumC.Text = A.ToString(); }

        }
    }
}