namespace EspacoTP
{
    partial class FrmPeriodos
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
            this.txtCodigoPeriodo = new System.Windows.Forms.TextBox();
            this.lbCodigoPeriodo = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.txtCodigoAluno = new System.Windows.Forms.TextBox();
            this.lbCodigoAluno = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.grpPeriodos = new System.Windows.Forms.GroupBox();
            this.grdPeriodos = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.colIdPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdDiaAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdHorarioAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalhes.SuspendLayout();
            this.grpPeriodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriodos)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalhes
            // 
            this.grpDetalhes.Controls.Add(this.txtCodigoPeriodo);
            this.grpDetalhes.Controls.Add(this.lbCodigoPeriodo);
            this.grpDetalhes.Controls.Add(this.lbHorario);
            this.grpDetalhes.Controls.Add(this.cboHorario);
            this.grpDetalhes.Controls.Add(this.txtCodigoAluno);
            this.grpDetalhes.Controls.Add(this.lbCodigoAluno);
            this.grpDetalhes.Controls.Add(this.lbDia);
            this.grpDetalhes.Controls.Add(this.cboDia);
            this.grpDetalhes.Location = new System.Drawing.Point(14, 378);
            this.grpDetalhes.Name = "grpDetalhes";
            this.grpDetalhes.Size = new System.Drawing.Size(546, 87);
            this.grpDetalhes.TabIndex = 0;
            this.grpDetalhes.TabStop = false;
            this.grpDetalhes.Text = "Detalhes";
            // 
            // txtCodigoPeriodo
            // 
            this.txtCodigoPeriodo.Enabled = false;
            this.txtCodigoPeriodo.Location = new System.Drawing.Point(93, 64);
            this.txtCodigoPeriodo.MaxLength = 11;
            this.txtCodigoPeriodo.Name = "txtCodigoPeriodo";
            this.txtCodigoPeriodo.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoPeriodo.TabIndex = 16;
            this.txtCodigoPeriodo.Visible = false;
            // 
            // lbCodigoPeriodo
            // 
            this.lbCodigoPeriodo.AutoSize = true;
            this.lbCodigoPeriodo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigoPeriodo.Location = new System.Drawing.Point(11, 76);
            this.lbCodigoPeriodo.Name = "lbCodigoPeriodo";
            this.lbCodigoPeriodo.Size = new System.Drawing.Size(81, 13);
            this.lbCodigoPeriodo.TabIndex = 15;
            this.lbCodigoPeriodo.Text = "Código Período";
            this.lbCodigoPeriodo.Visible = false;
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(372, 21);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(41, 13);
            this.lbHorario.TabIndex = 13;
            this.lbHorario.Text = "Horário";
            // 
            // cboHorario
            // 
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(372, 40);
            this.cboHorario.MaxLength = 8;
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(137, 21);
            this.cboHorario.TabIndex = 14;
            // 
            // txtCodigoAluno
            // 
            this.txtCodigoAluno.Enabled = false;
            this.txtCodigoAluno.Location = new System.Drawing.Point(11, 40);
            this.txtCodigoAluno.MaxLength = 11;
            this.txtCodigoAluno.Name = "txtCodigoAluno";
            this.txtCodigoAluno.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoAluno.TabIndex = 8;
            // 
            // lbCodigoAluno
            // 
            this.lbCodigoAluno.AutoSize = true;
            this.lbCodigoAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigoAluno.Location = new System.Drawing.Point(11, 21);
            this.lbCodigoAluno.Name = "lbCodigoAluno";
            this.lbCodigoAluno.Size = new System.Drawing.Size(70, 13);
            this.lbCodigoAluno.TabIndex = 7;
            this.lbCodigoAluno.Text = "Código Aluno";
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(187, 21);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(23, 13);
            this.lbDia.TabIndex = 11;
            this.lbDia.Text = "Dia";
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(187, 40);
            this.cboDia.MaxLength = 8;
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(137, 21);
            this.cboDia.TabIndex = 12;
            // 
            // grpPeriodos
            // 
            this.grpPeriodos.Controls.Add(this.grdPeriodos);
            this.grpPeriodos.Location = new System.Drawing.Point(14, 12);
            this.grpPeriodos.Name = "grpPeriodos";
            this.grpPeriodos.Size = new System.Drawing.Size(546, 297);
            this.grpPeriodos.TabIndex = 5;
            this.grpPeriodos.TabStop = false;
            this.grpPeriodos.Text = "Períodos de aula";
            // 
            // grdPeriodos
            // 
            this.grdPeriodos.AllowUserToAddRows = false;
            this.grdPeriodos.AllowUserToDeleteRows = false;
            this.grdPeriodos.AllowUserToResizeColumns = false;
            this.grdPeriodos.AllowUserToResizeRows = false;
            this.grdPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPeriodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPeriodo,
            this.colIdDiaAgendamento,
            this.colDia,
            this.colIdHorarioAgendamento,
            this.colHora});
            this.grdPeriodos.Location = new System.Drawing.Point(11, 21);
            this.grdPeriodos.MultiSelect = false;
            this.grdPeriodos.Name = "grdPeriodos";
            this.grdPeriodos.ReadOnly = true;
            this.grdPeriodos.RowHeadersVisible = false;
            this.grdPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPeriodos.Size = new System.Drawing.Size(518, 259);
            this.grdPeriodos.TabIndex = 0;
            this.grdPeriodos.TabStop = false;
            this.grdPeriodos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPeriodos_CellClick);
            this.grdPeriodos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPeriodos_CellEnter);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnDesfazer);
            this.pnlBotoes.Location = new System.Drawing.Point(14, 323);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 47);
            this.pnlBotoes.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(92, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            // colIdPeriodo
            // 
            this.colIdPeriodo.DataPropertyName = "id_periodo";
            this.colIdPeriodo.HeaderText = "ID PERIODO";
            this.colIdPeriodo.MinimumWidth = 100;
            this.colIdPeriodo.Name = "colIdPeriodo";
            this.colIdPeriodo.ReadOnly = true;
            // 
            // colIdDiaAgendamento
            // 
            this.colIdDiaAgendamento.DataPropertyName = "id_dia_agendamento";
            this.colIdDiaAgendamento.HeaderText = "ID DIA";
            this.colIdDiaAgendamento.MinimumWidth = 70;
            this.colIdDiaAgendamento.Name = "colIdDiaAgendamento";
            this.colIdDiaAgendamento.ReadOnly = true;
            this.colIdDiaAgendamento.Visible = false;
            this.colIdDiaAgendamento.Width = 70;
            // 
            // colDia
            // 
            this.colDia.DataPropertyName = "dia";
            this.colDia.HeaderText = "DIA";
            this.colDia.MinimumWidth = 150;
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 150;
            // 
            // colIdHorarioAgendamento
            // 
            this.colIdHorarioAgendamento.DataPropertyName = "id_horario_agendamento";
            this.colIdHorarioAgendamento.HeaderText = "ID HORA";
            this.colIdHorarioAgendamento.MinimumWidth = 130;
            this.colIdHorarioAgendamento.Name = "colIdHorarioAgendamento";
            this.colIdHorarioAgendamento.ReadOnly = true;
            this.colIdHorarioAgendamento.Visible = false;
            this.colIdHorarioAgendamento.Width = 130;
            // 
            // colHora
            // 
            this.colHora.DataPropertyName = "hora";
            this.colHora.HeaderText = "HORA";
            this.colHora.MinimumWidth = 150;
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.Width = 150;
            // 
            // FrmPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 478);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpPeriodos);
            this.Controls.Add(this.grpDetalhes);
            this.Name = "FrmPeriodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - PERÍODOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPeriodos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPeriodos_Load);
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.grpPeriodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriodos)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.GroupBox grpPeriodos;
        private System.Windows.Forms.DataGridView grdPeriodos;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.TextBox txtCodigoAluno;
        private System.Windows.Forms.Label lbCodigoAluno;
        private System.Windows.Forms.TextBox txtCodigoPeriodo;
        private System.Windows.Forms.Label lbCodigoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDiaAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHorarioAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
    }
}