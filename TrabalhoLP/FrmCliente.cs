using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP.Camadas;

namespace TrabalhoLP
{
    public partial class frmCliente : Form
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public frmCliente()
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
            dgvClientes.Enabled = !status;

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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.BLLcliente bllCliente = new Camadas.BLL.BLLcliente();
            dgvClientes.DataSource = bllCliente.Select();
            Camadas.DAL.DALLcliente dalCli = new Camadas.DAL.DALLcliente();
            dgvClientes.DataSource = dalCli.Select();
            Habilitar(false);
            
            pnlPesquisa.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.BLL.BLLcliente BLLcliente = new Camadas.BLL.BLLcliente();
            Camadas.Model.Modelcliente cliente = new Camadas.Model.Modelcliente();
            int id = Convert.ToInt32(txtId.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.nome = txtNome.Text;
                cliente.cpf_cnpj = txtCpf_cnpj.Text;
                cliente.cidade = txtCidade.Text;
                cliente.cep = txtCep.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.uf = txtUF.Text;
                cliente.email = txtEmail.Text;
                cliente.fone = txtFone.Text;
                if (id == -1)  //-1 indica inserir 
                    BLLcliente.Insert(cliente);
                else
                {
                    cliente.id = Convert.ToInt32(txtId.Text);
                    BLLcliente.Update(cliente);
                }
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = BLLcliente.Select();
            limparCampos(); //limpa campos
            Habilitar(false);  //desabilita controles

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            DataGridViewRow linha = dgvClientes.CurrentRow;
            txtNome.Text = linha.Cells["nome"].Value.ToString();
            txtCpf_cnpj.Text = linha.Cells["cpf_cnpj"].Value.ToString();
            txtCidade.Text = linha.Cells["cidade"].Value.ToString();
            txtCep.Text = linha.Cells["cep"].Value.ToString();
            txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
            txtUF.Text = linha.Cells["uf"].Value.ToString();
            txtEmail.Text = linha.Cells["email"].Value.ToString();
            txtFone.Text = linha.Cells["fone"].Value.ToString();
          
            Codigo = Convert.ToInt32(txtId.Text);
            Nome = txtNome.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtId.Text = "-1";
            Habilitar(true);
            txtNome.Focus();

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

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
                msg = "Confirma Remoção do Cliente " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Camadas.BLL.BLLcliente bllCliente = new Camadas.BLL.BLLcliente();
                    Camadas.Model.Modelcliente cliente = new Camadas.Model.Modelcliente();
                    cliente.id = id;
                    // informar outros campos caso necessite no bll
                    bllCliente.Delete(cliente);
                    dgvClientes.DataSource = "";
                    dgvClientes.DataSource = bllCliente.Select();
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

        private void dgvClientes_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                txtId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtCpf_cnpj.Text = dgvClientes.SelectedRows[0].Cells["cpf_cnpj"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtCep.Text = dgvClientes.SelectedRows[0].Cells["cep"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtUF.Text = dgvClientes.SelectedRows[0].Cells["uf"].Value.ToString();
                txtEmail.Text = dgvClientes.SelectedRows[0].Cells["email"].Value.ToString();
                txtFone.Text = dgvClientes.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void pnlPesquisa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChanged(null, null);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.BLLcliente bllCliente = new Camadas.BLL.BLLcliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
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
            if  (rdbNome.Checked == true)
            {
                Camadas.Model.Modelcliente oCli = new Camadas.Model.Modelcliente();
                oCli.nome = txtPesquisa.Text;

                Camadas.BLL.BLLcliente bllcli = new Camadas.BLL.BLLcliente();
                dgvClientes.DataSource = bllcli.Select(2, oCli);

            }
            else if  (rdbCodigo.Checked == true)
            {

                Camadas.Model.Modelcliente oCli = new Camadas.Model.Modelcliente();
                oCli.id = Convert.ToInt32(txtPesquisa.Text.ToString());

                Camadas.BLL.BLLcliente bllcli = new Camadas.BLL.BLLcliente();
                dgvClientes.DataSource = bllcli.Select(1, oCli);

            }//fim if busca produto




        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpbPesquisa_Enter(object sender, EventArgs e)
        {

        }
    }
}
