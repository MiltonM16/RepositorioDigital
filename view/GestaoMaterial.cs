using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Media3D;

namespace RepositorioDigital.view
{
    public partial class GestaoMaterial : Form
    {
        public GestaoMaterial()
        {
            InitializeComponent();
            listarDados();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Materiais popup = new Materiais();
            popup.ShowDialog();
        }

        public void listarDados()
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "SELECT * FROM material";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Cria um adaptador de dados para preencher um DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    // Cria um DataSet para armazenar os dados
                    DataSet dataSet = new DataSet();

                    // Abre a conexão
                    connection.Open();

                    // Preenche o DataSet com os dados da tabela de usuários
                    adapter.Fill(dataSet, "defesas");

                    // Fecha a conexão
                    connection.Close();

                    // Define o DataSource do DataGridView como o DataTable do DataSet
                    //tabelaUsers.DataSource = dataSet.Tables["Usuarios"];

                    dataTable.DataSource = dataSet.Tables["defesas"];

                    dataTable.Columns["id"].Visible = false;
                    dataTable.Columns["filedata"].Visible = false;
                    dataTable.Columns["filetype"].Visible = false;
                    dataTable.Columns["TipoMaterial"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex.Message);
            }
        }


        private void GestaoMaterial_Load(object sender, EventArgs e)
        {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow row = dataTable.Rows[e.RowIndex];

                // Extrai os dados da linha
                var id = row.Cells["id"].Value.ToString();
                // var titulo = row.Cells["titulo"].Value.ToString();
                // var autor = row.Cells["autor"].Value.ToString();
                //  var assunto = row.Cells["assunto"].Value.ToString();
                //  var palavrasChave = row.Cells["palavras_chave"].Value.ToString();

                // Cria e exibe o formulário Material com os dados da linha
                //Material popup = new Material(id, titulo, autor, assunto, palavrasChave);
                //popup.ShowDialog();

                update pop = new update(Convert.ToInt16(id));
                pop.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
