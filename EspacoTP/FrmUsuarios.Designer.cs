using System;
using System.Windows.Forms;

namespace EspacoTP
{
    partial class FrmUsuarios
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
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.grpDetalhes = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpTipoUsuario = new System.Windows.Forms.GroupBox();
            this.radPadrao = new System.Windows.Forms.RadioButton();
            this.radAdministrador = new System.Windows.Forms.RadioButton();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.grpDetalhes.SuspendLayout();
            this.grpTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.grdUsuarios);
            this.grpUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(546, 231);
            this.grpUsuarios.TabIndex = 0;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Cadastro de Usuários";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.AllowUserToResizeColumns = false;
            this.grdUsuarios.AllowUserToResizeRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colUsuario,
            this.colSenha,
            this.colAdmin,
            this.colAtivo});
            this.grdUsuarios.Location = new System.Drawing.Point(11, 21);
            this.grdUsuarios.MultiSelect = false;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowHeadersVisible = false;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(518, 195);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.TabStop = false;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellClick);
            this.grdUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellEnter);
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
            this.grpDetalhes.Controls.Add(this.lbNome);
            this.grpDetalhes.Controls.Add(this.txtNome);
            this.grpDetalhes.Controls.Add(this.grpTipoUsuario);
            this.grpDetalhes.Controls.Add(this.chkAtivo);
            this.grpDetalhes.Controls.Add(this.lbSenha);
            this.grpDetalhes.Controls.Add(this.txtSenha);
            this.grpDetalhes.Controls.Add(this.lbUsuario);
            this.grpDetalhes.Controls.Add(this.txtUsuario);
            this.grpDetalhes.Controls.Add(this.txtCodigo);
            this.grpDetalhes.Controls.Add(this.lbCodigo);
            this.grpDetalhes.Location = new System.Drawing.Point(12, 301);
            this.grpDetalhes.Name = "grpDetalhes";
            this.grpDetalhes.Size = new System.Drawing.Size(546, 206);
            this.grpDetalhes.TabIndex = 2;
            this.grpDetalhes.TabStop = false;
            this.grpDetalhes.Text = "Detalhes";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNome.Location = new System.Drawing.Point(98, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 8;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(98, 38);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(430, 20);
            this.txtNome.TabIndex = 9;
            // 
            // grpTipoUsuario
            // 
            this.grpTipoUsuario.Controls.Add(this.radPadrao);
            this.grpTipoUsuario.Controls.Add(this.radAdministrador);
            this.grpTipoUsuario.Location = new System.Drawing.Point(11, 134);
            this.grpTipoUsuario.Name = "grpTipoUsuario";
            this.grpTipoUsuario.Size = new System.Drawing.Size(518, 55);
            this.grpTipoUsuario.TabIndex = 7;
            this.grpTipoUsuario.TabStop = false;
            this.grpTipoUsuario.Text = "Tipo de Usuário";
            // 
            // radPadrao
            // 
            this.radPadrao.AutoSize = true;
            this.radPadrao.Checked = true;
            this.radPadrao.Location = new System.Drawing.Point(18, 25);
            this.radPadrao.Name = "radPadrao";
            this.radPadrao.Size = new System.Drawing.Size(59, 17);
            this.radPadrao.TabIndex = 0;
            this.radPadrao.TabStop = true;
            this.radPadrao.Text = "Padrão";
            this.radPadrao.UseVisualStyleBackColor = true;
            // 
            // radAdministrador
            // 
            this.radAdministrador.AutoSize = true;
            this.radAdministrador.Location = new System.Drawing.Point(96, 25);
            this.radAdministrador.Name = "radAdministrador";
            this.radAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radAdministrador.TabIndex = 1;
            this.radAdministrador.Text = "Administrador";
            this.radAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkAtivo.Location = new System.Drawing.Point(453, 87);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSenha.Location = new System.Drawing.Point(397, 71);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(397, 87);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(50, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUsuario.Location = new System.Drawing.Point(94, 71);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(94, 87);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(297, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 39);
            this.txtCodigo.MaxLength = 11;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(11, 23);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colId.DataPropertyName = "id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MaxInputLength = 11;
            this.colId.MinimumWidth = 70;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 70;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "NOME";
            this.colNome.MaxInputLength = 40;
            this.colNome.MinimumWidth = 190;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 190;
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUsuario.DataPropertyName = "usuario";
            this.colUsuario.HeaderText = "USUÁRIO";
            this.colUsuario.MaxInputLength = 20;
            this.colUsuario.MinimumWidth = 160;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 160;
            // 
            // colSenha
            // 
            this.colSenha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSenha.DataPropertyName = "senha";
            this.colSenha.HeaderText = "SENHA";
            this.colSenha.MaxInputLength = 8;
            this.colSenha.Name = "colSenha";
            this.colSenha.ReadOnly = true;
            this.colSenha.Visible = false;
            // 
            // colAdmin
            // 
            this.colAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAdmin.DataPropertyName = "admin";
            this.colAdmin.HeaderText = "ADMIN";
            this.colAdmin.MinimumWidth = 50;
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.ReadOnly = true;
            this.colAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAdmin.Width = 50;
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
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 519);
            this.Controls.Add(this.grpDetalhes);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpUsuarios);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - USUÁRIOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.grpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.grpTipoUsuario.ResumeLayout(false);
            this.grpTipoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.GroupBox grpTipoUsuario;
        private System.Windows.Forms.RadioButton radPadrao;
        private System.Windows.Forms.RadioButton radAdministrador;
        private Label lbNome;
        private TextBox txtNome;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colSenha;
        private DataGridViewCheckBoxColumn colAdmin;
        private DataGridViewCheckBoxColumn colAtivo;
    }
}