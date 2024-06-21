
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

                // Aqui voc� pode abrir o formul�rio principal do seu sistema e passar os dados do usu�rio
                var mainForm = new dash(usuario); // Passa o usu�rio para o formul�rio principal
                mainForm.Show();
                this.Hide(); // Opcional: Esconder o formul�rio de login
            }
            else
            {
                MessageBox.Show("Nome de usu�rio ou senha incorretos.");
            }
        }
    }
}
