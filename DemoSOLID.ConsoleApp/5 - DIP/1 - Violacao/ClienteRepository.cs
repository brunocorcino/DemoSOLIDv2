using System.Data;
using System.Data.SqlClient;

namespace DemoSOLID.ConsoleApp.DIP.Violacao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConexaoTeste";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Cliente (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCadastro)";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("dataCadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
