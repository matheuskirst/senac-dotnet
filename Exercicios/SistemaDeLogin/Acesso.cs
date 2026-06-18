namespace SistemaDeLogin
{
    internal class Acesso
    {
        public static void EfetuarLogin(string userName, string password)
        {
            if (userName == "admin" && password == "1234")
            {
                MessageBox.Show(
                    $"Fez login com sucesso!\nNome: {userName}\nSenha: {password}",
                    "Login realizado com sucesso.",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                    );
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
    }
}
