namespace EspacoTP
{
    partial class FrmAgendamentos
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
            this.grpDetalhes = new System.Windows.Forms.GroupBox();
            this.txtCodigoAgendamento = new System.Windows.Forms.TextBox();
            this.btnBuscarAlunos = new System.Windows.Forms.Button();
            this.txtCodigoAluno = new System.Windows.Forms.TextBox();
            this.lbCodigoAgendamento = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbInstrutor = new System.Windows.Forms.Label();
            this.cboInstrutor = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grpTurma = new System.Windows.Forms.GroupBox();
            this.grdTurma = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirCronograma = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.colIdAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobrenomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAulaAgendada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpDetalhes.SuspendLayout();
            this.grpTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurma)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalhes
            // 
            this.grpDetalhes.Controls.Add(this.txtCodigoAgendamento);
            this.grpDetalhes.Controls.Add(this.btnBuscarAlunos);
            this.grpDetalhes.Controls.Add(this.txtCodigoAluno);
            this.grpDetalhes.Controls.Add(this.lbCodigoAgendamento);
            this.grpDetalhes.Controls.Add(this.chkAtivo);
            this.grpDetalhes.Controls.Add(this.lbHorario);
            this.grpDetalhes.Controls.Add(this.lbCodigo);
            this.grpDetalhes.Controls.Add(this.lbInstrutor);
            this.grpDetalhes.Controls.Add(this.cboInstrutor);
            this.grpDetalhes.Controls.Add(this.lbData);
            this.grpDetalhes.Controls.Add(this.cboHorario);
            this.grpDetalhes.Controls.Add(this.dtpData);
            this.grpDetalhes.Location = new System.Drawing.Point(14, 268);
            this.grpDetalhes.Name = "grpDetalhes";
            this.grpDetalhes.Size = new System.Drawing.Size(546, 134);
            this.grpDetalhes.TabIndex = 0;
            this.grpDetalhes.TabStop = false;
            this.grpDetalhes.Text = "Detalhes Agendamento de Horários";
            // 
            // txtCodigoAgendamento
            // 
            this.txtCodigoAgendamento.Enabled = false;
            this.txtCodigoAgendamento.Location = new System.Drawing.Point(357, 98);
            this.txtCodigoAgendamento.MaxLength = 11;
            this.txtCodigoAgendamento.Name = "txtCodigoAgendamento";
            this.txtCodigoAgendamento.Size = new System.Drawing.Size(88, 20);
            this.txtCodigoAgendamento.TabIndex = 17;
            // 
            // btnBuscarAlunos
            // 
            this.btnBuscarAlunos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAlunos.Location = new System.Drawing.Point(129, 98);
            this.btnBuscarAlunos.Name = "btnBuscarAlunos";
            this.btnBuscarAlunos.Size = new System.Drawing.Size(88, 23);
            this.btnBuscarAlunos.TabIndex = 15;
            this.btnBuscarAlunos.Text = "&Buscar Aluno";
            this.btnBuscarAlunos.UseVisualStyleBackColor = true;
            this.btnBuscarAlunos.Click += new System.EventHandler(this.btnBuscarAlunos_Click);
            // 
            // txtCodigoAluno
            // 
            this.txtCodigoAluno.Enabled = false;
            this.txtCodigoAluno.Location = new System.Drawing.Point(21, 98);
            this.txtCodigoAluno.MaxLength = 11;
            this.txtCodigoAluno.Name = "txtCodigoAluno";
            this.txtCodigoAluno.Size = new System.Drawing.Size(88, 20);
            this.txtCodigoAluno.TabIndex = 14;
            // 
            // lbCodigoAgendamento
            // 
            this.lbCodigoAgendamento.AutoSize = true;
            this.lbCodigoAgendamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigoAgendamento.Location = new System.Drawing.Point(354, 77);
            this.lbCodigoAgendamento.Name = "lbCodigoAgendamento";
            this.lbCodigoAgendamento.Size = new System.Drawing.Size(109, 13);
            this.lbCodigoAgendamento.TabIndex = 16;
            this.lbCodigoAgendamento.Text = "Código Agendamento";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkAtivo.Location = new System.Drawing.Point(246, 98);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 13;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(142, 21);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(41, 13);
            this.lbHorario.TabIndex = 11;
            this.lbHorario.Text = "Horário";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(18, 77);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(70, 13);
            this.lbCodigo.TabIndex = 5;
            this.lbCodigo.Text = "Código Aluno";
            // 
            // lbInstrutor
            // 
            this.lbInstrutor.AutoSize = true;
            this.lbInstrutor.Location = new System.Drawing.Point(243, 21);
            this.lbInstrutor.Name = "lbInstrutor";
            this.lbInstrutor.Size = new System.Drawing.Size(45, 13);
            this.lbInstrutor.TabIndex = 4;
            this.lbInstrutor.Text = "Instrutor";
            // 
            // cboInstrutor
            // 
            this.cboInstrutor.FormattingEnabled = true;
            this.cboInstrutor.Location = new System.Drawing.Point(246, 40);
            this.cboInstrutor.MaxLength = 40;
            this.cboInstrutor.Name = "cboInstrutor";
            this.cboInstrutor.Size = new System.Drawing.Size(293, 21);
            this.cboInstrutor.TabIndex = 5;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(18, 21);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 6;
            this.lbData.Text = "Data";
            // 
            // cboHorario
            // 
            this.cboHorario.Enabled = false;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(142, 41);
            this.cboHorario.MaxLength = 8;
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(63, 21);
            this.cboHorario.TabIndex = 12;
            this.cboHorario.Text = "07:00";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(18, 41);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(88, 20);
            this.dtpData.TabIndex = 7;
            this.dtpData.Value = new System.DateTime(2017, 10, 26, 0, 0, 0, 0);
            // 
            // grpTurma
            // 
            this.grpTurma.Controls.Add(this.grdTurma);
            this.grpTurma.Location = new System.Drawing.Point(14, 12);
            this.grpTurma.Name = "grpTurma";
            this.grpTurma.Size = new System.Drawing.Size(546, 185);
            this.grpTurma.TabIndex = 5;
            this.grpTurma.TabStop = false;
            this.grpTurma.Text = "Turma";
            // 
            // grdTurma
            // 
            this.grdTurma.AllowUserToAddRows = false;
            this.grdTurma.AllowUserToDeleteRows = false;
            this.grdTurma.AllowUserToResizeColumns = false;
            this.grdTurma.AllowUserToResizeRows = false;
            this.grdTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAgendamento,
            this.colIdAluno,
            this.colNomeAluno,
            this.colSobrenomeAluno,
            this.colIdInstrutor,
            this.colNomeInstrutor,
            this.colAulaAgendada});
            this.grdTurma.Location = new System.Drawing.Point(11, 21);
            this.grdTurma.MultiSelect = false;
            this.grdTurma.Name = "grdTurma";
            this.grdTurma.ReadOnly = true;
            this.grdTurma.RowHeadersVisible = false;
            this.grdTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTurma.Size = new System.Drawing.Size(518, 146);
            this.grdTurma.TabIndex = 0;
            this.grdTurma.TabStop = false;
            this.grdTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTurma_CellClick);
            this.grdTurma.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTurma_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnImprimirCronograma);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnDesfazer);
            this.panel1.Location = new System.Drawing.Point(12, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 47);
            this.panel1.TabIndex = 7;
            // 
            // btnImprimirCronograma
            // 
            this.btnImprimirCronograma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimirCronograma.Location = new System.Drawing.Point(173, 12);
            this.btnImprimirCronograma.Name = "btnImprimirCronograma";
            this.btnImprimirCronograma.Size = new System.Drawing.Size(125, 23);
            this.btnImprimirCronograma.TabIndex = 8;
            this.btnImprimirCronograma.Text = "Im&primir Cronograma";
            this.btnImprimirCronograma.UseVisualStyleBackColor = true;
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
            // colIdAgendamento
            // 
            this.colIdAgendamento.DataPropertyName = "id_agendamento";
            this.colIdAgendamento.HeaderText = "ID AGEND";
            this.colIdAgendamento.MinimumWidth = 90;
            this.colIdAgendamento.Name = "colIdAgendamento";
            this.colIdAgendamento.ReadOnly = true;
            this.colIdAgendamento.Width = 90;
            // 
            // colIdAluno
            // 
            this.colIdAluno.DataPropertyName = "id_aluno";
            this.colIdAluno.HeaderText = "ID ALUNO";
            this.colIdAluno.MinimumWidth = 90;
            this.colIdAluno.Name = "colIdAluno";
            this.colIdAluno.ReadOnly = true;
            this.colIdAluno.Width = 90;
            // 
            // colNomeAluno
            // 
            this.colNomeAluno.DataPropertyName = "nome_aluno";
            this.colNomeAluno.HeaderText = "NOME";
            this.colNomeAluno.MinimumWidth = 130;
            this.colNomeAluno.Name = "colNomeAluno";
            this.colNomeAluno.ReadOnly = true;
            this.colNomeAluno.Width = 130;
            // 
            // colSobrenomeAluno
            // 
            this.colSobrenomeAluno.DataPropertyName = "sobrenome_aluno";
            this.colSobrenomeAluno.HeaderText = "SOBRENOME";
            this.colSobrenomeAluno.MinimumWidth = 130;
            this.colSobrenomeAluno.Name = "colSobrenomeAluno";
            this.colSobrenomeAluno.ReadOnly = true;
            this.colSobrenomeAluno.Width = 130;
            // 
            // colIdInstrutor
            // 
            this.colIdInstrutor.DataPropertyName = "id_instrutor";
            this.colIdInstrutor.HeaderText = "ID INS";
            this.colIdInstrutor.Name = "colIdInstrutor";
            this.colIdInstrutor.ReadOnly = true;
            this.colIdInstrutor.Visible = false;
            // 
            // colNomeInstrutor
            // 
            this.colNomeInstrutor.DataPropertyName = "nome_instrutor";
            this.colNomeInstrutor.HeaderText = "NOME INS";
            this.colNomeInstrutor.Name = "colNomeInstrutor";
            this.colNomeInstrutor.ReadOnly = true;
            this.colNomeInstrutor.Visible = false;
            // 
            // colAulaAgendada
            // 
            this.colAulaAgendada.DataPropertyName = "aula_agendada";
            this.colAulaAgendada.HeaderText = "ATIVO";
            this.colAulaAgendada.MinimumWidth = 70;
            this.colAulaAgendada.Name = "colAulaAgendada";
            this.colAulaAgendada.ReadOnly = true;
            this.colAulaAgendada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAulaAgendada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAulaAgendada.Width = 70;
            // 
            // FrmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTurma);
            this.Controls.Add(this.grpDetalhes);
            this.Name = "FrmAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - AGENDAMENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgendamentos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgendamentos_Load);
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.grpTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTurma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Label lbInstrutor;
        private System.Windows.Forms.ComboBox cboInstrutor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.GroupBox grpTurma;
        private System.Windows.Forms.DataGridView grdTurma;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.TextBox txtCodigoAluno;
        private System.Windows.Forms.Button btnBuscarAlunos;
        private System.Windows.Forms.TextBox txtCodigoAgendamento;
        private System.Windows.Forms.Label lbCodigoAgendamento;
        private System.Windows.Forms.Button btnImprimirCronograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobrenomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeInstrutor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAulaAgendada;
    }
}