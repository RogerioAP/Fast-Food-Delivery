namespace Telas
{
    partial class frmUsuarios_cadastrados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios_cadastrados));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovocliente = new System.Windows.Forms.Button();
            this.btnExcluircliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditarcliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nomecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodeconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nome";
            // 
            // btnNovocliente
            // 
            this.btnNovocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovocliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovocliente.Location = new System.Drawing.Point(527, 150);
            this.btnNovocliente.Name = "btnNovocliente";
            this.btnNovocliente.Size = new System.Drawing.Size(87, 35);
            this.btnNovocliente.TabIndex = 4;
            this.btnNovocliente.Text = "Novo Usuário";
            this.btnNovocliente.UseVisualStyleBackColor = false;
            this.btnNovocliente.Click += new System.EventHandler(this.btnNovocliente_Click);
            // 
            // btnExcluircliente
            // 
            this.btnExcluircliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluircliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluircliente.Location = new System.Drawing.Point(527, 109);
            this.btnExcluircliente.Name = "btnExcluircliente";
            this.btnExcluircliente.Size = new System.Drawing.Size(87, 35);
            this.btnExcluircliente.TabIndex = 3;
            this.btnExcluircliente.Text = "Excluir Usuário";
            this.btnExcluircliente.UseVisualStyleBackColor = false;
            this.btnExcluircliente.Click += new System.EventHandler(this.btnExcluircliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(527, 191);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditarcliente
            // 
            this.btnEditarcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarcliente.Location = new System.Drawing.Point(527, 68);
            this.btnEditarcliente.Name = "btnEditarcliente";
            this.btnEditarcliente.Size = new System.Drawing.Size(87, 35);
            this.btnEditarcliente.TabIndex = 2;
            this.btnEditarcliente.Text = "Editar Usuário";
            this.btnEditarcliente.UseVisualStyleBackColor = false;
            this.btnEditarcliente.Click += new System.EventHandler(this.btnEditarcliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomecompleto,
            this.Tipodeconta,
            this.Email,
            this.idUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 343);
            this.dataGridView1.TabIndex = 66;
            // 
            // Nomecompleto
            // 
            this.Nomecompleto.HeaderText = "Nome Completo";
            this.Nomecompleto.Name = "Nomecompleto";
            this.Nomecompleto.ReadOnly = true;
            this.Nomecompleto.Width = 180;
            // 
            // Tipodeconta
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipodeconta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tipodeconta.HeaderText = "Tipo de Conta";
            this.Tipodeconta.Name = "Tipodeconta";
            this.Tipodeconta.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 163;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuário";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(462, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(116, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(340, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Tem uma coluna oculta!";
            this.label2.Visible = false;
            // 
            // frmUsuarios_cadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovocliente);
            this.Controls.Add(this.btnExcluircliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditarcliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarios_cadastrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários Cadastrados";
            this.Load += new System.EventHandler(this.Usuarios_cadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovocliente;
        private System.Windows.Forms.Button btnExcluircliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditarcliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodeconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.Label label2;
    }
}