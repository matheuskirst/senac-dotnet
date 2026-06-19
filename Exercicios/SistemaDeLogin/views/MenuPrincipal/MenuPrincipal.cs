using SistemaDeLogin.utils;

namespace SistemaDeLogin
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(Usuario currentUser)
        {
            InitializeComponent();
            string saudacao = DataHora.Saudacoes();
            string nomeUsuario = currentUser.UserName;
            bemVindoLabel.Text = $"{saudacao}, {nomeUsuario}!";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
