namespace ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            float num = 0;
            float.TryParse(txtNum.Text, out num);
            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);
            lblMsg1.Text = $"Você digitou o valor {num:N}";
            lblMsg2.Text = $"A parte inteira, temos {n2:D}";
            lblMsg3.Text = $" Arredondando, temos {n2:D}";
            panResultado.Visible = true;
        }
    }
}
