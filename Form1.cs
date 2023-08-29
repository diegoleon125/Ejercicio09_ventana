namespace Ejercicio09_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtnum1.Text);
            int n2 = int.Parse(txtnum2.Text);
            int n3 = int.Parse(txtnum3.Text);
            if (n1 > n2 && n1 > n3)
            {
                lblResult.Text = "El mayor es el " + n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                lblResult.Text = "El mayor es el " + n2;
            }
            else if (n3 > n1 && n3 > n2)
            {
                lblResult.Text = "El mayor es el " + n3;
            }
        }
    }
}