using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
  public   class DALLVendedor
    {
        private string strCon = Conexao.getConexao();

        public List<Model.ModelVendedor> Select(int i, Model.ModelVendedor Vo) //instrução de select passando parametro de busca
        {

            string sql = "";
            List<Model.ModelVendedor> lstVendedor = new List<Model.ModelVendedor>();
            SqlConnection conexao = new SqlConnection(strCon);

            switch (i)
            {
                case 0:
                    sql = "select * from Vendedor;";
                    break;
                case 1:
                    sql = "select * from Vendedor where id=" + Vo.id + ";";
                    break;
                case 2:
                    sql = "select * from Vendedor where nome Like'%" + Vo.nome + "%';";//filtra pelo que digita
                    break;
            }
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {

                while (reader.Read())
                {
                    Model.ModelVendedor Vendedor = new Model.ModelVendedor();
                    Vendedor.id = Convert.ToInt32(reader["id"]);
                    Vendedor.nome = reader["nome"].ToString();
                    Vendedor.cpf = reader["cpf"].ToString();
                    Vendedor.cidade = reader["cidade"].ToString();
                    Vendedor.cep = reader["cep"].ToString();
                    Vendedor.endereco = reader["endereco"].ToString();
                    Vendedor.uf = reader["uf"].ToString();
                    Vendedor.email = reader["email"].ToString();
                    Vendedor.fone = reader["fone"].ToString();
                    lstVendedor.Add(Vendedor);

                }
            }

            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstVendedor;//retorna a lista 
        }

        public List<Model.ModelVendedor> Select() //instrução de select lista
        {
            List<Model.ModelVendedor> lstVendedor = new List<Model.ModelVendedor>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instanciancão da nova conexao
            string sql = "select * from Vendedor;"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.ModelVendedor Vendedor = new Model.ModelVendedor();
                    Vendedor.id = Convert.ToInt32(reader["id"]);
                    Vendedor.nome = reader["nome"].ToString();
                    Vendedor.cpf = reader["cpf"].ToString();
                    Vendedor.cidade = reader["cidade"].ToString();
                    Vendedor.cep = reader["cep"].ToString();
                    Vendedor.endereco = reader["endereco"].ToString();
                    Vendedor.uf = reader["uf"].ToString();
                    Vendedor.email = reader["email"].ToString();
                    Vendedor.fone = reader["fone"].ToString();
                    lstVendedor.Add(Vendedor);
                }
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstVendedor;//retorna a lista 
        }

        //pesquisar objeto por código
        public Model.ModelVendedor Select(int id)
        {

            Model.ModelVendedor oForn = new Model.ModelVendedor();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Vendedor WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Model.ModelVendedor Vendedor = new Model.ModelVendedor();
                    Vendedor.id = Convert.ToInt32(reader["id"]);
                    Vendedor.nome = reader["nome"].ToString();
                    Vendedor.cpf = reader["cpf"].ToString();
                    Vendedor.cidade = reader["cidade"].ToString();
                    Vendedor.cep = reader["cep"].ToString();
                    Vendedor.endereco = reader["endereco"].ToString();
                    Vendedor.uf = reader["uf"].ToString();
                    Vendedor.email = reader["email"].ToString();
                    Vendedor.fone = reader["fone"].ToString();
                    
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

        public void Insert(Model.ModelVendedor Vendedor)//passando os parametros para inserção
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendedor values ";
            sql = sql + " (@nome ,@cpf, @cidade, @cep, @endereco, @uf, @email, @fone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", Vendedor.nome);
            cmd.Parameters.AddWithValue("@cpf", Vendedor.cpf);
            cmd.Parameters.AddWithValue("@cidade", Vendedor.cidade);
            cmd.Parameters.AddWithValue("@cep", Vendedor.cep);
            cmd.Parameters.AddWithValue("@endereco", Vendedor.endereco);
            cmd.Parameters.AddWithValue("@uf", Vendedor.uf);
            cmd.Parameters.AddWithValue("@email", Vendedor.email);
            cmd.Parameters.AddWithValue("@fone", Vendedor.fone);

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
        public void Update(Model.ModelVendedor Vendedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Vendedor set nome=@nome, ";
            sql += "cpf=@cpf , cidade=@cidade, cep=@cep, endereco=@endereco, uf=@uf, email=@email, fone=@fone "; //aqui não tinha todas informações
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Vendedor.id);
            cmd.Parameters.AddWithValue("@nome", Vendedor.nome);
            cmd.Parameters.AddWithValue("@cpf", Vendedor.cpf);
            cmd.Parameters.AddWithValue("@cidade", Vendedor.cidade);
            cmd.Parameters.AddWithValue("@cep", Vendedor.cep);
            cmd.Parameters.AddWithValue("@endereco", Vendedor.endereco);
            cmd.Parameters.AddWithValue("@uf", Vendedor.uf);
            cmd.Parameters.AddWithValue("@email", Vendedor.email);
            cmd.Parameters.AddWithValue("@fone", Vendedor.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Vendedor");
            }
            finally
            {
                conexao.Close();
            }
        }

        //delete em um obj
        public void Delete(Model.ModelVendedor oForn)//instrução de deletar um fornecedor
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Vendedor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", oForn.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Vendedor");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


       
    

