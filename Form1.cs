
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
         

        }
    }
}
