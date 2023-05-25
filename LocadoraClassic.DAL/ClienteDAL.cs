using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {

        public void InserirCliente(Cliente cliente)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE -SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into cliente(Nome,Endereço,Whatsapp,CPF,RG)values(@Nome,@Endereço,@Whatsapp,@CPF,@RG)";
            comando.Parameters.Add(new MySqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new MySqlParameter("@Endereço", cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@Whatsapp", cliente.Whatsapp));
            comando.Parameters.Add(new MySqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new MySqlParameter("@RG", cliente.RG));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();

        }
        public List<Cliente> ObterCliente()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = reader["nome"].ToString(); 
                cliente.Endereco = reader["nome"].ToString();                                  
                cliente.Whatsapp = reader["nome"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
               
                clientes.Add(cliente);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;
        }
    }
}
