using MySql.Data.MySqlClient;
using RepositorioDigital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string query = "INSERT INTO Material (Titulo, Autor, Resumo, DataPublicacao, TipoMaterial, Curso, Departamento, Supervisor) " +
                                   "VALUES (@Titulo, @Autor, @Resumo, @DataPublicacao, @TipoMaterial, @Curso, @Departamento, @Supervisor)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Titulo", material.Titulo);
                    command.Parameters.AddWithValue("@Autor", material.Autor);
                    command.Parameters.AddWithValue("@Resumo", material.Resumo);
                    command.Parameters.AddWithValue("@DataPublicacao", material.DataPublicacao);
                    command.Parameters.AddWithValue("@TipoMaterial", material.TipoMaterial);
                    command.Parameters.AddWithValue("@Curso", material.Curso);
                    command.Parameters.AddWithValue("@Departamento", material.Departamento);
                    command.Parameters.AddWithValue("@Supervisor", material.Supervisor);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material inserido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex);
            }
        }

        public void AtualizarMaterial(materialModel material)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "UPDATE Material SET Titulo = @Titulo, Autor = @Autor, Resumo = @Resumo, DataPublicacao = @DataPublicacao, " +
                                   "TipoMaterial = @TipoMaterial, Curso = @Curso, Departamento = @Departamento, Supervisor = @Supervisor WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Titulo", material.Titulo);
                    command.Parameters.AddWithValue("@Autor", material.Autor);
                    command.Parameters.AddWithValue("@Resumo", material.Resumo);
                    command.Parameters.AddWithValue("@DataPublicacao", material.DataPublicacao);
                    command.Parameters.AddWithValue("@TipoMaterial", material.TipoMaterial);
                    command.Parameters.AddWithValue("@Curso", material.Curso);
                    command.Parameters.AddWithValue("@Departamento", material.Departamento);
                    command.Parameters.AddWithValue("@Supervisor", material.Supervisor);
                    command.Parameters.AddWithValue("@Id", material.id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material atualizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro: " + ex);
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
                MessageBox.Show("Algum erro: " + ex);
            }
        }


    }
}
