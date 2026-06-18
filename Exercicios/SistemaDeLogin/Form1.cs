namespace SistemaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Acesso.EfetuarLogin(userNameBox.Text, passwordBox.Text);
        }
    }
}
