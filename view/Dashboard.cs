using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Web.WebView2.WinForms;
using sun.swing;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Word;

namespace RepositorioDigital.view
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

            listarComb();
            listarDados();



            cbAutor.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbCurso.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbTitulo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbSupervisor.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbData.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

        }



        private async void button1_Click(object sender, EventArgs e)
        {



        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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

        public void Filtrar(string filtro)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "SELECT * FROM material WHERE titulo LIKE @filtro OR autor LIKE @filtro OR departamento LIKE @filtro OR curso LIKE @filtro OR filetype LIKE @filtro OR Supervisor LIKE @filtro";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

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
                    dataTable.DataSource = dataSet.Tables["defesas"];

                    // Esconde colunas desnecessárias
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


        public void listarComb()
        {
            cbData.Items.Clear();
            cbAutor.Items.Clear();
            cbCurso.Items.Clear();
            cbSupervisor.Items.Clear();
            cbTitulo.Items.Clear();

            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    connection.Open();

                    string query = "SELECT * FROM material";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        HashSet<string> autores = new HashSet<string>();
                        HashSet<string> cursos = new HashSet<string>();
                        HashSet<string> titulos = new HashSet<string>();
                        HashSet<string> supervisores = new HashSet<string>();
                        HashSet<string> datasPublicacao = new HashSet<string>();

                        while (reader.Read())
                        {
                            autores.Add(reader["Autor"].ToString());
                            cursos.Add(reader["Curso"].ToString());
                            titulos.Add(reader["Titulo"].ToString());
                            supervisores.Add(reader["Supervisor"].ToString());
                            datasPublicacao.Add(reader["DataPublicacao"].ToString());
                        }

                        cbAutor.Items.AddRange(autores.ToArray());
                        cbCurso.Items.AddRange(cursos.ToArray());
                        cbTitulo.Items.AddRange(titulos.ToArray());
                        cbSupervisor.Items.AddRange(supervisores.ToArray());
                        cbData.Items.AddRange(datasPublicacao.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            Filtrar(filtro);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null) return;

            string filtro = comboBox.SelectedItem.ToString();
            string coluna = "";

            if (comboBox == cbAutor)
            {
                coluna = "Autor";
            }
            else if (comboBox == cbCurso)
            {
                coluna = "Curso";
            }
            else if (comboBox == cbTitulo)
            {
                coluna = "Titulo";
            }
            else if (comboBox == cbSupervisor)
            {
                coluna = "Supervisor";
            }
            else if (comboBox == cbData)
            {
                coluna = "DataPublicacao";
            }

            ListarPorFiltro(coluna, filtro);
        }

        private void ListarPorFiltro(string coluna, string filtro)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = $"SELECT * FROM material WHERE {coluna} = @filtro";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filtro", filtro);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    connection.Open();
                    adapter.Fill(dataSet, "defesas");
                    connection.Close();

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

      

    }
}
