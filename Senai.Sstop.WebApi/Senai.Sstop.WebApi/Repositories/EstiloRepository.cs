using Senai.Sstop.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Sstop.WebApi.Repositories
{
    public class EstiloRepository
    {

        // aonde que sera feita essa comunicação 
        private string StringConexao = "Data Source=.\\SqlExpress; Initial Catalog=T_SStop;User Id=sa;Pwd=132;";

        public List<EstiloDomain> Listar()
        {
            List<EstiloDomain> estilos = new List<EstiloDomain>();

            // chamar o banco 
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Query = "SELECT IdEstilo, Nome FROM Estilos";
                // abrir a conexão 
                con.Open();

                // declaro para percorrer a lista
                SqlDataReader sdr;

                // comando a ser executado em qual conexão
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    // pegar os valores da tabela do banco e armazenar dentro da aplicação do backend 
                    sdr = cmd.ExecuteReader();

                    while(sdr.Read())
                    {
                        EstiloDomain estilo = new EstiloDomain
                        {
                            IdEstilo = Convert.ToInt32(sdr["IdEstilo"]),
                            Nome = sdr["Nome"].ToString()
                        };
                        estilos.Add(estilo);
                    }                         
                }
            }
            return estilos;
        }

        // criar um metodo que acesse o banco de dados e bsuque o estilo musical desejado
        public EstiloDomain BuscarPorId(int id)
        {
            string Query = "SELECT IdEstilo, Nome FROM Estilos WHERE IdEstilo = @IdEstilo";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@IdEstilo", id);
                    sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        while(sdr.Read())
                        {
                            EstiloDomain estilo = new EstiloDomain
                            {
                                IdEstilo = Convert.ToInt32(sdr["IdEstilo"]),
                                Nome = sdr["Nome"].ToString()
                            };

                        return estilo;
                        }
                    }
                    return null;
                }
            }

        }
    
        //cadastrar um estilo musical 
        public void Cadastrar(EstiloDomain estiloDomain)
        {
            string Query = "INSERT INTO Estilos (Nome) VALUES (@Nome)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Nome", estiloDomain.Nome);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //deletar um estilo musical
        public void Deletar(int id)
        {
            string Query = "DELETE FROM Estilos WHERE IdEstilo = @Id";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //atualizar
        public void Atualizar(EstiloDomain estiloDomain)
        {
            string Query = "UPDATE Estilos SET Nome = @Nome WHERE IdEstilo = @Id";
            // estabelecer a conexao
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // comando 
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Nome", estiloDomain.Nome);
                cmd.Parameters.AddWithValue("@Id", estiloDomain.IdEstilo);

                // abrir a conexao
                con.Open();

                // executar
                cmd.ExecuteNonQuery();
            }
        }

    }
}
