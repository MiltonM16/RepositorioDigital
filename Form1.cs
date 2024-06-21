
using RepositorioDigital.controller;
using RepositorioDigital.model;
using RepositorioDigital.view;

namespace RepositorioDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtsenha.Text;

            UsersDao usuarioDao = new UsersDao();
            userModel usuario = usuarioDao.VerificarCredenciais(nome, senha);

            if (usuario != null)
            {
                MessageBox.Show($"Login bem-sucedido! Bem-vindo, {usuario.Nome}.");

                // Aqui você pode abrir o formulário principal do seu sistema e passar os dados do usuário
                var mainForm = new dash(usuario); // Passa o usuário para o formulário principal
                mainForm.Show();
                this.Hide(); // Opcional: Esconder o formulário de login
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.");
            }
        }
    }
}
