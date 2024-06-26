using MySql.Data.MySqlClient;
using RepositorioDigital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositorioDigital.controller
{
    internal class UsersDao
    {
        public void InserirUsuario(userModel usuario)
        {
            try
            {



                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "INSERT INTO user (nome,senha, permissao) " +
                                   "VALUES (@Nome, @Senha, @Permissao)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nome", usuario.nome);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);
                    command.Parameters.AddWithValue("@Permissao", usuario.permissao);


                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("inserido com sucesso");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("algume erro:" + ex);

            }

        }

        public void AtualizarUsuario(userModel usuario)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "UPDATE user SET nome = @Nome, senha = @Senha, permissao = @Permissao WHERE id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nome", usuario.nome);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);
                    command.Parameters.AddWithValue("@Permissao", usuario.permissao);
                    command.Parameters.AddWithValue("@Id", usuario.id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("atualizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("algume erro:" + ex);
            }
        }

        public userModel ObterUsuarioPorId(int id)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "SELECT id, nome, senha, permissao FROM user WHERE id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new userModel
                            {
                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                senha = reader.GetString("senha"),
                                permissao = reader.GetString("permissao")
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("algume erro:" + ex);
                return null;
            }
        }

        public void DeletarUsuario(int id)
        {
            try
            {
                using (var connection = controller.ConexaoDB.ObterConexao())
                {
                    string query = "DELETE FROM user WHERE id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("deletado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("algume erro:" + ex);
            }
        }

      

    }
}
