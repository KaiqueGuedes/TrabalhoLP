using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {     
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf/cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        /*public List<Model.Cliente> SelectById(int id)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {    
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf/cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {    
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf/cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }*/

        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values ";
            sql = sql + " (@nome ,@cpf_cnpj, @cidade, @cep, @endereco, @uf, @email, @fone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }

        /*public void Update(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update cliente set nome=@nome, endereco=@endereco, ";
            sql += "cidade=@cidade, estado=@estado, fone=@fone ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }*/
    }
}
