namespace M01A11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Olá";
            Task.Delay(3000).Wait();
            lblMsg.Text = "tudo bem? ";
            




        }
    }
}
