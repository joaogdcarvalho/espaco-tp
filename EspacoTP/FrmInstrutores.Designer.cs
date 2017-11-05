namespace EspacoTP
{
    partial class FrmInstrutores
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
            this.grpInstrutores = new System.Windows.Forms.GroupBox();
            this.grdInstrutores = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.grpDetalhes = new System.Windows.Forms.GroupBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.grpInstrutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstrutores)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.grpDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInstrutores
            // 
            this.grpInstrutores.Controls.Add(this.grdInstrutores);
            this.grpInstrutores.Location = new System.Drawing.Point(12, 12);
            this.grpInstrutores.Name = "grpInstrutores";
            this.grpInstrutores.Size = new System.Drawing.Size(546, 231);
            this.grpInstrutores.TabIndex = 0;
            this.grpInstrutores.TabStop = false;
            this.grpInstrutores.Text = "Cadastro de Instrutores";
            // 
            // grdInstrutores
            // 
            this.grdInstrutores.AllowUserToAddRows = false;
            this.grdInstrutores.AllowUserToDeleteRows = false;
            this.grdInstrutores.AllowUserToResizeColumns = false;
            this.grdInstrutores.AllowUserToResizeRows = false;
            this.grdInstrutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInstrutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colSobrenome,
            this.colCpf,
            this.colAtivo});
            this.grdInstrutores.Location = new System.Drawing.Point(12, 21);
            this.grdInstrutores.MultiSelect = false;
            this.grdInstrutores.Name = "grdInstrutores";
            this.grdInstrutores.ReadOnly = true;
            this.grdInstrutores.RowHeadersVisible = false;
            this.grdInstrutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInstrutores.Size = new System.Drawing.Size(518, 195);
            this.grdInstrutores.TabIndex = 0;
            this.grdInstrutores.TabStop = false;
            this.grdInstrutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInstrutores_CellClick);
            this.grdInstrutores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInstrutores_CellEnter);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colId.DataPropertyName = "id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 70;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 70;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "NOME";
            this.colNome.MinimumWidth = 135;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 135;
            // 
            // colSobrenome
            // 
            this.colSobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSobrenome.DataPropertyName = "sobrenome";
            this.colSobrenome.HeaderText = "SOBRENOME";
            this.colSobrenome.MinimumWidth = 135;
            this.colSobrenome.Name = "colSobrenome";
            this.colSobrenome.ReadOnly = true;
            this.colSobrenome.Width = 135;
            // 
            // colCpf
            // 
            this.colCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCpf.DataPropertyName = "cpf";
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAtivo.DataPropertyName = "ativo";
            this.colAtivo.HeaderText = "ATIVO";
            this.colAtivo.MinimumWidth = 50;
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 50;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnDesfazer);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 249);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 47);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(92, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIncluir.Location = new System.Drawing.Point(11, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(453, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(372, 12);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 23);
            this.btnDesfazer.TabIndex = 2;
            this.btnDesfazer.Text = "&Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // grpDetalhes
            // 
            this.grpDetalhes.Controls.Add(this.lbCPF);
            this.grpDetalhes.Controls.Add(this.txtCPF);
            this.grpDetalhes.Controls.Add(this.chkAtivo);
            this.grpDetalhes.Controls.Add(this.lbSobrenome);
            this.grpDetalhes.Controls.Add(this.txtSobrenome);
            this.grpDetalhes.Controls.Add(this.lbNome);
            this.grpDetalhes.Controls.Add(this.txtNome);
            this.grpDetalhes.Controls.Add(this.txtCodigo);
            this.grpDetalhes.Controls.Add(this.lbCodigo);
            this.grpDetalhes.Location = new System.Drawing.Point(12, 301);
            this.grpDetalhes.Name = "grpDetalhes";
            this.grpDetalhes.Size = new System.Drawing.Size(546, 144);
            this.grpDetalhes.TabIndex = 2;
            this.grpDetalhes.TabStop = false;
            this.grpDetalhes.Text = "Detalhes";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCPF.Location = new System.Drawing.Point(8, 71);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 6;
            this.lbCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(11, 87);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(296, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkAtivo.Location = new System.Drawing.Point(313, 87);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSobrenome.Location = new System.Drawing.Point(313, 27);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenome.TabIndex = 4;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(313, 43);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(215, 20);
            this.txtSobrenome.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNome.Location = new System.Drawing.Point(93, 27);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(93, 43);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 43);
            this.txtCodigo.MaxLength = 11;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(8, 27);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // FrmInstrutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 457);
            this.Controls.Add(this.grpDetalhes);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpInstrutores);
            this.Name = "FrmInstrutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - INSTRUTORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInstrutores_FormClosing);
            this.Load += new System.EventHandler(this.FrmInstrutores_Load);
            this.grpInstrutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInstrutores)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInstrutores;
        private System.Windows.Forms.DataGridView grdInstrutores;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}