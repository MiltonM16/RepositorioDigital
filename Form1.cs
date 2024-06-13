
using RepositorioDigital.controller;
using RepositorioDigital.model;

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
            UsersDao us = new UsersDao();
            userModel um = new userModel();
            um.nome = txtNome.Text;
            um.senha = txtsenha.Text;
            um.permissao = txtPemissao.Text;
            um.id = 1;

            us.InserirUsuario(um);
           // us.AtualizarUsuario( um );  
        }
    }
}
