namespace Telas
{
    partial class frmRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.rbtBuscapordata = new System.Windows.Forms.RadioButton();
            this.rbtBuscaporcliente = new System.Windows.Forms.RadioButton();
            this.rbtBuscaporfuncionario = new System.Windows.Forms.RadioButton();
            this.cbxNomedofuncionario = new System.Windows.Forms.ComboBox();
            this.cbxNomedocliente = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscardata = new System.Windows.Forms.Button();
            this.btnBuscarfuncionario = new System.Windows.Forms.Button();
            this.btnBuscarcliente = new System.Windows.Forms.Button();
            this.gbxSimples = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxAvancado = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNomedofuncionarioAV = new System.Windows.Forms.ComboBox();
            this.cbxNomedoclienteAV = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tsmSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBusca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBusca = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBusca2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxSimples.SuspendLayout();
            this.gbxAvancado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtBuscapordata
            // 
            this.rbtBuscapordata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtBuscapordata.AutoSize = true;
            this.rbtBuscapordata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtBuscapordata.Checked = true;
            this.rbtBuscapordata.Location = new System.Drawing.Point(20, 21);
            this.rbtBuscapordata.Name = "rbtBuscapordata";
            this.rbtBuscapordata.Size = new System.Drawing.Size(99, 17);
            this.rbtBuscapordata.TabIndex = 1;
            this.rbtBuscapordata.TabStop = true;
            this.rbtBuscapordata.Text = "Busca por Data";
            this.rbtBuscapordata.UseVisualStyleBackColor = false;
            this.rbtBuscapordata.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtBuscaporcliente
            // 
            this.rbtBuscaporcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtBuscaporcliente.AutoSize = true;
            this.rbtBuscaporcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtBuscaporcliente.Location = new System.Drawing.Point(20, 44);
            this.rbtBuscaporcliente.Name = "rbtBuscaporcliente";
            this.rbtBuscaporcliente.Size = new System.Drawing.Size(108, 17);
            this.rbtBuscaporcliente.TabIndex = 2;
            this.rbtBuscaporcliente.Text = "Busca por Cliente";
            this.rbtBuscaporcliente.UseVisualStyleBackColor = false;
            this.rbtBuscaporcliente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtBuscaporfuncionario
            // 
            this.rbtBuscaporfuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtBuscaporfuncionario.AutoSize = true;
            this.rbtBuscaporfuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtBuscaporfuncionario.Location = new System.Drawing.Point(20, 67);
            this.rbtBuscaporfuncionario.Name = "rbtBuscaporfuncionario";
            this.rbtBuscaporfuncionario.Size = new System.Drawing.Size(131, 17);
            this.rbtBuscaporfuncionario.TabIndex = 3;
            this.rbtBuscaporfuncionario.Text = "Busca por Funcionário";
            this.rbtBuscaporfuncionario.UseVisualStyleBackColor = false;
            this.rbtBuscaporfuncionario.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // cbxNomedofuncionario
            // 
            this.cbxNomedofuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNomedofuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNomedofuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNomedofuncionario.FormattingEnabled = true;
            this.cbxNomedofuncionario.Location = new System.Drawing.Point(380, 45);
            this.cbxNomedofuncionario.Name = "cbxNomedofuncionario";
            this.cbxNomedofuncionario.Size = new System.Drawing.Size(286, 21);
            this.cbxNomedofuncionario.TabIndex = 1;
            this.cbxNomedofuncionario.Visible = false;
            // 
            // cbxNomedocliente
            // 
            this.cbxNomedocliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNomedocliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNomedocliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNomedocliente.FormattingEnabled = true;
            this.cbxNomedocliente.Location = new System.Drawing.Point(380, 45);
            this.cbxNomedocliente.Name = "cbxNomedocliente";
            this.cbxNomedocliente.Size = new System.Drawing.Size(286, 21);
            this.cbxNomedocliente.TabIndex = 2;
            this.cbxNomedocliente.Visible = false;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(266, 48);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(108, 13);
            this.lblFuncionario.TabIndex = 22;
            this.lblFuncionario.Text = "Nome do Funcionário";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(289, 48);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 13);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Nome do Cliente";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(274, 48);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 13);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "Data (dia/mês/ano)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Funcionario,
            this.Produtos,
            this.Valortotal,
            this.Data,
            this.Bairro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1153, 432);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            this.Funcionario.Width = 200;
            // 
            // Produtos
            // 
            this.Produtos.HeaderText = "Produtos";
            this.Produtos.Name = "Produtos";
            this.Produtos.ReadOnly = true;
            this.Produtos.Width = 300;
            // 
            // Valortotal
            // 
            this.Valortotal.HeaderText = "Valor Total";
            this.Valortotal.Name = "Valortotal";
            this.Valortotal.ReadOnly = true;
            // 
            // Data
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 197;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(551, 623);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 37);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscardata
            // 
            this.btnBuscardata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscardata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscardata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscardata.Location = new System.Drawing.Point(551, 142);
            this.btnBuscardata.Name = "btnBuscardata";
            this.btnBuscardata.Size = new System.Drawing.Size(83, 37);
            this.btnBuscardata.TabIndex = 5;
            this.btnBuscardata.Text = "Buscar por Data";
            this.btnBuscardata.UseVisualStyleBackColor = false;
            this.btnBuscardata.Click += new System.EventHandler(this.btnBuscardata_Click);
            // 
            // btnBuscarfuncionario
            // 
            this.btnBuscarfuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarfuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarfuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarfuncionario.Location = new System.Drawing.Point(551, 142);
            this.btnBuscarfuncionario.Name = "btnBuscarfuncionario";
            this.btnBuscarfuncionario.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarfuncionario.TabIndex = 6;
            this.btnBuscarfuncionario.Text = "Buscar por Funcionário";
            this.btnBuscarfuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarfuncionario.Visible = false;
            this.btnBuscarfuncionario.Click += new System.EventHandler(this.btnBuscarfuncionario_Click);
            // 
            // btnBuscarcliente
            // 
            this.btnBuscarcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarcliente.Location = new System.Drawing.Point(551, 142);
            this.btnBuscarcliente.Name = "btnBuscarcliente";
            this.btnBuscarcliente.Size = new System.Drawing.Size(83, 37);
            this.btnBuscarcliente.TabIndex = 4;
            this.btnBuscarcliente.Text = "Buscar por Cliente";
            this.btnBuscarcliente.UseVisualStyleBackColor = false;
            this.btnBuscarcliente.Visible = false;
            this.btnBuscarcliente.Click += new System.EventHandler(this.btnBuscarcliente_Click);
            // 
            // gbxSimples
            // 
            this.gbxSimples.Controls.Add(this.rbtBuscaporfuncionario);
            this.gbxSimples.Controls.Add(this.dateTimePicker1);
            this.gbxSimples.Controls.Add(this.rbtBuscaporcliente);
            this.gbxSimples.Controls.Add(this.rbtBuscapordata);
            this.gbxSimples.Controls.Add(this.lblFuncionario);
            this.gbxSimples.Controls.Add(this.lblCliente);
            this.gbxSimples.Controls.Add(this.lblData);
            this.gbxSimples.Controls.Add(this.cbxNomedocliente);
            this.gbxSimples.Controls.Add(this.cbxNomedofuncionario);
            this.gbxSimples.Location = new System.Drawing.Point(249, 41);
            this.gbxSimples.Name = "gbxSimples";
            this.gbxSimples.Size = new System.Drawing.Size(687, 95);
            this.gbxSimples.TabIndex = 0;
            this.gbxSimples.TabStop = false;
            this.gbxSimples.Text = "Selecione uma das opções e preencha o(s) campo(s) para gerar um relatório:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gbxAvancado
            // 
            this.gbxAvancado.Controls.Add(this.groupBox1);
            this.gbxAvancado.Controls.Add(this.label1);
            this.gbxAvancado.Controls.Add(this.label2);
            this.gbxAvancado.Controls.Add(this.cbxNomedofuncionarioAV);
            this.gbxAvancado.Controls.Add(this.cbxNomedoclienteAV);
            this.gbxAvancado.Location = new System.Drawing.Point(249, 41);
            this.gbxAvancado.Name = "gbxAvancado";
            this.gbxAvancado.Size = new System.Drawing.Size(687, 95);
            this.gbxAvancado.TabIndex = 1;
            this.gbxAvancado.TabStop = false;
            this.gbxAvancado.Text = "Selecione e ou preencha as opções necessárias";
            this.gbxAvancado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Location = new System.Drawing.Point(337, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca entre datas";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(37, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 43;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Segunda data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Primeira data";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(138, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(138, 44);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome do funcionário";
            // 
            // cbxNomedofuncionarioAV
            // 
            this.cbxNomedofuncionarioAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNomedofuncionarioAV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNomedofuncionarioAV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNomedofuncionarioAV.FormattingEnabled = true;
            this.cbxNomedofuncionarioAV.Location = new System.Drawing.Point(124, 54);
            this.cbxNomedofuncionarioAV.Name = "cbxNomedofuncionarioAV";
            this.cbxNomedofuncionarioAV.Size = new System.Drawing.Size(207, 21);
            this.cbxNomedofuncionarioAV.TabIndex = 1;
            // 
            // cbxNomedoclienteAV
            // 
            this.cbxNomedoclienteAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNomedoclienteAV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNomedoclienteAV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNomedoclienteAV.FormattingEnabled = true;
            this.cbxNomedoclienteAV.Location = new System.Drawing.Point(103, 28);
            this.cbxNomedoclienteAV.Name = "cbxNomedoclienteAV";
            this.cbxNomedoclienteAV.Size = new System.Drawing.Size(199, 21);
            this.cbxNomedoclienteAV.TabIndex = 0;
            // 
            // tsmSalvar
            // 
            this.tsmSalvar.Name = "tsmSalvar";
            this.tsmSalvar.Size = new System.Drawing.Size(50, 20);
            this.tsmSalvar.Text = "Salvar";
            this.tsmSalvar.Click += new System.EventHandler(this.tsmSalvarImprimir_Click);
            // 
            // tsmBusca
            // 
            this.tsmBusca.Name = "tsmBusca";
            this.tsmBusca.Size = new System.Drawing.Size(105, 20);
            this.tsmBusca.Text = "Busca Avançada";
            // 
            // btnBusca
            // 
            this.btnBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Location = new System.Drawing.Point(551, 142);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(83, 37);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.tsmBusca2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.enviarToolStripMenuItem.Text = "Enviar";
            this.enviarToolStripMenuItem.ToolTipText = "Envia o relatório por email";
            this.enviarToolStripMenuItem.Click += new System.EventHandler(this.enviarToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // tsmBusca2
            // 
            this.tsmBusca2.Name = "tsmBusca2";
            this.tsmBusca2.Size = new System.Drawing.Size(105, 20);
            this.tsmBusca2.Text = "Busca Avançada";
            this.tsmBusca2.Click += new System.EventHandler(this.buscaAvançadaToolStripMenuItem_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1185, 672);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.gbxAvancado);
            this.Controls.Add(this.btnBuscarcliente);
            this.Controls.Add(this.btnBuscarfuncionario);
            this.Controls.Add(this.btnBuscardata);
            this.Controls.Add(this.gbxSimples);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxSimples.ResumeLayout(false);
            this.gbxSimples.PerformLayout();
            this.gbxAvancado.ResumeLayout(false);
            this.gbxAvancado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtBuscapordata;
        private System.Windows.Forms.RadioButton rbtBuscaporcliente;
        private System.Windows.Forms.RadioButton rbtBuscaporfuncionario;
        private System.Windows.Forms.ComboBox cbxNomedofuncionario;
        private System.Windows.Forms.ComboBox cbxNomedocliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscardata;
        private System.Windows.Forms.Button btnBuscarfuncionario;
        private System.Windows.Forms.Button btnBuscarcliente;
        private System.Windows.Forms.GroupBox gbxSimples;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxAvancado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNomedoclienteAV;
        private System.Windows.Forms.ComboBox cbxNomedofuncionarioAV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmSalvar;
        private System.Windows.Forms.ToolStripMenuItem tsmBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBusca2;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}