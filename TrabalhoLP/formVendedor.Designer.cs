namespace TrabalhoLP.Camadas
{
    partial class formVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVendedor));
            this.txbId = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtfone = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblfone = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnncancelar = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dgvvendedor = new System.Windows.Forms.DataGridView();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.btngravar = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(42, 13);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(36, 20);
            this.txbId.TabIndex = 53;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(9, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(27, 16);
            this.label.TabIndex = 52;
            this.label.Text = "ID:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(289, 85);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(133, 22);
            this.txtcpf.TabIndex = 51;
            // 
            // txtuf
            // 
            this.txtuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuf.Location = new System.Drawing.Point(810, 152);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(49, 22);
            this.txtuf.TabIndex = 50;
            this.txtuf.Leave += new System.EventHandler(this.txtuf_Leave);
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(160, 152);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(167, 22);
            this.txtcidade.TabIndex = 49;
            // 
            // txtfone
            // 
            this.txtfone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfone.Location = new System.Drawing.Point(12, 152);
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(125, 22);
            this.txtfone.TabIndex = 48;
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(653, 152);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(129, 22);
            this.txtcep.TabIndex = 47;
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(341, 152);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(287, 22);
            this.txtendereco.TabIndex = 46;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(443, 85);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(350, 22);
            this.txtemail.TabIndex = 45;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(12, 85);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(260, 22);
            this.txtnome.TabIndex = 44;
            // 
            // lblfone
            // 
            this.lblfone.AutoSize = true;
            this.lblfone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfone.Location = new System.Drawing.Point(9, 133);
            this.lblfone.Name = "lblfone";
            this.lblfone.Size = new System.Drawing.Size(47, 16);
            this.lblfone.TabIndex = 43;
            this.lblfone.Text = "Fone:";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.Location = new System.Drawing.Point(844, 245);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 40);
            this.btnsair.TabIndex = 42;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click_1);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Image")));
            this.btnlimpar.Location = new System.Drawing.Point(470, 245);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 40);
            this.btnlimpar.TabIndex = 41;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // btnncancelar
            // 
            this.btnncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnncancelar.Image")));
            this.btnncancelar.Location = new System.Drawing.Point(354, 245);
            this.btnncancelar.Name = "btnncancelar";
            this.btnncancelar.Size = new System.Drawing.Size(104, 40);
            this.btnncancelar.TabIndex = 40;
            this.btnncancelar.UseVisualStyleBackColor = true;
            this.btnncancelar.Click += new System.EventHandler(this.btnncancelar_Click_1);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(467, 66);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 16);
            this.lblemail.TabIndex = 39;
            this.lblemail.Text = "Email:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(807, 133);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(32, 16);
            this.lblUF.TabIndex = 38;
            this.lblUF.Text = "UF:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(338, 133);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(79, 16);
            this.lblendereco.TabIndex = 37;
            this.lblendereco.Text = "Endereco:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(650, 133);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 16);
            this.lblCEP.TabIndex = 36;
            this.lblCEP.Text = "CEP:";
            // 
            // btnremover
            // 
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Image = ((System.Drawing.Image)(resources.GetObject("btnremover.Image")));
            this.btnremover.Location = new System.Drawing.Point(262, 245);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(86, 40);
            this.btnremover.TabIndex = 35;
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(181, 245);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 40);
            this.btneditar.TabIndex = 34;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // dgvvendedor
            // 
            this.dgvvendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendedor.Location = new System.Drawing.Point(19, 291);
            this.dgvvendedor.Name = "dgvvendedor";
            this.dgvvendedor.Size = new System.Drawing.Size(900, 118);
            this.dgvvendedor.TabIndex = 33;
            this.dgvvendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendedor_CellContentClick_1);
            this.dgvvendedor.DoubleClick += new System.EventHandler(this.dgvvendedor_DoubleClick);
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(157, 133);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(62, 16);
            this.lblcidade.TabIndex = 32;
            this.lblcidade.Text = "Cidade:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(286, 66);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(41, 16);
            this.lblcpf.TabIndex = 31;
            this.lblcpf.Text = "CPF:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(9, 66);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(53, 16);
            this.lblnome.TabIndex = 30;
            this.lblnome.Text = "Nome:";
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Image = ((System.Drawing.Image)(resources.GetObject("btngravar.Image")));
            this.btngravar.Location = new System.Drawing.Point(100, 245);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 40);
            this.btngravar.TabIndex = 29;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Image = ((System.Drawing.Image)(resources.GetObject("btninserir.Image")));
            this.btninserir.Location = new System.Drawing.Point(19, 245);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 40);
            this.btninserir.TabIndex = 28;
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // formVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 421);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtfone);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblfone);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnncancelar);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvvendedor);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btninserir);
            this.Name = "formVendedor";
            this.Text = "Manter Dados de Vendedor";
            this.Load += new System.EventHandler(this.formVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtfone;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblfone;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnncancelar;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dgvvendedor;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btninserir;
    }
}