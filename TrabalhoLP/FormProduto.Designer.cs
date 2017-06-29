namespace TrabalhoLP
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtfornecedor = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblfornecedor = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(120, 40);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 43;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(54, 44);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(53, 16);
            this.lblnome.TabIndex = 42;
            this.lblnome.Text = "Nome:";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(430, 316);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 37);
            this.btncancelar.TabIndex = 41;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(120, 69);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(52, 20);
            this.txtstatus.TabIndex = 39;
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.Location = new System.Drawing.Point(120, 164);
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(28, 20);
            this.txtfornecedor.TabIndex = 38;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(120, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(28, 20);
            this.txtid.TabIndex = 37;
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfornecedor.Location = new System.Drawing.Point(15, 168);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(92, 16);
            this.lblfornecedor.TabIndex = 35;
            this.lblfornecedor.Text = "Fornecedor:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(52, 73);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(55, 16);
            this.lblstatus.TabIndex = 34;
            this.lblstatus.Text = "Status:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(55, 108);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(49, 16);
            this.lblvalor.TabIndex = 33;
            this.lblvalor.Text = "Valor:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(24, 190);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(83, 16);
            this.lbldescricao.TabIndex = 32;
            this.lbldescricao.Text = "Descricao:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(77, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 16);
            this.lblid.TabIndex = 31;
            this.lblid.Text = "ID:";
            // 
            // dgvproduto
            // 
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Location = new System.Drawing.Point(16, 359);
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.Size = new System.Drawing.Size(647, 99);
            this.dgvproduto.TabIndex = 30;
            this.dgvproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellContentClick);
            this.dgvproduto.DoubleClick += new System.EventHandler(this.dgvproduto_DoubleClick);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.Location = new System.Drawing.Point(613, 316);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(54, 37);
            this.btnsair.TabIndex = 29;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Image")));
            this.btnlimpar.Location = new System.Drawing.Point(349, 316);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 37);
            this.btnlimpar.TabIndex = 28;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Image = ((System.Drawing.Image)(resources.GetObject("btngravar.Image")));
            this.btngravar.Location = new System.Drawing.Point(268, 316);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 37);
            this.btngravar.TabIndex = 27;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Image = ((System.Drawing.Image)(resources.GetObject("btnremover.Image")));
            this.btnremover.Location = new System.Drawing.Point(174, 316);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(88, 37);
            this.btnremover.TabIndex = 26;
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(93, 316);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 37);
            this.btneditar.TabIndex = 25;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Image = ((System.Drawing.Image)(resources.GetObject("btninserir.Image")));
            this.btninserir.Location = new System.Drawing.Point(12, 316);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 37);
            this.btninserir.TabIndex = 24;
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(120, 190);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(272, 113);
            this.txtdescricao.TabIndex = 36;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPesquisa.Controls.Add(this.btnFiltrar);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblPesquisa);
            this.pnlPesquisa.Controls.Add(this.gpbPesquisa);
            this.pnlPesquisa.Location = new System.Drawing.Point(436, 12);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(231, 280);
            this.pnlPesquisa.TabIndex = 44;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(12, 221);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 43);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 189);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(194, 26);
            this.txtPesquisa.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(12, 154);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(194, 23);
            this.lblPesquisa.TabIndex = 1;
            this.lblPesquisa.Click += new System.EventHandler(this.lblPesquisa_Click);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbCodigo);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(200, 139);
            this.gpbPesquisa.TabIndex = 0;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.Location = new System.Drawing.Point(6, 106);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(114, 28);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigo.Location = new System.Drawing.Point(6, 63);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(123, 28);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Por Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(6, 20);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(82, 28);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(520, 316);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 37);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(120, 130);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(52, 20);
            this.txtQtd.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "QTD:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(120, 104);
            this.txtvalor.Mask = "99,000";
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(52, 20);
            this.txtvalor.TabIndex = 48;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(675, 468);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtfornecedor);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblfornecedor);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dgvproduto);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtdescricao);
            this.Name = "FormProduto";
            this.Text = "Manter Dados de Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtfornecedor;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblfornecedor;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.MaskedTextBox txtvalor;
    }
}