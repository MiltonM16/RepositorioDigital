using MySql.Data.MySqlClient;
using RepositorioDigital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositorioDigital.controller
{
    internal class MaterialDao
    {
        public void InserirMaterial(materialModel material)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "INSERT INTO Material (Titulo, Autor, Resumo, DataPublicacao, TipoMaterial, Curso, Departamento, Supervisor, filedata, filename, filetype) " +
                                   "VALUES (@Titulo, @Autor, @Resumo, now(), @TipoMaterial, @Curso, @Departamento, @Supervisor, @filedata, @filename, @filetype)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Titulo", material.Titulo);
                    command.Parameters.AddWithValue("@Autor", material.Autor);
                    command.Parameters.AddWithValue("@Resumo", material.Resumo);
                    command.Parameters.AddWithValue("@DataPublicacao", material.DataPublicacao);
                    command.Parameters.AddWithValue("@TipoMaterial", material.TipoMaterial);
                    command.Parameters.AddWithValue("@Curso", material.Curso);
                    command.Parameters.AddWithValue("@Departamento", material.Departamento);
                    command.Parameters.AddWithValue("@Supervisor", material.Supervisor);
                    command.Parameters.AddWithValue("@filedata", material.filedata);
                    command.Parameters.AddWithValue("@filename", material.filename);
                    command.Parameters.AddWithValue("@filetype", material.filetype);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material inserido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex.Message);
            }
        }

        public void AtualizarMaterial(materialModel material)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "UPDATE Material SET Titulo = @Titulo, Autor = @Autor, Resumo = @Resumo, DataPublicacao = @DataPublicacao, " +
                                   "TipoMaterial = @TipoMaterial, Curso = @Curso, Departamento = @Departamento, Supervisor = @Supervisor, " +
                                   "filedata = @filedata, filename = @filename, filetype = @filetype WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Titulo", material.Titulo);
                    command.Parameters.AddWithValue("@Autor", material.Autor);
                    command.Parameters.AddWithValue("@Resumo", material.Resumo);
                    command.Parameters.AddWithValue("@DataPublicacao", material.DataPublicacao);
                    command.Parameters.AddWithValue("@TipoMaterial", material.TipoMaterial);
                    command.Parameters.AddWithValue("@Curso", material.Curso);
                    command.Parameters.AddWithValue("@Departamento", material.Departamento);
                    command.Parameters.AddWithValue("@Supervisor", material.Supervisor);
                    command.Parameters.AddWithValue("@filedata", material.filedata);
                    command.Parameters.AddWithValue("@filename", material.filename);
                    command.Parameters.AddWithValue("@filetype", material.filetype);
                    command.Parameters.AddWithValue("@Id", material.id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material atualizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex.Message);
            }
        }

        public void DeletarMaterial(int id)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "DELETE FROM Material WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material deletado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex.Message);
            }
        }
    }
}
