using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP.Camadas.Model;

namespace TrabalhoLP
{
    public partial class FormOs : Form
    {
        private char tipoOper = ' ';
        // private char tipoOper2 = ' ';

        public FormOs()
        {
            InitializeComponent();
        }
        private void Habilitar(bool status)
        {

            txtId.Enabled = status;
            txtidcli.Enabled = status;
            txtidProd.Enabled = status;
            txtNomecli.Enabled = status;
            txtNomeprod.Enabled = status;
            txtDescricao.Enabled = status;
            txtqtd.Enabled = status;
            txtvalor.Enabled = status;
            txtUnit.Enabled = status;

            //botões
            BTNincluir.Enabled = status;
            BTNeditar.Enabled = !status;
            BTNremover.Enabled = !status;
            BTNgravar.Enabled = status;
            BTNremoverp.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtidcli.Text = " ";
            txtNomecli.Text = "";
            txtidProd.Text = "";
            txtNomeprod.Text = "";
            txtvalor.Text = "";
            txtqtd.Text = "";
            txtUnit.Text = "";
            txt_data_ini.Text = "";
            txt_data_final.Text = "";

        }

        private void txtidcli_TextChanged(object sender, EventArgs e) { 
       
            /*
                Camadas.Model.Modelcliente oOr = new Camadas.Model.Modelcliente();
                Camadas.DAL.DALLcliente dallCliente = new Camadas.DAL.DALLcliente();

            
                oOr = dallCliente.SelectInt(Convert.ToInt32(txtidcli.Text));
                txtidcli.Text = oOr.id.ToString();
                txtNomecli.Text = oOr.nome;
                */
            //aqui era o metodo com select  nao usa mais   
            }

        private void txtidProd_TextChanged(object sender, EventArgs e)
        {
            /*
            Camadas.Model.ModelProduto oOr = new Camadas.Model.ModelProduto();
            Camadas.DAL.DALLproduto Produto = new Camadas.DAL.DALLproduto();

            oOr = Produto.SelectInt(Convert.ToInt32(txtidProd.Text));

            txtNomeprod.Text = oOr.nome;
            txtqtd.Text = oOr.qtd.ToString();
            txtUnit.Text = oOr.valor.ToString();
            */

            //aqui era o metodo com select  nao usa mais

        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTNbuscaCli_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();

            frmCli.ShowDialog();
            txtidcli.Text = frmCli.Codigo.ToString();
            txtNomecli.Text = frmCli.Nome.ToString();

        }

        private void txtidcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void BTNbuscaprod_Click(object sender, EventArgs e)
        {
            FormProduto frmprodd = new FormProduto();
            frmprodd.ShowDialog();
            txtidProd.Text = frmprodd.Codigo.ToString();
            txtNomeprod.Text = frmprodd.Nome.ToString();
            txtqtd.Text = "1"; //frmprodd.Qtd.ToString();
            txtUnit.Text = frmprodd.Valor.ToString();

          
        }

        private void txtNomeprod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvOs.CurrentRow;          


            txtidProd.Text = dgvOs.CurrentRow.Cells[0].Value.ToString();
            txtNomeprod.Text = linha.Cells[1].Value.ToString();
            txtUnit.Text = linha.Cells[3].Value.ToString();
            txtqtd.Text = linha.Cells[2].Value.ToString();
           
        }

        private void FormOs_Load(object sender, EventArgs e)
        {
            Habilitar(false);

        }

        private void txtqtd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
              
        }

        private void txtVal_unit_TextChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtidProd.Text == "")
            {
                MessageBox.Show("Informe um Produto! ");
            }
            else
            {
                Camadas.BLL.BLLOs bllOs = new Camadas.BLL.BLLOs();
                Camadas.Model.OsP oOs = new Camadas.Model.OsP();


                oOs.id_prod = Convert.ToInt32(txtidProd.Text);
                oOs.nome_p = txtNomeprod.Text;
                oOs.qtd = Convert.ToInt32(txtqtd.Text);
                oOs.valor_unit = Convert.ToDecimal(txtUnit.Text);


                Camadas.Model.ModelProduto oProd2 = new Camadas.Model.ModelProduto();
                Camadas.DAL.DALLproduto dalProde = new Camadas.DAL.DALLproduto();
                oProd2 = dalProde.SelectInt(oOs.id_prod);

                if (oProd2.qtd < oOs.qtd)

                    MessageBox.Show("Você Não Tem essa Quantidade de Produto Verifique !! ");

                else
                    dgvOs.Rows.Add(new Object[] { oOs.id_prod, oOs.nome_p, oOs.qtd, oOs.valor_unit.ToString("0,0") });//nomes dos txb que quero pegar os dados para adicionar a lista



                decimal valorTotal = 0;

                foreach (DataGridViewRow col in dgvOs.Rows)
                {
                    valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                }

                txtvalor.Text = Convert.ToString(valorTotal);

            }
        }

        public static void moeda(ref TextBox txt)//função para mascara decimal
        {
            String n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;
                txt.Text = String.Format("{0:n}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
           // this.txtUnit.Mask = "00,0000";

          // moeda(ref txtUnit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOs.RowCount <= 0)//verificando lista vazia
            {
                MessageBox.Show("Não há produtos na lista! ");
            }
            else
            {
                dgvOs.Rows.RemoveAt(dgvOs.CurrentRow.Index);//removendo itens selecionado da lista


                decimal valorTotal = 0;

                foreach (DataGridViewRow col in dgvOs.Rows)
                {
                    valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                }

                txtvalor.Text = Convert.ToString(valorTotal);
            }
        }

        private void BTNgravar_Click(object sender, EventArgs e)
        {
            if (txtNomecli.Text == string.Empty)
            {
                DialogResult result1;
                result1 = MessageBox.Show("Preencher Todos os Campos !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Camadas.BLL.BLLOs bllVenda = new Camadas.BLL.BLLOs();
                Camadas.Model.Os oVenda = new Camadas.Model.Os();

                oVenda.idOs = Convert.ToInt32(txtId.Text);
                oVenda.idcli = Convert.ToInt32(txtidcli.Text);
                oVenda.cliente = txtNomecli.Text;
                oVenda.descricao = txtDescricao.Text;
                oVenda.data_ini = Convert.ToDateTime(txt_data_ini.Text);
                oVenda.data_final = Convert.ToDateTime(txt_data_final.Text);
                oVenda.valor = Convert.ToDecimal(txtvalor.Text);
                oVenda.status = cmbStatus.Text;

                List<ModelProduto> listProd = new List<ModelProduto>();

                foreach (DataGridViewRow dt in dgvOs.Rows)
                {

                    Camadas.BLL.BLLProduto bllProduto = new Camadas.BLL.BLLProduto();
                    Camadas.Model.ModelProduto oProd = new Camadas.Model.ModelProduto();

                    oProd.idProduto = Convert.ToInt32(dt.Cells["id"].Value);
                    oProd.nome = dt.Cells["nome"].Value.ToString();
                    oProd.qtd = Convert.ToInt32(dt.Cells["qtd"].Value);
                    oProd.valor = Convert.ToDecimal(dt.Cells["valor_unit"].Value);
                    listProd.Add(oProd);


                    //fim da listagem

                    DialogResult result;
                    string msg = "";
                    if (tipoOper == 'I')
                        msg = "Confirma Inserção ?";
                    else if (tipoOper == 'E')
                        msg = "Confirma Atualização ?";
                    result = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if (tipoOper == 'I')
                            bllVenda.Insert(oVenda, listProd);
                        else if (tipoOper == 'E')
                            bllVenda.Update(oVenda, listProd);
                        MessageBox.Show("Dados Gravados com sucesso", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    limparCampos();
                    dgvOs.Columns.Clear();
                    //tipoOper2 = 'o';
                    // dtgrvOs2.DataSource = bllOVenda.Visualizar();
                }
                
                Habilitar(false);
            }

        }

                    
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //tipoOper2 = 'x';
            txtNomecli.Focus();
            limparCampos();
            Habilitar(true);
            txtId.Text = "-1";
            tipoOper = 'I';
           
            txt_data_ini.Text = Convert.ToString(DateTime.Now);
            txt_data_final.Text = Convert.ToString("01/01/1998 00:00");
            dgvOs.Columns.Clear();


            dgvOs.Columns.Add("id", "id");
            dgvOs.Columns.Add("nome", "Nome_p");
            dgvOs.Columns.Add("qtd", "QTD");             //adiciona as linhas cabeçalho na greed
            dgvOs.Columns.Add("valor_unit", "Valor_Unit");
           
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {
           
           



        }

        private void txtUnit_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUnit.Text == String.Empty || txtqtd.Text == "1")
            {
                txtqtd.Focus();

                Camadas.Model.ModelProduto oOr = new Camadas.Model.ModelProduto();
                Camadas.DAL.DALLproduto Produto = new Camadas.DAL.DALLproduto();

                oOr = Produto.SelectInt(Convert.ToInt32(txtidProd.Text));


                txtUnit.Text = Convert.ToString(oOr.valor);



            }
            else
            {

                decimal soma, qtd, valor;
                soma = 1;
                qtd = 1;
                valor = 1;
                qtd = Convert.ToDecimal(txtqtd.Text);
                valor = Convert.ToDecimal(txtUnit.Text);
                soma = qtd * valor;

                txtUnit.Text = Convert.ToString(soma);





            }
        }

        private void txt_data_ini_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUnit.Text == String.Empty || txtqtd.Text == "1")
            {
                txtqtd.Focus();

                Camadas.Model.ModelProduto oOr = new Camadas.Model.ModelProduto();
                Camadas.DAL.DALLproduto Produto = new Camadas.DAL.DALLproduto();

                oOr = Produto.SelectInt(Convert.ToInt32(txtidProd.Text));


                txtUnit.Text = Convert.ToString(oOr.valor);



            }
            else
            {

                decimal soma, qtd, valor;
                soma = 1;
                qtd = 1;
                valor = 1;
                qtd = Convert.ToDecimal(txtqtd.Text);
                valor = Convert.ToDecimal(txtUnit.Text);
                soma = qtd * valor;

                txtUnit.Text = Convert.ToString(soma);





            }
        }
    }
    }



