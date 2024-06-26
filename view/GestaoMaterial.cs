using MySql.Data.MySqlClient;
using RepositorioDigital.controller;
using RepositorioDigital.model;
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


            DataGridViewButtonColumn visualizarButtonColumn = new DataGridViewButtonColumn();
            visualizarButtonColumn.Name = "visualizar";
            visualizarButtonColumn.HeaderText = "Visualizar";
            visualizarButtonColumn.Text = "Visualizar";
            visualizarButtonColumn.UseColumnTextForButtonValue = true;
            this.dataTable.Columns.Add(visualizarButtonColumn);

            DataGridViewButtonColumn baixarButtonColumn = new DataGridViewButtonColumn();
            baixarButtonColumn.Name = "baixar";
            baixarButtonColumn.HeaderText = "Baixar";
            baixarButtonColumn.Text = "Baixar";
            baixarButtonColumn.UseColumnTextForButtonValue = true;
            this.dataTable.Columns.Add(baixarButtonColumn);



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


                var id = row.Cells["id"].Value.ToString();

                // Verifica se a coluna clicada é uma DataGridViewButtonColumn e qual botão foi clicado
                if (dataTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    (dataTable.Columns[e.ColumnIndex].Name.Equals("visualizar") ||
                     dataTable.Columns[e.ColumnIndex].Name.Equals("baixar")))
                {
                    int ids = Convert.ToInt32(row.Cells["id"].Value);

                    // Verifica se o botão "Visualizar" foi clicado
                    if (dataTable.Columns[e.ColumnIndex].Name.Equals("visualizar"))
                    {
                        VisualizarMaterial(ids);
                    }
                    // Verifica se o botão "Baixar" foi clicado
                    else if (dataTable.Columns[e.ColumnIndex].Name.Equals("baixar"))
                    {
                        BaixarMaterial(ids);
                    }
                }
                else {
                    update pop = new update(Convert.ToInt16(id));
                    pop.ShowDialog();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarMaterial(int id)
        {
            MaterialDao materialDao = new MaterialDao();
            materialModel material = materialDao.ObterMaterialPorId(id);

            if (material != null && material.filedata != null)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), material.filename);
                File.WriteAllBytes(tempFilePath, material.filedata);

                // Abrir o arquivo com o programa padrão do sistema
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = tempFilePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.");
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
        



        private void BaixarMaterial(int id)
        {
            MaterialDao materialDao = new MaterialDao();
            materialModel material = materialDao.ObterMaterialPorId(id);

            if (material != null && material.filedata != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = material.filename;
                    saveFileDialog.Filter = "Todos os arquivos (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, material.filedata);
                        MessageBox.Show("Arquivo baixado com sucesso.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtrar(textBox1.Text);
        }
    }
}
