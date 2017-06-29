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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmForn = new FrmFornecedor();
            frmForn.MdiParent = this;
            frmForn.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }

        private void vendededoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camadas.formVendedor frmCli = new Camadas.formVendedor();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormProduto frmCli = new FormProduto();
           frmCli.MdiParent = this;
           frmCli.Show();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOs frmOs = new FormOs();
            frmOs.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.RelProd.impRelProdutos();
        }

        private void ordensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.RelOs.impRelOrdemServicos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsslData_Paint(object sender, PaintEventArgs e)
        {
            tsslData.Text = DateTime.Now.ToShortDateString();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
