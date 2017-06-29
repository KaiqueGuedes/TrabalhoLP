using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP
{
    public partial class FormProduto : Form
    {
        public int Codigo { get; set; } // variaveis para passar os valores que quero para a tela OS 
        public String Nome { get; set; } //pega o valor dos produtos e passa na tela da os 
        public Decimal Qtd { get; set; }
        public Decimal Valor { get; set; }

        private void Habilitar(bool status)
        {

            txtid.Enabled = status;
            txtnome.Enabled = status;
            txtdescricao.Enabled = status;
            txtvalor.Enabled = status;
            txtstatus.Enabled = status;
            txtfornecedor.Enabled = status;
            txtQtd.Enabled = status;

            //botões
            btninserir.Enabled = !status;
            btneditar.Enabled = !status;
            btnremover.Enabled = !status;
            btngravar.Enabled = status;
            btncancelar.Enabled = status;
        }

        private void limparCampos()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtdescricao.Text = "";
            txtvalor.Text = "";
            txtstatus.Text = "";
            txtfornecedor.Text = "";
            txtQtd.Text = "";

        }
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.BLLProduto bllProduto = new Camadas.BLL.BLLProduto();
            Camadas.Model.ModelProduto produto = new Camadas.Model.ModelProduto();
            dgvproduto.DataSource = bllProduto.Select();
            Habilitar(false);

            pnlPesquisa.Visible = false;
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtid.Text = "-1";
            Habilitar(true);
            txtnome.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != string.Empty)
            {
                Habilitar(true);
                txtid.Enabled = false;
                txtnome.Focus();
            }
            else MessageBox.Show("Não há registro para ser editado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }

        private void btnremover_Click(object sender, EventArgs e)
        {
            string msg;
            if (txtid.Text != string.Empty)
            {
                msg = "Confirma Remoção do Fornecedor " + txtnome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtid.Text);
                    Camadas.BLL.BLLProduto bllProduto = new Camadas.BLL.BLLProduto();
                    Camadas.Model.ModelProduto produto = new Camadas.Model.ModelProduto();
                    produto.idProduto = id;
                    // informar outros campos caso necessite no bll
                    bllProduto.Delete(produto );
                    dgvproduto.DataSource = "";
                    dgvproduto.DataSource = bllProduto.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limparCampos();
            Habilitar(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.BLLProduto bllProduto = new Camadas.BLL.BLLProduto();
            Camadas.Model.ModelProduto produto = new Camadas.Model.ModelProduto();
            int id = Convert.ToInt32(txtid.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
               
                produto.nome = txtnome.Text;                
                produto.descricao = txtdescricao.Text;
                produto.valor = Convert.ToDecimal(txtvalor.Text);
                produto.status = txtstatus.Text;
                produto.id_fornecedor = Convert.ToInt32(txtfornecedor.Text);
                produto.qtd = Convert.ToDecimal(txtQtd.Text);

                if (id == -1)  //-1 indica inserir 
                    bllProduto.Insert(produto);
                else
                {
                    produto.idProduto = Convert.ToInt32(txtid.Text);
                    bllProduto.Update(produto);
                }
            }
            dgvproduto.DataSource = "";
            dgvproduto.DataSource = bllProduto.Select();
            limparCampos(); //limpa campos
            Habilitar(false);  //desabilita controles
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvproduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvproduto.CurrentRow.Cells["idProduto"].Value.ToString();
            DataGridViewRow linha = dgvproduto.CurrentRow;
            txtnome.Text = linha.Cells["nome"].Value.ToString();
            txtdescricao.Text = linha.Cells["descricao"].Value.ToString();
            txtvalor.Text = linha.Cells["valor"].Value.ToString();
            txtstatus.Text = linha.Cells["status"].Value.ToString();
            txtfornecedor.Text = linha.Cells["id_fornecedor"].Value.ToString();
            txtQtd.Text = linha.Cells["qtd"].Value.ToString();
            Codigo = Convert.ToInt32(txtid.Text);
            Nome = txtnome.Text;
            Qtd = Convert.ToDecimal( txtQtd.Text);
            Valor = Convert.ToDecimal(txtvalor.Text);
        }

        private void dgvproduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvproduto.SelectedRows.Count > 0)
            {
                txtid.Text = dgvproduto.SelectedRows[0].Cells["idProduto"].Value.ToString();
                txtnome.Text = dgvproduto.SelectedRows[0].Cells["nome"].Value.ToString();
                txtstatus.Text = dgvproduto.SelectedRows[0].Cells["status"].Value.ToString();
                txtvalor.Text = dgvproduto.SelectedRows[0].Cells["valor"].Value.ToString();
                txtfornecedor.Text = dgvproduto.SelectedRows[0].Cells["id_fornecedor"].Value.ToString();
                txtdescricao.Text = dgvproduto.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtQtd.Text = dgvproduto.SelectedRows[0].Cells["qtd"].Value.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChanged(null, null);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.BLLProduto bllProd = new Camadas.BLL.BLLProduto();
            dgvproduto.DataSource = "";
            dgvproduto.DataSource = bllProd.Select();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                Camadas.Model.ModelProduto oProd = new Camadas.Model.ModelProduto();
                oProd.nome = txtPesquisa.Text;

                Camadas.BLL.BLLProduto bllprod = new Camadas.BLL.BLLProduto();
                dgvproduto.DataSource = bllprod.Select(2, oProd);

            }
            else if (rdbCodigo.Checked == true)
            {

                Camadas.Model.ModelProduto oProd = new Camadas.Model.ModelProduto();
                oProd.idProduto = Convert.ToInt32(txtPesquisa.Text.ToString());

                Camadas.BLL.BLLProduto bllprod = new Camadas.BLL.BLLProduto();
                dgvproduto.DataSource = bllprod.Select(1, oProd);

            }//fim if busca produto
        }

        private void lblPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
