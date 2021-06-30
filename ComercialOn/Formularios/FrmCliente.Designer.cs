namespace ComercialOn
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpTipo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnEditarAlterar = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.chkCadastroEndereco = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(44, 563);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cpf";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ativo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label7.Location = new System.Drawing.Point(256, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cadastros";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(61, 144);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(49, 17);
            this.chkAtivo.TabIndex = 5;
            this.chkAtivo.Text = "ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(61, 111);
            this.mskTel.Mask = "(99) 9 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(372, 20);
            this.mskTel.TabIndex = 4;
            this.mskTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(61, 85);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(372, 20);
            this.mskCpf.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCadastroEndereco);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.mskCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(30, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 213);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.label14);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.cmbEstado);
            this.gpbEndereco.Controls.Add(this.label13);
            this.gpbEndereco.Controls.Add(this.label12);
            this.gpbEndereco.Controls.Add(this.txtCep);
            this.gpbEndereco.Controls.Add(this.label11);
            this.gpbEndereco.Controls.Add(this.label10);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.label9);
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.label8);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.label1);
            this.gpbEndereco.Controls.Add(this.cmpTipo);
            this.gpbEndereco.Location = new System.Drawing.Point(520, 116);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(598, 213);
            this.gpbEndereco.TabIndex = 18;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereços";
            this.gpbEndereco.Visible = false;
            this.gpbEndereco.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Cidade *";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(411, 64);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(120, 20);
            this.txtCidade.TabIndex = 15;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(95, 61);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 21);
            this.cmbEstado.TabIndex = 14;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Estados *";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "CEP *";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(95, 29);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(413, 20);
            this.txtCep.TabIndex = 10;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bairro *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(95, 130);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(247, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(448, 134);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(93, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Logradouro *";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(473, 94);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(95, 94);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(322, 20);
            this.txtLogradouro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo *";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmpTipo
            // 
            this.cmpTipo.FormattingEnabled = true;
            this.cmpTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Entrega",
            "Cobrança"});
            this.cmpTipo.Location = new System.Drawing.Point(95, 166);
            this.cmpTipo.Name = "cmpTipo";
            this.cmpTipo.Size = new System.Drawing.Size(332, 21);
            this.cmpTipo.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdBuscarCliente
            // 
            this.txtIdBuscarCliente.Enabled = false;
            this.txtIdBuscarCliente.Location = new System.Drawing.Point(30, 88);
            this.txtIdBuscarCliente.Name = "txtIdBuscarCliente";
            this.txtIdBuscarCliente.ReadOnly = true;
            this.txtIdBuscarCliente.Size = new System.Drawing.Size(372, 20);
            this.txtIdBuscarCliente.TabIndex = 24;
            this.txtIdBuscarCliente.TextChanged += new System.EventHandler(this.txtIdBuscarCliente_TextChanged);
            // 
            // btnEditarAlterar
            // 
            this.btnEditarAlterar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditarAlterar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnEditarAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEditarAlterar.Location = new System.Drawing.Point(599, 563);
            this.btnEditarAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarAlterar.Name = "btnEditarAlterar";
            this.btnEditarAlterar.Size = new System.Drawing.Size(231, 31);
            this.btnEditarAlterar.TabIndex = 25;
            this.btnEditarAlterar.Text = "Editar";
            this.btnEditarAlterar.UseVisualStyleBackColor = false;
            this.btnEditarAlterar.Click += new System.EventHandler(this.btnEditarAlterar_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.BackColor = System.Drawing.Color.Chocolate;
            this.btnListarClientes.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnListarClientes.Location = new System.Drawing.Point(322, 563);
            this.btnListarClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(230, 31);
            this.btnListarClientes.TabIndex = 26;
            this.btnListarClientes.Text = "&Listar";
            this.btnListarClientes.UseVisualStyleBackColor = false;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarCliente.Enabled = false;
            this.btnCancelarCliente.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnCancelarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelarCliente.Location = new System.Drawing.Point(862, 563);
            this.btnCancelarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(231, 31);
            this.btnCancelarCliente.TabIndex = 27;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // chkCadastroEndereco
            // 
            this.chkCadastroEndereco.AutoSize = true;
            this.chkCadastroEndereco.Location = new System.Drawing.Point(317, 144);
            this.chkCadastroEndereco.Name = "chkCadastroEndereco";
            this.chkCadastroEndereco.Size = new System.Drawing.Size(116, 17);
            this.chkCadastroEndereco.TabIndex = 28;
            this.chkCadastroEndereco.Text = "cadastra Endereço";
            this.chkCadastroEndereco.UseVisualStyleBackColor = true;
            this.chkCadastroEndereco.CheckedChanged += new System.EventHandler(this.chkCadastroEndereco_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 645);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnEditarAlterar);
            this.Controls.Add(this.txtIdBuscarCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmpTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdBuscarCliente;
        private System.Windows.Forms.Button btnEditarAlterar;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.CheckBox chkCadastroEndereco;
    }
}

