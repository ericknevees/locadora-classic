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
            comando.CommandText = "insert into cliente(id,nome,endereco,whatsapp,CPF,RG)values(@id,@nome,@endereco,@whatsapp,@CPF,@RG)";
            comando.Parameters.AddWithValue("@id", cliente.Id);
            comando.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            comando.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@whatsapp", cliente.Whatsapp));
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
            comando.CommandText = "SELECT * FROM cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString(); 
                cliente.Endereco = reader["endereco"].ToString();                                  
                cliente.Whatsapp = reader["whatsapp"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
               
                clientes.Add(cliente);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;
        }
        public void AtualizarCliente(Cliente cliente)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE cliente SET nome = @nome, endereco = @endereco, whatsapp = @whatsapp, CPF = @CPF, RG = @RG  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", cliente.Id);
            comando.Parameters.AddWithValue("@nome", cliente.Nome);
            comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
            comando.Parameters.AddWithValue("@whatsapp", cliente.Whatsapp);
            comando.Parameters.AddWithValue("@CPF", cliente.CPF);
            comando.Parameters.AddWithValue("@RG", cliente.RG);


            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
        public void ExcluirCliente(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM cliente WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
    }
}
