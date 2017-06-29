using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.DAL
{
    public class DALLOs
    {
        private string strCon = Conexao.getConexao();

        public DataTable Visualizar()//Mostra dados na GreedVeew
        {
            SqlConnection conexao = new SqlConnection(strCon);//trazendo a conexao do banco
            DataTable dt = new DataTable();
            string sql = "select * from Os ";
            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);//executando sql e trazendo da tabela
            da.Fill(dt);

            return dt;
        }
        
        public DataTable VisualizarP()//Mostra dados na GreedVeew
        {
            SqlConnection con = new SqlConnection(strCon);//trazendo a conexao do banco
            DataTable dt = new DataTable();
            string sql = "select * from OsP ";//where idOrcamento=@idOrcamento ";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//executando sql e trazendo da tabela
            da.Fill(dt);

            return dt;
        }
        
        public List<Model.Os> Selectvo(int i, Model.Os Vo) //instrução de select passando parametro de busca
        {
            string sql = "";
            List<Model.Os> lstVenda = new List<Model.Os>();
            SqlConnection con = new SqlConnection(strCon);
            switch (i)
            {
                case 0:
                    sql = "select * from Os;";
                    break;
                case 1:
                    sql = "select * from Os where idOs=" + Vo.idOs + ";";
                    break;
                case 2:
                    sql = "select * from Os where cliente Like'%" + Vo.cliente + "%';";//filtra pelo que digita
                    break;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {

                while (reader.Read())
                {
                    Model.Os Os = new Model.Os();
                    Os.idOs = Convert.ToInt32(reader["idOs"]);
                    Os.idcli = Convert.ToInt32(reader["idcli"]);
                    Os.cliente = reader["cliente"].ToString();
                    Os.descricao = reader["descricao"].ToString();
                    Os.valor = Convert.ToDecimal(reader["valor"]);
                    Os.data_ini = Convert.ToDateTime(reader["data_ini"]);
                    Os.data_final = Convert.ToDateTime(reader["data_final"]);
                    Os.status = reader["status"].ToString();


                    lstVenda.Add(Os);
                }
            }

            finally
            {
                con.Close();//finaliza a conexao
            }
            return lstVenda;//retorna a lista 
        }
        
        public List<Model.OsP> SelectvoP(int i, Model.OsP Vo) //instrução de select passando parametro de busca
        {
            string sql = "";
            List<Model.OsP> lstVenda = new List<Model.OsP>();
            SqlConnection con = new SqlConnection(strCon);
            switch (i)
            {
                //case 0:
                //    sql = "select * from OrcamentoP;";
                //    break;
                case 1:
                    sql = "select * from OsP where idOs =" + Vo.idOs + ";";
                    break;

            }

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {

                while (reader.Read())
                {
                    Model.OsP oVenda = new Model.OsP();
                    oVenda.idOs = Convert.ToInt32(reader["idOs"]);


                    oVenda.id_prod = Convert.ToInt32(reader["id_prod"]);
                    oVenda.nome_p = reader["nome_p"].ToString();
                    oVenda.qtd = Convert.ToDecimal(reader["qtd"]);
                    oVenda.valor_unit = Convert.ToDecimal(reader["valor_unit"]);

                    lstVenda.Add(oVenda);
                }
            }

            finally
            {
                con.Close();//finaliza a conexao
            }
            return lstVenda;//retorna a lista 
        }
        
        public List<Model.Os> SelectCli(string cliente) //instrução de select lista
        {
            List<Model.Os> lstVenda = new List<Model.Os>(); //criando listas
            SqlConnection con = new SqlConnection(strCon);
            string sql = "select * from Os where (cliente like @cliente); ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cliente", cliente + "%");
            con.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.Os oVenda = new Model.Os();
                    oVenda.idOs = Convert.ToInt32(reader["idOs"]);

                    oVenda.idcli = Convert.ToInt32(reader["idcli"]);
                    oVenda.cliente = reader["cliente"].ToString();
                    oVenda.descricao = reader["descricao"].ToString();
                    oVenda.valor = Convert.ToDecimal(reader["valor"]);
                    oVenda.data_ini = Convert.ToDateTime(reader["data_ini"]);
                    oVenda.data_final = Convert.ToDateTime(reader["data_final"]);
                    oVenda.status = reader["status"].ToString();

                    oVenda.id_prod = Convert.ToInt32(reader["id_prod"]);
                    oVenda.nome_p = reader["nome_p"].ToString();
                    oVenda.qtd = Convert.ToDecimal(reader["qtd"]);
                    oVenda.valor_unit = Convert.ToDecimal(reader["valor_unit"]);

                    lstVenda.Add(oVenda);
                }
            }

            finally
            {
                con.Close();//finaliza a conexao
            }
            return lstVenda;//retorna a lista 
        }

        public List<Model.Os> SelectInt(int idOs) //instrução de select lista
        {
            List<Model.Os> lstVenda = new List<Model.Os>(); //criando listas
            SqlConnection con = new SqlConnection(strCon);
            string sql = "select * from Os where idOs=@idOs; ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idOs", idOs);
            con.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.Os oVenda = new Model.Os();
                    oVenda.idOs = Convert.ToInt32(reader["idOs"]);

                    oVenda.idcli = Convert.ToInt32(reader["idcli"]);
                    oVenda.cliente = reader["cliente"].ToString();
                    oVenda.descricao = reader["descricao"].ToString();
                    oVenda.valor = Convert.ToDecimal(reader["valor"]);
                    oVenda.data_ini = Convert.ToDateTime(reader["data_ini"]);
                    oVenda.data_final = Convert.ToDateTime(reader["data_final"]);
                    oVenda.status = reader["status"].ToString();

                    oVenda.id_prod = Convert.ToInt32(reader["id_prod"]);
                    oVenda.nome_p = reader["nome_p"].ToString();
                    oVenda.qtd = Convert.ToDecimal(reader["qtd"]);
                    oVenda.valor_unit = Convert.ToDecimal(reader["valor_unit"]);

                    lstVenda.Add(oVenda);
                }
            }

            finally
            {
                con.Close();//finaliza a conexao
            }
            return lstVenda;//retorna a lista 
        }

        /*public List<Model.Os> SelectInt(int idOs)
        {
            List<Model.Os> lstVenda = new List<Model.Os>();
            Model.Os oVenda = new Model.Os();
            SqlConnection con = new SqlConnection(strCon);
            string sql = "select * from Os where idOs=@idOs; ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idOs", idOs);
            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    oVenda.idOs = Convert.ToInt32(reader["idOs"]);

                    oVenda.idcli = Convert.ToInt32(reader["idcli"]);
                    oVenda.cliente = reader["cliente"].ToString();
                    oVenda.descricao = reader["descricao"].ToString();
                    oVenda.valor = Convert.ToDecimal(reader["valor"]);
                    oVenda.data_ini = Convert.ToDateTime(reader["data_ini"]);
                    oVenda.data_final = Convert.ToDateTime(reader["data_final"]);
                    oVenda.status = reader["status"].ToString();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no Banco" + ex);
            }
            finally
            {
                con.Close();
            }
            return lstVenda.Add(oVenda);
        }*/

        public Model.Os Select(string oOr)
        {
            Model.Os oVenda = new Model.Os();
            SqlConnection con = new SqlConnection(strCon);
            string sql = "select * from Os where (cliente like @cliente); ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cliente", oOr);
            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    oVenda.idOs = Convert.ToInt32(reader["idOs"]);

                    oVenda.idcli = Convert.ToInt32(reader["idcli"]);
                    oVenda.cliente = reader["cliente"].ToString();
                    oVenda.descricao = reader["descricao"].ToString();
                    oVenda.valor = Convert.ToDecimal(reader["valor"]);
                    oVenda.data_ini = Convert.ToDateTime(reader["data_ini"]);
                    oVenda.data_final = Convert.ToDateTime(reader["data_final"]);
                    oVenda.status = reader["status"].ToString();

                    oVenda.id_prod = Convert.ToInt32(reader["id_prod"]);
                    oVenda.nome_p = reader["nome_p"].ToString();
                    oVenda.qtd = Convert.ToDecimal(reader["qtd"]);
                    oVenda.valor_unit = Convert.ToDecimal(reader["valor_unit"]);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no Banco" + ex);
            }
            finally
            {
                con.Close();
            }
            return oVenda;
        }

        public List<Model.Os> Select2() //instrução de select lista
        {
            List<Model.Os> lstProduto = new List<Model.Os>(); //criando listas
            SqlConnection conexao = new SqlConnection(strCon); //instancianco nova conexao
            string sql = "SELECT OS.idOs, OS.cliente ,OSP.id_prod, OSP.nome_p ,OSP.qtd ,OS.valor,OS.status FROM Os AS OS INNER JOIN OsP AS OSP ON (OS.idOs = OSP.idOs); "; //passando comando select do form
            SqlCommand cmd = new SqlCommand(sql, conexao); //passando comandos sql
            conexao.Open(); //abrindo conexao para setar os dados
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            { //passar os dados identicos a tabela para serem lidos pelo form

                while (reader.Read())//enquanto conseguir ler os dados abaixo
                {
                    Model.Os Os = new Model.Os();
                    Os.idOs = Convert.ToInt32(reader["idOs"]);

                    //Os.idcli = Convert.ToInt32(reader["idcli"]);
                    Os.cliente = reader["cliente"].ToString();
                    //Os.descricao = reader["descricao"].ToString();
                    Os.valor = Convert.ToDecimal(reader["valor"]);
                   // Os.data_ini = Convert.ToDateTime(reader["data_ini"]);
                   // Os.data_final = Convert.ToDateTime(reader["data_final"]);
                    Os.status = reader["status"].ToString();

                    Os.id_prod = Convert.ToInt32(reader["id_prod"]);
                    Os.nome_p = reader["nome_p"].ToString();
                    Os.qtd = Convert.ToDecimal(reader["qtd"]);
                   // Os.valor_unit = Convert.ToDecimal(reader["valor_unit"]);
                    lstProduto.Add(Os);
                }
            }
            finally
            {
                conexao.Close();//finaliza a conexao
            }
            return lstProduto;//retorna a lista 
        }






        public void Insert(Model.Os oOr, List<Model.ModelProduto> lp)
        {

            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "Insert into Os values";
            sql += " (@idcli, @cliente, @descricao, @valor,@data_ini,@data_final, @status);";
            SqlCommand cmd = new SqlCommand(sql, con);


            //cmd.Parameters.AddWithValue("@idLogin", oLogi.idLogin);
            cmd.Parameters.AddWithValue("@idOs", oOr.idOs);
            cmd.Parameters.AddWithValue("@idcli", oOr.idcli);
            cmd.Parameters.AddWithValue("@cliente", oOr.cliente);
            cmd.Parameters.AddWithValue("@descricao", oOr.descricao);
            cmd.Parameters.AddWithValue("@valor", oOr.valor);
            cmd.Parameters.AddWithValue("@data_ini", oOr.data_ini);
            cmd.Parameters.AddWithValue("@data_final", oOr.data_final);
            cmd.Parameters.AddWithValue("@status", oOr.status);



            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir Usuário...." + ex);
            }
            finally
            {
                con.Close();
            }

            //finalizado parte cliente 
            //***********************************************//
            //iniciando busca do codigo do orçamento
            con.Open();
            sql = "Select max(idOs) as idOs from Os;"; //pegando maior  id 
            SqlCommand cm = new SqlCommand(sql, con);

            SqlDataReader reader = cm.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            int idOs = Convert.ToInt32(reader["idOs"]);//pegando id da tebela orcamento
            con.Close();
            //finalizado busca do codigo do orçamento
            //********************************************************//
            //iniciando lista de produtos
            con.Open();

            foreach (Model.ModelProduto p in lp) //enquanto tiver informacao, grava
            {//loop na lista pegando todos os produtos

                sql = "Insert into OsP values";
                sql += " (@idOs, @id_prod, @nome_p, @qtd , @valor_unit);";
                SqlCommand cmde = new SqlCommand(sql, con);

                cmde.Parameters.AddWithValue("@idOs", idOs);   //passando id para tabela orcamentoP         
                cmde.Parameters.AddWithValue("@id_prod", p.idProduto);//oOr.Produto_idProduto);
                cmde.Parameters.AddWithValue("@nome_p", p.nome);
                cmde.Parameters.AddWithValue("@qtd", p.qtd);
                cmde.Parameters.AddWithValue("@valor_unit", p.valor);
                //  cmde.Parameters.AddWithValue("@sub_total", p.qtd * p.preco_unit);
                try
                {
                    cmde.ExecuteNonQuery();
                    if (oOr.status == "Finalizado") // instrução que passa os produtos a serem atualizados na tabela Prod
                    {
                        BLL.BLLProduto OPR = new BLL.BLLProduto();
                        OPR.Update2(p);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Usuário...." + ex);
                }

            }
            con.Close();
        }


        public void Insert2(Model.Os oOr) //atualiza o cabeçalho de pessoa
        {

            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "Update Os set idcli=@idcli,";
            sql += " cliente=@cliente, descricao=@descricao, valor=@valor,data_ini=@data_ini,data_final=@data_final, status=@status";
            sql += " where idOs=@idOs;";
            SqlCommand cmd = new SqlCommand(sql, con);



            cmd.Parameters.AddWithValue("@idOs", oOr.idOs);
            cmd.Parameters.AddWithValue("@idcli", oOr.idcli);
            cmd.Parameters.AddWithValue("@cliente", oOr.cliente);
            cmd.Parameters.AddWithValue("@descricao", oOr.descricao);
            cmd.Parameters.AddWithValue("@valor", oOr.valor);
            cmd.Parameters.AddWithValue("@data_ini", oOr.data_ini);
            cmd.Parameters.AddWithValue("@data_final", oOr.data_final);
            cmd.Parameters.AddWithValue("@status", oOr.status);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir Usuário...." + ex);
            }
            finally
            {
                con.Close();
            }


        }


        public void Update(Model.Os oOr, List<Model.ModelProduto> lp) //atualiza o cabeçalho de produto
        {

            Delete(oOr);   //Delete o objeto no banco pra listar o mesmo objeto com lista nova



            string sql = "";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            foreach (Model.ModelProduto p in lp)
            {//loop na lista pegando todos os produtos

                sql = "Insert into OsP values";
                sql += " (@idOs, @id_prod, @nome, @qtd , @valor_unit);";
                SqlCommand cmde = new SqlCommand(sql, con);

                cmde.Parameters.AddWithValue("@idOs", oOr.idOs);   //passando id para tabela orcamentoP         
                cmde.Parameters.AddWithValue("@id_prod", p.idProduto);
                cmde.Parameters.AddWithValue("@nome_p", p.nome);
                cmde.Parameters.AddWithValue("@qtd", p.qtd);
                cmde.Parameters.AddWithValue("@valor_unit", p.valor);
           
                try
                {
                    cmde.ExecuteNonQuery();
                    if (oOr.status == "Cancelado")
                    {
                        BLL.BLLProduto OPR = new BLL.BLLProduto();
                        OPR.Update3(p);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir Usuário...." + ex);
                }

            }
            con.Close();
            Insert2(oOr);
        }


        public void Delete(Model.Os oOr)//instrução de deletar um cliente
        {
            SqlConnection con = new SqlConnection(strCon);
            string sql = "delete from OsP where idOs=@idOs;";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idOs", oOr.idOs);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Participante");
            }
            finally
            {
                con.Close();
            }
        }

    }
}


