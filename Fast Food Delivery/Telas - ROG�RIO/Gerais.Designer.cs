namespace Telas
{
    partial class frmGerais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerais));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtNaoDesligar = new System.Windows.Forms.RadioButton();
            this.rbtSimDesligar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtNaoIniciar = new System.Windows.Forms.RadioButton();
            this.rbtSimIniciar = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestaradicionar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(130, 272);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 37);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 200);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicialização/Desligamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtNaoDesligar);
            this.groupBox2.Controls.Add(this.rbtSimDesligar);
            this.groupBox2.Location = new System.Drawing.Point(29, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligar o windows quando sair da aplicação";
            // 
            // rbtNaoDesligar
            // 
            this.rbtNaoDesligar.AutoSize = true;
            this.rbtNaoDesligar.Location = new System.Drawing.Point(153, 32);
            this.rbtNaoDesligar.Name = "rbtNaoDesligar";
            this.rbtNaoDesligar.Size = new System.Drawing.Size(45, 17);
            this.rbtNaoDesligar.TabIndex = 5;
            this.rbtNaoDesligar.TabStop = true;
            this.rbtNaoDesligar.Text = "Não";
            this.rbtNaoDesligar.UseVisualStyleBackColor = true;
            this.rbtNaoDesligar.CheckedChanged += new System.EventHandler(this.rbtNaoDesligar_CheckedChanged);
            // 
            // rbtSimDesligar
            // 
            this.rbtSimDesligar.AutoSize = true;
            this.rbtSimDesligar.Location = new System.Drawing.Point(78, 32);
            this.rbtSimDesligar.Name = "rbtSimDesligar";
            this.rbtSimDesligar.Size = new System.Drawing.Size(42, 17);
            this.rbtSimDesligar.TabIndex = 4;
            this.rbtSimDesligar.TabStop = true;
            this.rbtSimDesligar.Text = "Sim";
            this.rbtSimDesligar.UseVisualStyleBackColor = true;
            this.rbtSimDesligar.CheckedChanged += new System.EventHandler(this.rbtSimDesligar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtNaoIniciar);
            this.groupBox1.Controls.Add(this.rbtSimIniciar);
            this.groupBox1.Location = new System.Drawing.Point(29, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar a aplicação quando iniciar o windows";
            // 
            // rbtNaoIniciar
            // 
            this.rbtNaoIniciar.AutoSize = true;
            this.rbtNaoIniciar.Location = new System.Drawing.Point(153, 30);
            this.rbtNaoIniciar.Name = "rbtNaoIniciar";
            this.rbtNaoIniciar.Size = new System.Drawing.Size(45, 17);
            this.rbtNaoIniciar.TabIndex = 3;
            this.rbtNaoIniciar.TabStop = true;
            this.rbtNaoIniciar.Text = "Não";
            this.rbtNaoIniciar.UseVisualStyleBackColor = true;
            this.rbtNaoIniciar.CheckedChanged += new System.EventHandler(this.rbtNaoIniciar_CheckedChanged);
            // 
            // rbtSimIniciar
            // 
            this.rbtSimIniciar.AutoSize = true;
            this.rbtSimIniciar.Location = new System.Drawing.Point(78, 30);
            this.rbtSimIniciar.Name = "rbtSimIniciar";
            this.rbtSimIniciar.Size = new System.Drawing.Size(42, 17);
            this.rbtSimIniciar.TabIndex = 2;
            this.rbtSimIniciar.TabStop = true;
            this.rbtSimIniciar.Text = "Sim";
            this.rbtSimIniciar.UseVisualStyleBackColor = true;
            this.rbtSimIniciar.CheckedChanged += new System.EventHandler(this.rbtSimIniciar_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnTestaradicionar);
            this.tabPage2.Controls.Add(this.txtSenha);
            this.tabPage2.Controls.Add(this.lblSenha);
            this.tabPage2.Controls.Add(this.txtLogin);
            this.tabPage2.Controls.Add(this.lblLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email do Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(193, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "O que é e para que serve?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTestaradicionar
            // 
            this.btnTestaradicionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestaradicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestaradicionar.Location = new System.Drawing.Point(126, 129);
            this.btnTestaradicionar.Name = "btnTestaradicionar";
            this.btnTestaradicionar.Size = new System.Drawing.Size(83, 37);
            this.btnTestaradicionar.TabIndex = 2;
            this.btnTestaradicionar.Text = "Testar e adicionar";
            this.btnTestaradicionar.UseVisualStyleBackColor = false;
            this.btnTestaradicionar.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(112, 90);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(197, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(25, 93);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha do Email";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(112, 41);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(197, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(76, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login do Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Telas.Properties.Resources.Plano_de_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(343, 200);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerais";
            this.Load += new System.EventHandler(this.frmGerais_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnTestaradicionar;
        private System.Windows.Forms.RadioButton rbtNaoDesligar;
        private System.Windows.Forms.RadioButton rbtSimDesligar;
        private System.Windows.Forms.RadioButton rbtNaoIniciar;
        private System.Windows.Forms.RadioButton rbtSimIniciar;
        private System.Windows.Forms.Label label1;
    }
}