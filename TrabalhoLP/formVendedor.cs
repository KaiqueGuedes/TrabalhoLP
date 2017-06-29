using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP.Camadas
{
    public partial class formVendedor : Form
    {
        public formVendedor()
        {
            InitializeComponent();
        }
        private void Habilitar(bool status)
        {

            label.Enabled = status;
            txtnome.Enabled = status;
            txtcpf.Enabled = status;
            txtcidade.Enabled = status;
            txtcep.Enabled = status;
            txtendereco.Enabled = status;
            txtuf.Enabled = status;
            txtemail.Enabled = status;
            txtfone.Enabled = status;
            dgvvendedor.Enabled = !status;

            //botões
            btninserir.Enabled = !status;
            btneditar.Enabled = !status;
            btnremover.Enabled = !status;
            btngravar.Enabled = status;
            btnncancelar.Enabled = status;
        }
        private void limparCampos()
        {
            label.Text = "";
            txtnome.Text = "";
            txtcpf.Text = "";
            txtcidade.Text = "";
            txtcep.Text = "";
            txtendereco.Text = "";
            txtuf.Text = "";
            txtemail.Text = "";
            txtfone.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblid_Click(object sender, EventArgs e)
        {

        }
        private void btninserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            txbId.Text = "-1";
            Habilitar(true);
            txtnome.Focus();
        }

        private void formVendedor_Load(object sender, EventArgs e)
        {
            BLL.BLLVendedor bllVendedor = new Camadas.BLL.BLLVendedor();
            dgvvendedor.DataSource = bllVendedor.Select();
            Camadas.DAL.DALLVendedor dalVend = new Camadas.DAL.DALLVendedor();
            dgvvendedor.DataSource = dalVend.Select();
            Habilitar(false);

            
        }
        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (txbId.Text != string.Empty)
            {
                Habilitar(true);
                txbId.Enabled = false;
                txtnome.Focus();
            }
            else MessageBox.Show("Não há registro para ser editado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btngravar_Click_1(object sender, EventArgs e)
        {

            Camadas.BLL.BLLVendedor bllVendedor = new Camadas.BLL.BLLVendedor();
            Camadas.Model.ModelVendedor Vendedor = new Camadas.Model.ModelVendedor();
            int id = Convert.ToInt32(txbId.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                Vendedor.nome = txtnome.Text;
                Vendedor.cpf = txtcpf.Text;
                Vendedor.cidade = txtcidade.Text;
                Vendedor.cep = txtcep.Text;
                Vendedor.endereco = txtendereco.Text;
                Vendedor.uf = txtuf.Text;
                Vendedor.email = txtemail.Text;
                Vendedor.fone = txtfone.Text;
                if (id == -1)  //-1 indica inserir 
                    bllVendedor.Insert(Vendedor);
                else
                {
                    Vendedor.id = Convert.ToInt32(txbId.Text);
                    bllVendedor.Update(Vendedor);
                }
            }
            dgvvendedor.DataSource = "";
            dgvvendedor.DataSource = bllVendedor.Select();
            limparCampos(); //limpa campos
            Habilitar(false);  //desabilita controles
        }
        private void btnremover_Click_1(object sender, EventArgs e)
        {
            string msg;
            if (txbId.Text != string.Empty)
            {
                msg = "Confirma Remoção do Vendedor " + txtnome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txbId.Text);
                    Camadas.BLL.BLLVendedor bllVendedorr = new Camadas.BLL.BLLVendedor();
                    Camadas.Model.ModelVendedor Vendedor = new Camadas.Model.ModelVendedor();
                    Vendedor.id = id;
                    // informar outros campos caso necessite no bll
                    bllVendedorr.Delete(Vendedor);
                    dgvvendedor.DataSource = "";
                    dgvvendedor.DataSource = bllVendedorr.Select();
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
        private void btnncancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }
        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }
        private void btnsair_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvvendedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvvendedor.CurrentRow.Cells["id"].Value.ToString();
            DataGridViewRow linha = dgvvendedor.CurrentRow;
            txtnome.Text = linha.Cells["nome"].Value.ToString();
            txtcpf.Text = linha.Cells["cpf"].Value.ToString();
            txtcidade.Text = linha.Cells["cidade"].Value.ToString();
            txtcep.Text = linha.Cells["cep"].Value.ToString();
            txtendereco.Text = linha.Cells["endereco"].Value.ToString();
            txtuf.Text = linha.Cells["uf"].Value.ToString();
            txtemail.Text = linha.Cells["email"].Value.ToString();
            txtfone.Text = linha.Cells["fone"].Value.ToString();

        }

        private void dgvvendedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvvendedor.SelectedRows.Count > 0)
            {
                txbId.Text = dgvvendedor.SelectedRows[0].Cells["id"].Value.ToString();
                txtnome.Text = dgvvendedor.SelectedRows[0].Cells["nome"].Value.ToString();
                txtcpf.Text = dgvvendedor.SelectedRows[0].Cells["cpf"].Value.ToString();
                txtcidade.Text = dgvvendedor.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtcep.Text = dgvvendedor.SelectedRows[0].Cells["cep"].Value.ToString();
                txtendereco.Text = dgvvendedor.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtuf.Text = dgvvendedor.SelectedRows[0].Cells["uf"].Value.ToString();
                txtemail.Text = dgvvendedor.SelectedRows[0].Cells["email"].Value.ToString();
                txtfone.Text = dgvvendedor.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void txtuf_Leave(object sender, EventArgs e)
        {
            txtuf.Text = txtuf.Text.ToUpper();
        }
    }
}