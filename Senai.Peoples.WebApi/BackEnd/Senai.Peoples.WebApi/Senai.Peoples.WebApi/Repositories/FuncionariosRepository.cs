using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class FuncionariosRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; Initial Catalog=T_Peoples;User Id=sa;Pwd=132";

        public List<FuncionariosDomain> Listar()
        {
            List<FuncionariosDomain> funcionarios = new List<FuncionariosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {

                string Query = "select IdFuncionario, Nome, Sobrenome from Funcionarios";

                con.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain()
                        {
                            IdFuncionario = Convert.ToInt32(sdr["IdFuncionario"]),
                            Nome = sdr["Nome"].ToString(),
                            Sobrenome = sdr["Sobrenome"].ToString()
                        };
                        funcionarios.Add(funcionario);
                    }
                }

            }
            return funcionarios;
        }

        public FuncionariosDomain BuscarPorId(int id)
        {
            string Query = "select IdFuncionario, Nome, Sobrenome from Funcionarios where IdFuncionario = @IdFuncionario";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@IdFuncionario", id);
                    sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            FuncionariosDomain funcionarios = new FuncionariosDomain
                            {
                                IdFuncionario = Convert.ToInt32(sdr["IdFuncionario"]),
                                Nome = sdr["Nome"].ToString(),
                                Sobrenome = sdr["Sobrenome"].ToString()
                            };
                            return funcionarios;
                        }
                    }
                    return null;
                }
            }
        }

        public void Cadastrar (FuncionariosDomain funcionariosDomain)
        {
            string Query = "insert into Funcionarios (Nome, Sobrenome) values (@Nome, @Sobrenome)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Nome", funcionariosDomain.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", funcionariosDomain.Sobrenome);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar (int id)
        {
            string Query = "delete from Funcionarios where IdFuncionario= @id";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }       

        public void Atualizar (FuncionariosDomain funcionariosDomain )
        {
            string Query = "update Funcionarios set Nome = @Nome, Sobrenome = @Sobrenome where IdFuncionario = @id";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@id", funcionariosDomain.IdFuncionario);
                cmd.Parameters.AddWithValue("@Nome", funcionariosDomain.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", funcionariosDomain.Sobrenome);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
