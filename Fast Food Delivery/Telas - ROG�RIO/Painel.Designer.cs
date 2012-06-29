namespace Telas
{
    partial class frmPainel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainel));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnEntregaspendentes = new System.Windows.Forms.Button();
            this.lblUsuarioativo = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovopedido = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrarcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientescadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdicionarprodutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutoscadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.bairrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBairroscadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.bairrosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlterarsenha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrarusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxMoto = new System.Windows.Forms.PictureBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecione = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(470, 455);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.Location = new System.Drawing.Point(559, 455);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(83, 37);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Visible = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnEntregaspendentes
            // 
            this.btnEntregaspendentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntregaspendentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregaspendentes.Location = new System.Drawing.Point(563, 12);
            this.btnEntregaspendentes.Name = "btnEntregaspendentes";
            this.btnEntregaspendentes.Size = new System.Drawing.Size(79, 39);
            this.btnEntregaspendentes.TabIndex = 1;
            this.btnEntregaspendentes.Text = "Entregas pendentes";
            this.btnEntregaspendentes.UseVisualStyleBackColor = false;
            this.btnEntregaspendentes.Click += new System.EventHandler(this.btnEntregaspendentes_Click);
            // 
            // lblUsuarioativo
            // 
            this.lblUsuarioativo.AutoSize = true;
            this.lblUsuarioativo.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioativo.Location = new System.Drawing.Point(41, 36);
            this.lblUsuarioativo.Name = "lblUsuarioativo";
            this.lblUsuarioativo.Size = new System.Drawing.Size(115, 20);
            this.lblUsuarioativo.TabIndex = 39;
            this.lblUsuarioativo.Text = "Usuário Ativo:  ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVendas,
            this.tsmAdministrador,
            this.tsmSobre,
            this.tsmSair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(654, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmVendas
            // 
            this.tsmVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovopedido,
            this.clienteToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.bairrosToolStripMenuItem,
            this.tsmRelatorio,
            this.tsmAlterarsenha});
            this.tsmVendas.Name = "tsmVendas";
            this.tsmVendas.Size = new System.Drawing.Size(57, 20);
            this.tsmVendas.Text = "Vendas";
            // 
            // tsmNovopedido
            // 
            this.tsmNovopedido.Name = "tsmNovopedido";
            this.tsmNovopedido.Size = new System.Drawing.Size(144, 22);
            this.tsmNovopedido.Text = "Novo Pedido";
            this.tsmNovopedido.Click += new System.EventHandler(this.tsmNovopedido_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrarcliente,
            this.tsmClientescadastrados});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // tsmCadastrarcliente
            // 
            this.tsmCadastrarcliente.Name = "tsmCadastrarcliente";
            this.tsmCadastrarcliente.Size = new System.Drawing.Size(184, 22);
            this.tsmCadastrarcliente.Text = "Cadastrar Cliente";
            this.tsmCadastrarcliente.Click += new System.EventHandler(this.tsmCadastrarcliente_Click);
            // 
            // tsmClientescadastrados
            // 
            this.tsmClientescadastrados.Name = "tsmClientescadastrados";
            this.tsmClientescadastrados.Size = new System.Drawing.Size(184, 22);
            this.tsmClientescadastrados.Text = "Clientes Cadastrados";
            this.tsmClientescadastrados.Click += new System.EventHandler(this.tsmClientescadastrados_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdicionarprodutos,
            this.tsmProdutoscadastrados});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // tsmAdicionarprodutos
            // 
            this.tsmAdicionarprodutos.Name = "tsmAdicionarprodutos";
            this.tsmAdicionarprodutos.Size = new System.Drawing.Size(190, 22);
            this.tsmAdicionarprodutos.Text = "Adicionar Produtos";
            this.tsmAdicionarprodutos.Click += new System.EventHandler(this.tsmAdicionarprodutos_Click);
            // 
            // tsmProdutoscadastrados
            // 
            this.tsmProdutoscadastrados.Name = "tsmProdutoscadastrados";
            this.tsmProdutoscadastrados.Size = new System.Drawing.Size(190, 22);
            this.tsmProdutoscadastrados.Text = "Produtos Cadastrados";
            this.tsmProdutoscadastrados.Click += new System.EventHandler(this.tsmProdutoscadastrados_Click);
            // 
            // bairrosToolStripMenuItem
            // 
            this.bairrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBairroscadastrados,
            this.bairrosCadastradosToolStripMenuItem});
            this.bairrosToolStripMenuItem.Name = "bairrosToolStripMenuItem";
            this.bairrosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bairrosToolStripMenuItem.Text = "Bairros";
            // 
            // tsmBairroscadastrados
            // 
            this.tsmBairroscadastrados.Name = "tsmBairroscadastrados";
            this.tsmBairroscadastrados.Size = new System.Drawing.Size(178, 22);
            this.tsmBairroscadastrados.Text = "Cadastrar Bairro";
            this.tsmBairroscadastrados.Click += new System.EventHandler(this.tsmBairroscadastrados_Click);
            // 
            // bairrosCadastradosToolStripMenuItem
            // 
            this.bairrosCadastradosToolStripMenuItem.Name = "bairrosCadastradosToolStripMenuItem";
            this.bairrosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bairrosCadastradosToolStripMenuItem.Text = "Bairros Cadastrados";
            this.bairrosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.bairrosCadastradosToolStripMenuItem_Click);
            // 
            // tsmRelatorio
            // 
            this.tsmRelatorio.Name = "tsmRelatorio";
            this.tsmRelatorio.Size = new System.Drawing.Size(144, 22);
            this.tsmRelatorio.Text = "Relatório";
            this.tsmRelatorio.Click += new System.EventHandler(this.tsmRelatorio_Click);
            // 
            // tsmAlterarsenha
            // 
            this.tsmAlterarsenha.Name = "tsmAlterarsenha";
            this.tsmAlterarsenha.Size = new System.Drawing.Size(144, 22);
            this.tsmAlterarsenha.Text = "Alterar Senha";
            this.tsmAlterarsenha.Click += new System.EventHandler(this.tsmAlterarsenha_Click);
            // 
            // tsmAdministrador
            // 
            this.tsmAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem1,
            this.configuraçõesGeraisToolStripMenuItem});
            this.tsmAdministrador.Name = "tsmAdministrador";
            this.tsmAdministrador.Size = new System.Drawing.Size(95, 20);
            this.tsmAdministrador.Text = "Administrador";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrarusuario,
            this.usuáriosCadastradosToolStripMenuItem});
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            // 
            // tsmCadastrarusuario
            // 
            this.tsmCadastrarusuario.Name = "tsmCadastrarusuario";
            this.tsmCadastrarusuario.Size = new System.Drawing.Size(187, 22);
            this.tsmCadastrarusuario.Text = "Cadastrar Usuário";
            this.tsmCadastrarusuario.Click += new System.EventHandler(this.tsmCadastrarusuario_Click);
            // 
            // usuáriosCadastradosToolStripMenuItem
            // 
            this.usuáriosCadastradosToolStripMenuItem.Name = "usuáriosCadastradosToolStripMenuItem";
            this.usuáriosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.usuáriosCadastradosToolStripMenuItem.Text = "Usuários Cadastrados";
            this.usuáriosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosCadastradosToolStripMenuItem_Click);
            // 
            // configuraçõesGeraisToolStripMenuItem
            // 
            this.configuraçõesGeraisToolStripMenuItem.Name = "configuraçõesGeraisToolStripMenuItem";
            this.configuraçõesGeraisToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesGeraisToolStripMenuItem.Text = "Configurações";
            this.configuraçõesGeraisToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesGeraisToolStripMenuItem_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(49, 20);
            this.tsmSobre.Text = "Sobre";
            this.tsmSobre.Click += new System.EventHandler(this.tsmSobre_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(38, 20);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Telas.Properties.Resources.Plano_de_fundo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pbxMoto
            // 
            this.pbxMoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMoto.Image = global::Telas.Properties.Resources.moto;
            this.pbxMoto.Location = new System.Drawing.Point(0, 24);
            this.pbxMoto.Name = "pbxMoto";
            this.pbxMoto.Size = new System.Drawing.Size(654, 304);
            this.pbxMoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMoto.TabIndex = 40;
            this.pbxMoto.TabStop = false;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Código da venda";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Valortotal
            // 
            this.Valortotal.HeaderText = "Valor Total";
            this.Valortotal.Name = "Valortotal";
            this.Valortotal.ReadOnly = true;
            this.Valortotal.Width = 86;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 157;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 160;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Selecione
            // 
            this.Selecione.HeaderText = "Selecione";
            this.Selecione.Name = "Selecione";
            this.Selecione.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecione.Width = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecione,
            this.Status,
            this.Cliente,
            this.Bairro,
            this.Valortotal,
            this.Codigo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(512, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(130, 94);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEntregaspendentes);
            this.Controls.Add(this.lblUsuarioativo);
            this.Controls.Add(this.pbxMoto);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Delivery";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPainel_KeyDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnEntregaspendentes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioativo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmNovopedido;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrarcliente;
        private System.Windows.Forms.ToolStripMenuItem tsmClientescadastrados;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdicionarprodutos;
        private System.Windows.Forms.ToolStripMenuItem bairrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBairroscadastrados;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmAlterarsenha;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutoscadastrados;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrador;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrarusuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem usuáriosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesGeraisToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbxMoto;
        private System.Windows.Forms.ToolStripMenuItem bairrosCadastradosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecione;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

