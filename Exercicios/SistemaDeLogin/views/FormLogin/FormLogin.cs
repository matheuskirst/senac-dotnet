namespace SistemaDeLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            DisableButtonLogin(this, EventArgs.Empty);
            userNameBox.TextChanged += DisableButtonLogin;
            passwordBox.TextChanged += DisableButtonLogin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;

            if (userName == "admin" && password == "1234")
            {
                this.Hide();
                var currentUser = new Usuario(userName, password);
                new MenuPrincipal(currentUser).Show();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou a senha estão incorretos!",
                    "Erro ao fazer o login.",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void DisableButtonLogin(object sender, EventArgs e)
        {
            if (userNameBox.Text == "" || passwordBox.Text == "")
            {
                buttonLogin.Enabled = false;
            }
            else
            {
                buttonLogin.Enabled = true;
            }
        }
    }
}
