namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            lblMsg.Text = "Muito prazer em te conhecer, " + name + "!";
            lblMsg.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 