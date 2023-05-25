using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {
      

        public void InserirCategoria(Categoria categoria) {
            {
                //Abrir a Conexão
                Conexao.Instance.Open();

                //MySqlCommand
                MySqlCommand comando = Conexao.Instance.CreateCommand();
                //DML - INSERT - DELETE - UPDATE -SELECT
                //STORED PROCEDURES
                //ADO.NET - biblioteca de banco de dados do .NET
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Categoria(Nome,Valor_da_diaria)values(@Nome,@Valor_da_Diaria)";
                comando.Parameters.Add(new MySqlParameter("@Nome", categoria.Nome));
                comando.Parameters.Add(new MySqlParameter("@Valor_da_Diaria", categoria.Valor_diaria));
                comando.ExecuteNonQuery();
                Conexao.Instance.Close();

            }


        }
        public List<Categoria> ObterCategoria()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Categoria";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Nome = reader["nome"].ToString();
                categoria.Valor_diaria = reader["Valor_da_Diaria"].ToString();


                categorias.Add(categoria);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return categorias;
        }
    }   }
