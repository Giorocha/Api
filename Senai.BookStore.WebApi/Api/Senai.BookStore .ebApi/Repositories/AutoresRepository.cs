using Senai.BookStore.ebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.BookStore.ebApi.Repositories
{
    public class AutoresRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; Initial Catalog=T_BookStore;User Id=sa;Pwd=132";

        public void Cadastrar(AutoresDomain autoresDomain)
        {
            string Query = "insert into Autores (Nome, Email, Ativo, DataNascimento) values (@Nome, @Email, @Ativo, @DataNascimento)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Nome", autoresDomain.Nome);
                cmd.Parameters.AddWithValue("@Email", autoresDomain.Email);
                cmd.Parameters.AddWithValue("@Ativo", autoresDomain.Ativo);
                cmd.Parameters.AddWithValue("@DataNascimento", autoresDomain.DataNascimento);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}
