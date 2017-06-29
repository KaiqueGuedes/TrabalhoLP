using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
    public class DALLfornecedor
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Modelfornecedor> Select(int i, Model.Modelfornecedor Vo) //instrução de select passando parametro de busca
        {

            string sql = "";
            List<Model.Modelfornecedor> lstFornecedor = new List<Model.Modelfornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);

            switch (i)
            {
                case 0:
                    sql = "select * from Fornecedor;";
                    break;
                case 1:
                    sql = "select * from Fornecedor where id=" + Vo.id + ";";
                    break;
                case 2:
                    sql = "select * from Fornecedor where nome Like'%" + Vo.nome + "%';";//filtra pelo que digita
                    break;
            }
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {

                while (reader.Read())
                {
                    Model.Modelfornecedor fornecedor = new Model.Modelfornecedor();
                    fornecedor.id = Convert.ToInt32(reader["id"]);
                    fornecedor.nome = reader["nome"].ToString();
                    fornecedor.cpf_cnpj = reader["cpf_cnpj"].ToString();
                    fornecedor.cidade = reader["cidade"].ToString();
                    fornecedor.cep = reader["cep"].ToString();
                    fornecedor.endereco = reader["endereco"].ToString();
                    fornecedor.uf = reader["uf"].ToString();
                    fornecedor.email = reader["email"].ToString();
                    fornecedor.fone = reader["fone"].ToString();
                    lstFornecedor.Add(fornecedor);

                }
            }

            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstFornecedor;//retorna a lista 
        }

        public List<Model.Modelfornecedor> Select() //instrução de select lista
        {
            List<Model.Modelfornecedor> lstFornecedor = new List<Model.Modelfornecedor>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instanciancão da nova conexao
            string sql = "select * from Fornecedor;"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.Modelfornecedor fornecedor = new Model.Modelfornecedor();
                    fornecedor.id = Convert.ToInt32(reader["id"]);
                    fornecedor.nome = reader["nome"].ToString();
                    fornecedor.cpf_cnpj = reader["cpf_cnpj"].ToString();
                    fornecedor.cidade = reader["cidade"].ToString();
                    fornecedor.cep = reader["cep"].ToString();
                    fornecedor.endereco = reader["endereco"].ToString();
                    fornecedor.uf = reader["uf"].ToString();
                    fornecedor.email = reader["email"].ToString();
                    fornecedor.fone = reader["fone"].ToString();
                    lstFornecedor.Add(fornecedor);
                }
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstFornecedor;//retorna a lista 
        }

        //pesquisar objeto por código
        public Model.Modelfornecedor Select(int id)
        {

            Model.Modelfornecedor oForn = new Model.Modelfornecedor();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fornecedor WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Model.Modelfornecedor fornecedor = new Model.Modelfornecedor();
                    fornecedor.id = Convert.ToInt32(reader["id"]);
                    fornecedor.nome = reader["nome"].ToString();
                    fornecedor.cpf_cnpj = reader["cpf/cnpj"].ToString();
                    fornecedor.cidade = reader["cidade"].ToString();
                    fornecedor.cep = reader["cep"].ToString();
                    fornecedor.endereco = reader["endereco"].ToString();
                    fornecedor.uf = reader["uf"].ToString();
                    fornecedor.email = reader["email"].ToString();
                    fornecedor.fone = reader["fone"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao selecionar Codigo...");
            }
            finally
            {
                conexao.Close();
            }
            return oForn;
        }

        public void Insert(Model.Modelfornecedor fornecedor)//passando os parametros para inserção
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Fornecedor values ";
            sql = sql + " (@nome ,@cpf_cnpj, @cidade, @cep, @endereco, @uf, @email, @fone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("@cpf_cnpj", fornecedor.cpf_cnpj);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@cep", fornecedor.cep);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@uf", fornecedor.uf);
            cmd.Parameters.AddWithValue("@email", fornecedor.email);
            cmd.Parameters.AddWithValue("@fone", fornecedor.fone);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir Fornecedor....");
            }
            finally
            {
                conexao.Close();
            }
        }

        //update de um obj
        public void Update(Model.Modelfornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Fornecedor set nome=@nome, ";
            sql += "cpf_cnpj=@cpf_cnpj, cidade=@cidade, cep=@cep, endereco=@endereco, uf=@uf, email=@email, fone=@fone "; //aqui não tinha todas informações
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", fornecedor.id);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("@cpf_cnpj", fornecedor.cpf_cnpj);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@cep", fornecedor.cep);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@uf", fornecedor.uf);
            cmd.Parameters.AddWithValue("@email", fornecedor.email);
            cmd.Parameters.AddWithValue("@fone", fornecedor.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Fornecedor");
            }
            finally
            {
                conexao.Close();
            }
        }

        //delete em um obj
        public void Delete(Model.Modelfornecedor oForn)//instrução de deletar um fornecedor
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Fornecedor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", oForn.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Fornecedor");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
