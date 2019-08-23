using Senai.Sstop.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Sstop.WebApi.Repositories
{
    public class ArtistaRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; Initial Catalog=T_SStop;User Id=sa;Pwd=132;";

        public List<ArtistaDomain> Listar()
        {
            List<ArtistaDomain> artistas = new List<ArtistaDomain>();

            string Query = "select A.IdArtista, A.Nome, E.IdEstilo, E.Nome as NomeEstil from Artistas A inner join Estilos E on A.IdEstilo = E.IdEstilo; ";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    // executar a query 
                    sdr = cmd.ExecuteReader();

                    //percorrer os dados 
                    while(sdr.Read())
                    {
                        ArtistaDomain artista = new ArtistaDomain
                        {
                            IdArtista = Convert.ToInt32(sdr["IdArtista"]),
                            Nome = sdr["Nome"].ToString(),
                            Estilo = new EstiloDomain
                            {
                                IdEstilo = Convert.ToInt32(sdr["IdEstilo"]),
                                Nome = sdr["Nome"].ToString()

                            }
                        };
                        artistas.Add(artista);
                    }
                }
            }
            return artistas;
        }

        public void Cadastrar(ArtistaDomain artistaDomain)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Query = "insert into Artistas (Nome, IdEstilo) values (@Nome, @IdEstilo);";

                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);
                //parametros

                cmd.Parameters.AddWithValue("@Nome", artistaDomain.Nome);
                cmd.Parameters.AddWithValue("@IdEstilo", artistaDomain.EstiloId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
