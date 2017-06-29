using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
    public class DALLcliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Modelcliente> Select(int i, Model.Modelcliente Vo) //instrução de select passando parametro de busca
        {

            string sql = "";
            List<Model.Modelcliente> lstCliente = new List<Model.Modelcliente>();
            SqlConnection conexao = new SqlConnection(strCon);

            switch (i)
            {
                case 0:
                    sql = "select * from Cliente;";
                    break;
                case 1:
                    sql = "select * from Cliente where id=" + Vo.id + ";";
                    break;
                case 2:
                    sql = "select * from Cliente where nome Like'%" + Vo.nome + "%';";//filtra pelo que digita
                    break;
            }
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {

                while (reader.Read())
                {
                    Model.Modelcliente cliente = new Model.Modelcliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf_cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);

                }
            }

            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstCliente;//retorna a lista 
        }

        public List<Model.Modelcliente> Select() //instrução de select lista
        {
            List<Model.Modelcliente> lstCliente = new List<Model.Modelcliente>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instancianco nova conexao
            string sql = "select * from Cliente;"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.Modelcliente cliente = new Model.Modelcliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf_cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstCliente;//retorna a lista 
        }

        //pesquisar objeto por código
        public Model.Modelcliente SelectInt(int oPess)
        {
            Model.Modelcliente cliente = new Model.Modelcliente();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente where id = @id ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", oPess);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.cpf_cnpj = reader["cpf_cnpj"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.uf = reader["uf"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.fone = reader["fone"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no Banco" + ex);
            }
            finally
            {
                conexao.Close();
            }
            return cliente;
        }

        public void Insert(Model.Modelcliente cliente)//passando os parametros para inserção
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
                Console.WriteLine("Erro ao inserir Cliente....");
            }
            finally
            {
                conexao.Close();
            }
        }

        //update de um obj
        public void Update(Model.Modelcliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, ";
            sql += "cpf_cnpj=@cpf_cnpj, cidade=@cidade, cep=@cep, endereco=@endereco, uf=@uf, email=@email, fone=@fone "; //aqui não tinha todas informações
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
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
                Console.WriteLine("Erro na atualização de Cliente");
            }
            finally
            {
                conexao.Close();
            }

        }

        //delete em um obj
        public void Delete(Model.Modelcliente oCli)//instrução de deletar um cliente
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", oCli.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Cliente");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}