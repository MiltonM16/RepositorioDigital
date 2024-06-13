using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositorioDigital.view
{
    public partial class dash : Form
    {
        public dash()
        {
            InitializeComponent();
        }

        public void AbrirTela(Form tela)
        {
            // Remove qualquer controle atual dentro do painel
            mainPanel.Controls.Clear();

            // Define a tela como filho do painel
            tela.TopLevel = false;
            tela.AutoScroll = true;
            mainPanel.Controls.Add(tela);
            tela.Dock = DockStyle.Fill;
            tela.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dash_Load(object sender, EventArgs e)
        {

        }

        private void mainDash_Click(object sender, EventArgs e)
        {
            AbrirTela(new Dashboard());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirTela(new Materiais());
            //Materiais popup = new Materiais();
            //popup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
