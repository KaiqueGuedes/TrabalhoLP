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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {

            txtId.Enabled = status;
            txtNome.Enabled = status;
            txtCpf_cnpj.Enabled = status;
            txtCidade.Enabled = status;
            txtCep.Enabled = status;
            txtEndereco.Enabled = status;
            txtUF.Enabled = status;
            txtEmail.Enabled = status;
            txtFone.Enabled = status;
            dgvFornecedor.Enabled = !status;

            //botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCpf_cnpj.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtUF.Text = "";
            txtEmail.Text = "";
            txtFone.Text = "";
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            Camadas.BLL.BLLfornecedor bllFornecedor = new Camadas.BLL.BLLfornecedor();
            dgvFornecedor.DataSource = bllFornecedor.Select();
            Camadas.DAL.DALLfornecedor dalForn = new Camadas.DAL.DALLfornecedor();
            dgvFornecedor.DataSource = dalForn.Select();
            Habilitar(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.BLLfornecedor bllFornecedor = new Camadas.BLL.BLLfornecedor();
            Camadas.Model.Modelfornecedor fornecedor = new Camadas.Model.Modelfornecedor();
            int id = Convert.ToInt32(txtId.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                fornecedor.nome = txtNome.Text;
                fornecedor.cpf_cnpj = txtCpf_cnpj.Text;
                fornecedor.cidade = txtCidade.Text;
                fornecedor.cep = txtCep.Text;
                fornecedor.endereco = txtEndereco.Text;
                fornecedor.uf = txtUF.Text;
                fornecedor.email = txtEmail.Text;
                fornecedor.fone = txtFone.Text;
                if (id == -1)  //-1 indica inserir 
                    bllFornecedor.Insert(fornecedor);
                else
                {
                    fornecedor.id = Convert.ToInt32(txtId.Text);
                    bllFornecedor.Update(fornecedor);
                }
            }
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = bllFornecedor.Select();
            limparCampos(); //limpa campos
            Habilitar(false);  //desabilita controles
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvFornecedor.CurrentRow.Cells["Id"].Value.ToString();
            DataGridViewRow linha = dgvFornecedor.CurrentRow;
            txtNome.Text = linha.Cells["nome"].Value.ToString();
            txtCpf_cnpj.Text = linha.Cells["cpf_cnpj"].Value.ToString();
            txtCidade.Text = linha.Cells["cidade"].Value.ToString();
            txtCep.Text = linha.Cells["cep"].Value.ToString();
            txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
            txtUF.Text = linha.Cells["uf"].Value.ToString();
            txtEmail.Text = linha.Cells["email"].Value.ToString();
            txtFone.Text = linha.Cells["fone"].Value.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtId.Text = "-1";
            Habilitar(true);
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Habilitar(true);
                txtId.Enabled = false;
                txtNome.Focus();
            }
            else MessageBox.Show("Não há registro para ser editado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (txtId.Text != string.Empty)
            {
                msg = "Confirma Remoção do Fornecedor " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Camadas.BLL.BLLfornecedor bllFornecedor = new Camadas.BLL.BLLfornecedor();
                    Camadas.Model.Modelfornecedor fornecedor = new Camadas.Model.Modelfornecedor();
                    fornecedor.id = id;
                    // informar outros campos caso necessite no bll
                    bllFornecedor.Delete(fornecedor);
                    dgvFornecedor.DataSource = "";
                    dgvFornecedor.DataSource = bllFornecedor.Select();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                txtId.Text = dgvFornecedor.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvFornecedor.SelectedRows[0].Cells["nome"].Value.ToString();
                txtCpf_cnpj.Text = dgvFornecedor.SelectedRows[0].Cells["cpf_cnpj"].Value.ToString();
                txtCidade.Text = dgvFornecedor.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtCep.Text = dgvFornecedor.SelectedRows[0].Cells["cep"].Value.ToString();
                txtEndereco.Text = dgvFornecedor.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtUF.Text = dgvFornecedor.SelectedRows[0].Cells["uf"].Value.ToString();
                txtEmail.Text = dgvFornecedor.SelectedRows[0].Cells["email"].Value.ToString();
                txtFone.Text = dgvFornecedor.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
