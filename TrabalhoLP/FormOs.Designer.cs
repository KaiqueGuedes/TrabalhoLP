namespace TrabalhoLP
{
    partial class FormOs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOs));
            this.txtidProd = new System.Windows.Forms.MaskedTextBox();
            this.txtidcli = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNremover = new System.Windows.Forms.Button();
            this.BTNgravar = new System.Windows.Forms.Button();
            this.BTNeditar = new System.Windows.Forms.Button();
            this.dgvOs = new System.Windows.Forms.DataGridView();
            this.BTNsair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_data_ini = new System.Windows.Forms.MaskedTextBox();
            this.txt_data_final = new System.Windows.Forms.MaskedTextBox();
            this.BTNbuscaprod = new System.Windows.Forms.Button();
            this.BTNbuscaCli = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.txtNomecli = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeprod = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BTNremoverp = new System.Windows.Forms.Button();
            this.BTNincluir = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.MaskedTextBox();
            this.txtvalor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidProd
            // 
            this.txtidProd.Location = new System.Drawing.Point(14, 106);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(32, 20);
            this.txtidProd.TabIndex = 51;
            this.txtidProd.TextChanged += new System.EventHandler(this.txtidProd_TextChanged);
            // 
            // txtidcli
            // 
            this.txtidcli.Location = new System.Drawing.Point(13, 47);
            this.txtidcli.Name = "txtidcli";
            this.txtidcli.Size = new System.Drawing.Size(32, 20);
            this.txtidcli.TabIndex = 50;
            this.txtidcli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtidcli_MaskInputRejected);
            this.txtidcli.TextChanged += new System.EventHandler(this.txtidcli_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "ID";
            // 
            // BTNremover
            // 
            this.BTNremover.Image = ((System.Drawing.Image)(resources.GetObject("BTNremover.Image")));
            this.BTNremover.Location = new System.Drawing.Point(107, 450);
            this.BTNremover.Name = "BTNremover";
            this.BTNremover.Size = new System.Drawing.Size(58, 37);
            this.BTNremover.TabIndex = 47;
            this.BTNremover.UseVisualStyleBackColor = true;
            // 
            // BTNgravar
            // 
            this.BTNgravar.Image = ((System.Drawing.Image)(resources.GetObject("BTNgravar.Image")));
            this.BTNgravar.Location = new System.Drawing.Point(107, 407);
            this.BTNgravar.Name = "BTNgravar";
            this.BTNgravar.Size = new System.Drawing.Size(58, 37);
            this.BTNgravar.TabIndex = 46;
            this.BTNgravar.UseVisualStyleBackColor = true;
            this.BTNgravar.Click += new System.EventHandler(this.BTNgravar_Click);
            // 
            // BTNeditar
            // 
            this.BTNeditar.Image = ((System.Drawing.Image)(resources.GetObject("BTNeditar.Image")));
            this.BTNeditar.Location = new System.Drawing.Point(12, 450);
            this.BTNeditar.Name = "BTNeditar";
            this.BTNeditar.Size = new System.Drawing.Size(73, 37);
            this.BTNeditar.TabIndex = 45;
            this.BTNeditar.UseVisualStyleBackColor = true;
            // 
            // dgvOs
            // 
            this.dgvOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOs.Location = new System.Drawing.Point(13, 299);
            this.dgvOs.Name = "dgvOs";
            this.dgvOs.Size = new System.Drawing.Size(405, 102);
            this.dgvOs.TabIndex = 44;
            this.dgvOs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOs_CellContentClick);
            // 
            // BTNsair
            // 
            this.BTNsair.Image = ((System.Drawing.Image)(resources.GetObject("BTNsair.Image")));
            this.BTNsair.Location = new System.Drawing.Point(343, 448);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(75, 41);
            this.BTNsair.TabIndex = 43;
            this.BTNsair.UseVisualStyleBackColor = true;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Data Saída";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Data Entrada";
            // 
            // txt_data_ini
            // 
            this.txt_data_ini.Location = new System.Drawing.Point(14, 158);
            this.txt_data_ini.Mask = "00/00/0000 90:00";
            this.txt_data_ini.Name = "txt_data_ini";
            this.txt_data_ini.Size = new System.Drawing.Size(100, 20);
            this.txt_data_ini.TabIndex = 40;
            this.txt_data_ini.ValidatingType = typeof(System.DateTime);
            this.txt_data_ini.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_data_ini_MaskInputRejected);
            // 
            // txt_data_final
            // 
            this.txt_data_final.Location = new System.Drawing.Point(136, 158);
            this.txt_data_final.Mask = "00/00/0000 90:00";
            this.txt_data_final.Name = "txt_data_final";
            this.txt_data_final.Size = new System.Drawing.Size(100, 20);
            this.txt_data_final.TabIndex = 39;
            this.txt_data_final.ValidatingType = typeof(System.DateTime);
            // 
            // BTNbuscaprod
            // 
            this.BTNbuscaprod.Image = ((System.Drawing.Image)(resources.GetObject("BTNbuscaprod.Image")));
            this.BTNbuscaprod.Location = new System.Drawing.Point(335, 101);
            this.BTNbuscaprod.Name = "BTNbuscaprod";
            this.BTNbuscaprod.Size = new System.Drawing.Size(75, 43);
            this.BTNbuscaprod.TabIndex = 38;
            this.BTNbuscaprod.UseVisualStyleBackColor = true;
            this.BTNbuscaprod.Click += new System.EventHandler(this.BTNbuscaprod_Click);
            // 
            // BTNbuscaCli
            // 
            this.BTNbuscaCli.Image = ((System.Drawing.Image)(resources.GetObject("BTNbuscaCli.Image")));
            this.BTNbuscaCli.Location = new System.Drawing.Point(343, 31);
            this.BTNbuscaCli.Name = "BTNbuscaCli";
            this.BTNbuscaCli.Size = new System.Drawing.Size(67, 41);
            this.BTNbuscaCli.TabIndex = 37;
            this.BTNbuscaCli.UseVisualStyleBackColor = true;
            this.BTNbuscaCli.Click += new System.EventHandler(this.BTNbuscaCli_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 241);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(405, 52);
            this.txtDescricao.TabIndex = 35;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 34;
            // 
            // txtNomecli
            // 
            this.txtNomecli.Location = new System.Drawing.Point(52, 47);
            this.txtNomecli.Name = "txtNomecli";
            this.txtNomecli.Size = new System.Drawing.Size(277, 20);
            this.txtNomecli.TabIndex = 33;
            // 
            // txtNomeprod
            // 
            this.txtNomeprod.Location = new System.Drawing.Point(52, 108);
            this.txtNomeprod.Name = "txtNomeprod";
            this.txtNomeprod.Size = new System.Drawing.Size(97, 20);
            this.txtNomeprod.TabIndex = 31;
            this.txtNomeprod.TextChanged += new System.EventHandler(this.txtNomeprod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "&Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(174, 106);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(34, 20);
            this.txtqtd.TabIndex = 53;
            this.txtqtd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtqtd_MaskInputRejected);
            this.txtqtd.TextChanged += new System.EventHandler(this.txtqtd_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Qtd";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Valor unitario";
            // 
            // BTNremoverp
            // 
            this.BTNremoverp.Image = ((System.Drawing.Image)(resources.GetObject("BTNremoverp.Image")));
            this.BTNremoverp.Location = new System.Drawing.Point(335, 156);
            this.BTNremoverp.Name = "BTNremoverp";
            this.BTNremoverp.Size = new System.Drawing.Size(75, 42);
            this.BTNremoverp.TabIndex = 56;
            this.BTNremoverp.UseVisualStyleBackColor = true;
            this.BTNremoverp.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNincluir
            // 
            this.BTNincluir.Image = ((System.Drawing.Image)(resources.GetObject("BTNincluir.Image")));
            this.BTNincluir.Location = new System.Drawing.Point(254, 156);
            this.BTNincluir.Name = "BTNincluir";
            this.BTNincluir.Size = new System.Drawing.Size(75, 42);
            this.BTNincluir.TabIndex = 57;
            this.BTNincluir.UseVisualStyleBackColor = true;
            this.BTNincluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Finalizado",
            "Calcelado"});
            this.cmbStatus.Location = new System.Drawing.Point(14, 201);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Status";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(242, 105);
            this.txtUnit.Mask = "999,000";
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(76, 20);
            this.txtUnit.TabIndex = 65;
            this.txtUnit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox2_MouseClick);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(318, 422);
            this.txtvalor.Mask = "999,999";
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 66;
            // 
            // FormOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(430, 493);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.BTNincluir);
            this.Controls.Add(this.BTNremoverp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtidProd);
            this.Controls.Add(this.txtidcli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNremover);
            this.Controls.Add(this.BTNgravar);
            this.Controls.Add(this.BTNeditar);
            this.Controls.Add(this.dgvOs);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_data_ini);
            this.Controls.Add(this.txt_data_final);
            this.Controls.Add(this.BTNbuscaprod);
            this.Controls.Add(this.BTNbuscaCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNomecli);
            this.Controls.Add(this.txtNomeprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOs";
            this.Text = "FormOs";
            this.Load += new System.EventHandler(this.FormOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtidProd;
        private System.Windows.Forms.MaskedTextBox txtidcli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNremover;
        private System.Windows.Forms.Button BTNgravar;
        private System.Windows.Forms.Button BTNeditar;
        private System.Windows.Forms.DataGridView dgvOs;
        private System.Windows.Forms.Button BTNsair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_data_ini;
        private System.Windows.Forms.MaskedTextBox txt_data_final;
        private System.Windows.Forms.Button BTNbuscaprod;
        private System.Windows.Forms.Button BTNbuscaCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtNomecli;
        private System.Windows.Forms.MaskedTextBox txtNomeprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtqtd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTNremoverp;
        private System.Windows.Forms.Button BTNincluir;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtUnit;
        private System.Windows.Forms.MaskedTextBox txtvalor;
    }
}