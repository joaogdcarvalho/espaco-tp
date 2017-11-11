namespace EspacoTP
{
    partial class FrmAlunosConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunosConsulta));
            this.grpConsultaAlunos = new System.Windows.Forms.GroupBox();
            this.grpPeriodoContrato = new System.Windows.Forms.GroupBox();
            this.dtpDataTerminoContrato = new System.Windows.Forms.DateTimePicker();
            this.lbDataTerminoContrato = new System.Windows.Forms.Label();
            this.dtpDataInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicioContrato = new System.Windows.Forms.Label();
            this.pnlBotoesFiltro = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenomeAluno = new System.Windows.Forms.TextBox();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSelecionarAluno = new System.Windows.Forms.Button();
            this.grdConsultaAlunos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataInicioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataTerminoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaAlunos.SuspendLayout();
            this.grpPeriodoContrato.SuspendLayout();
            this.pnlBotoesFiltro.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaAlunos
            // 
            this.grpConsultaAlunos.Controls.Add(this.grpPeriodoContrato);
            this.grpConsultaAlunos.Controls.Add(this.pnlBotoesFiltro);
            this.grpConsultaAlunos.Controls.Add(this.lbCPF);
            this.grpConsultaAlunos.Controls.Add(this.txtCPF);
            this.grpConsultaAlunos.Controls.Add(this.lbSobrenome);
            this.grpConsultaAlunos.Controls.Add(this.txtSobrenomeAluno);
            this.grpConsultaAlunos.Controls.Add(this.lbNomeAluno);
            this.grpConsultaAlunos.Controls.Add(this.txtNomeAluno);
            this.grpConsultaAlunos.Controls.Add(this.txtCodigo);
            this.grpConsultaAlunos.Controls.Add(this.lbCodigo);
            this.grpConsultaAlunos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaAlunos.Name = "grpConsultaAlunos";
            this.grpConsultaAlunos.Size = new System.Drawing.Size(546, 156);
            this.grpConsultaAlunos.TabIndex = 0;
            this.grpConsultaAlunos.TabStop = false;
            this.grpConsultaAlunos.Text = "Consulta Alunos";
            // 
            // grpPeriodoContrato
            // 
            this.grpPeriodoContrato.Controls.Add(this.dtpDataTerminoContrato);
            this.grpPeriodoContrato.Controls.Add(this.lbDataTerminoContrato);
            this.grpPeriodoContrato.Controls.Add(this.dtpDataInicioContrato);
            this.grpPeriodoContrato.Controls.Add(this.lbDataInicioContrato);
            this.grpPeriodoContrato.Location = new System.Drawing.Point(10, 73);
            this.grpPeriodoContrato.Name = "grpPeriodoContrato";
            this.grpPeriodoContrato.Size = new System.Drawing.Size(286, 66);
            this.grpPeriodoContrato.TabIndex = 20;
            this.grpPeriodoContrato.TabStop = false;
            this.grpPeriodoContrato.Text = "Período Vigência Contrato";
            // 
            // dtpDataTerminoContrato
            // 
            this.dtpDataTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTerminoContrato.Location = new System.Drawing.Point(125, 35);
            this.dtpDataTerminoContrato.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpDataTerminoContrato.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpDataTerminoContrato.Name = "dtpDataTerminoContrato";
            this.dtpDataTerminoContrato.Size = new System.Drawing.Size(106, 20);
            this.dtpDataTerminoContrato.TabIndex = 3;
            // 
            // lbDataTerminoContrato
            // 
            this.lbDataTerminoContrato.AutoSize = true;
            this.lbDataTerminoContrato.Location = new System.Drawing.Point(128, 18);
            this.lbDataTerminoContrato.Name = "lbDataTerminoContrato";
            this.lbDataTerminoContrato.Size = new System.Drawing.Size(23, 13);
            this.lbDataTerminoContrato.TabIndex = 2;
            this.lbDataTerminoContrato.Text = "Até";
            // 
            // dtpDataInicioContrato
            // 
            this.dtpDataInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicioContrato.Location = new System.Drawing.Point(11, 35);
            this.dtpDataInicioContrato.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicioContrato.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicioContrato.Name = "dtpDataInicioContrato";
            this.dtpDataInicioContrato.Size = new System.Drawing.Size(106, 20);
            this.dtpDataInicioContrato.TabIndex = 1;
            // 
            // lbDataInicioContrato
            // 
            this.lbDataInicioContrato.AutoSize = true;
            this.lbDataInicioContrato.Location = new System.Drawing.Point(14, 18);
            this.lbDataInicioContrato.Name = "lbDataInicioContrato";
            this.lbDataInicioContrato.Size = new System.Drawing.Size(21, 13);
            this.lbDataInicioContrato.TabIndex = 0;
            this.lbDataInicioContrato.Text = "De";
            // 
            // pnlBotoesFiltro
            // 
            this.pnlBotoesFiltro.BackColor = System.Drawing.Color.MintCream;
            this.pnlBotoesFiltro.Controls.Add(this.btnBuscar);
            this.pnlBotoesFiltro.Controls.Add(this.btnLimpar);
            this.pnlBotoesFiltro.Location = new System.Drawing.Point(304, 79);
            this.pnlBotoesFiltro.Name = "pnlBotoesFiltro";
            this.pnlBotoesFiltro.Size = new System.Drawing.Size(234, 60);
            this.pnlBotoesFiltro.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(119, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(38, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCPF.Location = new System.Drawing.Point(398, 27);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 7;
            this.lbCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(398, 43);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(140, 20);
            this.txtCPF.TabIndex = 8;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSobrenome.Location = new System.Drawing.Point(253, 27);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenome.TabIndex = 5;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenomeAluno
            // 
            this.txtSobrenomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenomeAluno.Location = new System.Drawing.Point(253, 43);
            this.txtSobrenomeAluno.MaxLength = 20;
            this.txtSobrenomeAluno.Name = "txtSobrenomeAluno";
            this.txtSobrenomeAluno.Size = new System.Drawing.Size(140, 20);
            this.txtSobrenomeAluno.TabIndex = 6;
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNomeAluno.Location = new System.Drawing.Point(105, 27);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.lbNomeAluno.TabIndex = 3;
            this.lbNomeAluno.Text = "Nome";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Location = new System.Drawing.Point(105, 43);
            this.txtNomeAluno.MaxLength = 20;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(140, 20);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 43);
            this.txtCodigo.MaxLength = 11;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(10, 27);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.MintCream;
            this.pnlBotoes.Controls.Add(this.btnSelecionarAluno);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 550);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 47);
            this.pnlBotoes.TabIndex = 2;
            // 
            // btnSelecionarAluno
            // 
            this.btnSelecionarAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelecionarAluno.Location = new System.Drawing.Point(428, 11);
            this.btnSelecionarAluno.Name = "btnSelecionarAluno";
            this.btnSelecionarAluno.Size = new System.Drawing.Size(100, 23);
            this.btnSelecionarAluno.TabIndex = 0;
            this.btnSelecionarAluno.Text = "&Selecionar Aluno";
            this.btnSelecionarAluno.UseVisualStyleBackColor = true;
            this.btnSelecionarAluno.Click += new System.EventHandler(this.btnSelecionarAluno_Click);
            // 
            // grdConsultaAlunos
            // 
            this.grdConsultaAlunos.AllowUserToAddRows = false;
            this.grdConsultaAlunos.AllowUserToDeleteRows = false;
            this.grdConsultaAlunos.AllowUserToResizeColumns = false;
            this.grdConsultaAlunos.AllowUserToResizeRows = false;
            this.grdConsultaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colSobrenome,
            this.colCpf,
            this.colTipoTelefone,
            this.colNumeroTelefone,
            this.colEmail,
            this.colDataInicioContrato,
            this.colDataTerminoContrato,
            this.colCep,
            this.colLogradouro,
            this.colNumero,
            this.colBairro,
            this.colEstado,
            this.colMunicipio,
            this.colValorAula});
            this.grdConsultaAlunos.Location = new System.Drawing.Point(12, 180);
            this.grdConsultaAlunos.MultiSelect = false;
            this.grdConsultaAlunos.Name = "grdConsultaAlunos";
            this.grdConsultaAlunos.ReadOnly = true;
            this.grdConsultaAlunos.RowHeadersVisible = false;
            this.grdConsultaAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaAlunos.Size = new System.Drawing.Size(546, 357);
            this.grdConsultaAlunos.TabIndex = 1;
            this.grdConsultaAlunos.TabStop = false;
            this.grdConsultaAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaAlunos_CellClick);
            this.grdConsultaAlunos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaAlunos_CellEnter);
            // 
            // colId
            // 
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
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "NOME";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colSobrenome
            // 
            this.colSobrenome.DataPropertyName = "sobrenome";
            this.colSobrenome.HeaderText = "SOBRENOME";
            this.colSobrenome.Name = "colSobrenome";
            this.colSobrenome.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "cpf";
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colTipoTelefone
            // 
            this.colTipoTelefone.DataPropertyName = "tipo_telefone";
            this.colTipoTelefone.HeaderText = "TIPO TELEFONE";
            this.colTipoTelefone.Name = "colTipoTelefone";
            this.colTipoTelefone.ReadOnly = true;
            this.colTipoTelefone.Visible = false;
            // 
            // colNumeroTelefone
            // 
            this.colNumeroTelefone.DataPropertyName = "numero_telefone";
            this.colNumeroTelefone.HeaderText = "NÚMERO TELEFONE";
            this.colNumeroTelefone.Name = "colNumeroTelefone";
            this.colNumeroTelefone.ReadOnly = true;
            this.colNumeroTelefone.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "E-MAIL";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colDataInicioContrato
            // 
            this.colDataInicioContrato.DataPropertyName = "data_inicio_contrato";
            this.colDataInicioContrato.HeaderText = "INÍCIO CONTRATO";
            this.colDataInicioContrato.MinimumWidth = 80;
            this.colDataInicioContrato.Name = "colDataInicioContrato";
            this.colDataInicioContrato.ReadOnly = true;
            this.colDataInicioContrato.Width = 80;
            // 
            // colDataTerminoContrato
            // 
            this.colDataTerminoContrato.DataPropertyName = "data_termino_contrato";
            this.colDataTerminoContrato.HeaderText = "TERMINO CONTRATO";
            this.colDataTerminoContrato.MinimumWidth = 80;
            this.colDataTerminoContrato.Name = "colDataTerminoContrato";
            this.colDataTerminoContrato.ReadOnly = true;
            this.colDataTerminoContrato.Width = 80;
            // 
            // colCep
            // 
            this.colCep.DataPropertyName = "cep";
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            this.colCep.Visible = false;
            // 
            // colLogradouro
            // 
            this.colLogradouro.DataPropertyName = "logradouro";
            this.colLogradouro.HeaderText = "LOGRADOURO";
            this.colLogradouro.Name = "colLogradouro";
            this.colLogradouro.ReadOnly = true;
            this.colLogradouro.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numero_residencial";
            this.colNumero.HeaderText = "NÚMERO";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Visible = false;
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "bairro";
            this.colBairro.HeaderText = "BAIRRO";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Visible = false;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "ESTADO";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Visible = false;
            // 
            // colMunicipio
            // 
            this.colMunicipio.DataPropertyName = "municipio";
            this.colMunicipio.HeaderText = "MUNICÍPIO";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.ReadOnly = true;
            this.colMunicipio.Visible = false;
            // 
            // colValorAula
            // 
            this.colValorAula.DataPropertyName = "valor_aula";
            this.colValorAula.HeaderText = "VALOR AULA";
            this.colValorAula.Name = "colValorAula";
            this.colValorAula.ReadOnly = true;
            this.colValorAula.Visible = false;
            // 
            // FrmAlunosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 607);
            this.Controls.Add(this.grdConsultaAlunos);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpConsultaAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlunosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - CONSULTA ALUNOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlunosConsulta_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlunosConsulta_Load);
            this.grpConsultaAlunos.ResumeLayout(false);
            this.grpConsultaAlunos.PerformLayout();
            this.grpPeriodoContrato.ResumeLayout(false);
            this.grpPeriodoContrato.PerformLayout();
            this.pnlBotoesFiltro.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConsultaAlunos;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox txtSobrenomeAluno;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSelecionarAluno;
        private System.Windows.Forms.Panel pnlBotoesFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView grdConsultaAlunos;
        private System.Windows.Forms.GroupBox grpPeriodoContrato;
        private System.Windows.Forms.DateTimePicker dtpDataTerminoContrato;
        private System.Windows.Forms.Label lbDataTerminoContrato;
        private System.Windows.Forms.DateTimePicker dtpDataInicioContrato;
        private System.Windows.Forms.Label lbDataInicioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataTerminoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorAula;
    }
}