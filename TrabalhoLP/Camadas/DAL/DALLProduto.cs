using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
    

        public class DALLproduto
        {
            private string strCon = Conexao.getConexao();

        public List<Model.ModelProduto> Select(int i, Model.ModelProduto Vo) //instrução de select passando parametro de busca
            {

                string sql = "";
                List<Model.ModelProduto> lstProduto = new List<Model.ModelProduto>();
                SqlConnection conexao = new SqlConnection(strCon);

                switch (i)
                {
                    case 0:
                        sql = "select * from Produto;";
                        break;
                    case 1:
                        sql = "select * from Produto where idProduto =" + Vo.idProduto + ";";
                        break;
                    case 2:
                        sql = "select * from Produto where nome Like'%" + Vo.nome + "%';";//filtra pelo que digita
                        break;
                }
                SqlCommand cmd = new SqlCommand(sql, conexao);
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                try
                {

                    while (reader.Read())
                    {
                        Model.ModelProduto Produto = new Model.ModelProduto();
                        Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                        Produto.nome = reader["nome"].ToString();
                        Produto.descricao = reader["descricao"].ToString();
                        Produto.valor = Convert.ToDecimal(reader["valor"]);
                        Produto.status = reader["status"].ToString();
                        Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                        Produto.qtd = Convert.ToDecimal(reader["qtd"]);
                    lstProduto.Add(Produto);

                    }
                }

                finally
                {
                    conexao.Close();//finaliza a conexao
                }
                return lstProduto;//retorna a lista 
            }

        public Model.ModelProduto Select(int id)
        {
            Model.ModelProduto oProd = new Model.ModelProduto();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto WHERE idProduuto =@idProduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Model.ModelProduto Produto = new Model.ModelProduto();
                    Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    Produto.nome = reader["nome"].ToString();
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToDecimal(reader["valor"]);
                    Produto.status = reader["status"].ToString();
                    Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                    Produto.qtd = Convert.ToDecimal(reader["qtd"]);
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
            return oProd;
        }

        public Model.ModelProduto SelectInt(int oProd)
        {
            Model.ModelProduto Produto = new Model.ModelProduto();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where idProduto = @idProduto ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", oProd);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    Produto.nome = reader["nome"].ToString();
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToDecimal(reader["valor"]);
                    Produto.status = reader["status"].ToString();
                    Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                    Produto.qtd = Convert.ToDecimal(reader["qtd"]);
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
            return Produto;
        }

        public List<Model.ModelProduto> Select() //instrução de select lista
        {
            List<Model.ModelProduto> lstProduto = new List<Model.ModelProduto>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instancianco nova conexao
            string sql = "select * from Produto;"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.ModelProduto Produto = new Model.ModelProduto();
                    Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    Produto.nome = reader["nome"].ToString();
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToDecimal(reader["valor"]);
                    Produto.status = reader["status"].ToString();
                    Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                    Produto.qtd = Convert.ToDecimal(reader["qtd"]);
                    lstProduto.Add(Produto);
                }
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstProduto;//retorna a lista 
        }

        public List<Model.ModelProduto> SelectById(int id) 
        {
            List<Model.ModelProduto> lstProduto = new List<Model.ModelProduto>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instanciancão da nova conexao
            string sql = "select * from Produto where idProduto =@idProduto;"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            cmd.Parameters.AddWithValue("@idProduto", id);
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.ModelProduto Produto = new Model.ModelProduto();

                    Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    Produto.nome = reader["nome"].ToString();
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToDecimal(reader["valor"]);
                    Produto.status = reader["status"].ToString();
                    Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                    Produto.qtd = Convert.ToDecimal(reader["qtd"]);
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto...");
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstProduto;//retorna a lista 
        }

        public List<Model.ModelProduto> SelectByNome(string nome) //instrução de select lista
        {
            List<Model.ModelProduto> lstProduto = new List<Model.ModelProduto>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instanciancão da nova conexao
            string sql = "select * from Produto where (nome like @nome);"; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.ModelProduto Produto = new Model.ModelProduto();

                    Produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    Produto.nome = reader["nome"].ToString();
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToDecimal(reader["valor"]);
                    Produto.status = reader["status"].ToString();
                    Produto.id_fornecedor = Convert.ToInt32(reader["id_fornecedor"]);
                    Produto.qtd = Convert.ToDecimal(reader["qtd"]);
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto...");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }


       public void Insert(Model.ModelProduto Produto)//passando os parametros para inserção
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Insert into Produto values ";
                sql = sql + " (@nome, @descricao, @valor, @status, @id_fornecedor, @qtd);";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", Produto.nome);
                cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
                cmd.Parameters.AddWithValue("@valor", Produto.valor);
                cmd.Parameters.AddWithValue("@status", Produto.status);
                cmd.Parameters.AddWithValue("@id_fornecedor", Produto.id_fornecedor);
                cmd.Parameters.AddWithValue("@qtd", Produto.qtd);

            conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro ao inserir Produto....");
                }
                finally
                {
                    conexao.Close();
                }
            }
            //update de um obj
        public void Update(Model.ModelProduto Produto)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Update Produto set nome=@nome, ";
                sql += "descricao=@descricao, valor=@valor, status=@status,id_fornecedor=@id_fornecedor, qtd=@qtd ";
                sql += " where idProduto=@idProduto;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idProduto", Produto.idProduto);
                cmd.Parameters.AddWithValue("@nome", Produto.nome);
                cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
                cmd.Parameters.AddWithValue("@valor", Produto.valor);
                cmd.Parameters.AddWithValue("@status", Produto.status);
                cmd.Parameters.AddWithValue("@id_fornecedor", Produto.id_fornecedor);
                cmd.Parameters.AddWithValue("@qtd", Produto.qtd);

            conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na atualização de Produto");
                }
                finally
                {
                    conexao.Close();
                }
            }

        public void Update2(Model.ModelProduto oProd) //instrução update obj
        {

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set qtd=qtd-@qtd where idProduto=@idProduto; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", oProd.idProduto);
            cmd.Parameters.AddWithValue("@qtd", oProd.qtd);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update3(Model.ModelProduto oProd) //instrução update obj
        {

            SqlConnection con = new SqlConnection(strCon);
            string sql = "Update Produto set qtd=qtd+@qtd where idProduto=@idProduto;"; //qtd recece ela mesma mais o valor que deseja subtrair
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idProduto", oProd.idProduto);
            cmd.Parameters.AddWithValue("@qtd", oProd.qtd);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização");
            }
            finally
            {
                con.Close();
            }

        }
        //delete em um obj
        public void Delete(Model.ModelProduto oProd)//instrução de deletar um Produto
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "delete from Produto where idProduto=@idProduto;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idProduto", oProd.idProduto);
                conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na remoção de Produto");
                }
                finally
                {
                    conexao.Close();
                }
            }

        } 

     }
   
