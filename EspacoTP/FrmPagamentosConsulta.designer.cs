namespace EspacoTP
{
    partial class FrmPagamentosConsulta
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grpConsultaPagamentos = new System.Windows.Forms.GroupBox();
            this.pnlBotoesFiltro = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpPeriodoVencimentoTitulo = new System.Windows.Forms.GroupBox();
            this.dtpPeriodoAte = new System.Windows.Forms.DateTimePicker();
            this.lbPeriodoAte = new System.Windows.Forms.Label();
            this.dtpPeriodoDe = new System.Windows.Forms.DateTimePicker();
            this.lbPeriodoDe = new System.Windows.Forms.Label();
            this.lbSituacaoTitulo = new System.Windows.Forms.Label();
            this.cboSituacaoTitulo = new System.Windows.Forms.ComboBox();
            this.btnAlunosBusca = new System.Windows.Forms.Button();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.grdConsultaPagamentos = new System.Windows.Forms.DataGridView();
            this.pnlBotoes.SuspendLayout();
            this.grpConsultaPagamentos.SuspendLayout();
            this.pnlBotoesFiltro.SuspendLayout();
            this.grpPeriodoVencimentoTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.button4);
            this.pnlBotoes.Controls.Add(this.button5);
            this.pnlBotoes.Controls.Add(this.button6);
            this.pnlBotoes.Controls.Add(this.button3);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 453);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 74);
            this.pnlBotoes.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(427, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Imprimir Relatório";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(229, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "&Bonificar Título";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(11, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "&Cancelar Título";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(427, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "D&etalhar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(229, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 23);
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
            this.btnIncluir.Size = new System.Drawing.Size(101, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // grpConsultaPagamentos
            // 
            this.grpConsultaPagamentos.Controls.Add(this.pnlBotoesFiltro);
            this.grpConsultaPagamentos.Controls.Add(this.grpPeriodoVencimentoTitulo);
            this.grpConsultaPagamentos.Controls.Add(this.lbSituacaoTitulo);
            this.grpConsultaPagamentos.Controls.Add(this.cboSituacaoTitulo);
            this.grpConsultaPagamentos.Controls.Add(this.btnAlunosBusca);
            this.grpConsultaPagamentos.Controls.Add(this.lbNomeAluno);
            this.grpConsultaPagamentos.Controls.Add(this.txtNomeAluno);
            this.grpConsultaPagamentos.Controls.Add(this.txtCodigo);
            this.grpConsultaPagamentos.Controls.Add(this.lbCodigo);
            this.grpConsultaPagamentos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaPagamentos.Name = "grpConsultaPagamentos";
            this.grpConsultaPagamentos.Size = new System.Drawing.Size(546, 144);
            this.grpConsultaPagamentos.TabIndex = 0;
            this.grpConsultaPagamentos.TabStop = false;
            this.grpConsultaPagamentos.Text = "Consulta Títulos de Pagamento";
            // 
            // pnlBotoesFiltro
            // 
            this.pnlBotoesFiltro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoesFiltro.Controls.Add(this.btnBuscar);
            this.pnlBotoesFiltro.Controls.Add(this.btnLimpar);
            this.pnlBotoesFiltro.Location = new System.Drawing.Point(340, 80);
            this.pnlBotoesFiltro.Name = "pnlBotoesFiltro";
            this.pnlBotoesFiltro.Size = new System.Drawing.Size(189, 47);
            this.pnlBotoesFiltro.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(96, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(15, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // grpPeriodoVencimentoTitulo
            // 
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpPeriodoAte);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbPeriodoAte);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpPeriodoDe);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbPeriodoDe);
            this.grpPeriodoVencimentoTitulo.Location = new System.Drawing.Point(6, 72);
            this.grpPeriodoVencimentoTitulo.Name = "grpPeriodoVencimentoTitulo";
            this.grpPeriodoVencimentoTitulo.Size = new System.Drawing.Size(325, 66);
            this.grpPeriodoVencimentoTitulo.TabIndex = 7;
            this.grpPeriodoVencimentoTitulo.TabStop = false;
            this.grpPeriodoVencimentoTitulo.Text = "Período Vencimento Título";
            // 
            // dtpPeriodoAte
            // 
            this.dtpPeriodoAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoAte.Location = new System.Drawing.Point(141, 35);
            this.dtpPeriodoAte.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpPeriodoAte.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpPeriodoAte.Name = "dtpPeriodoAte";
            this.dtpPeriodoAte.Size = new System.Drawing.Size(106, 20);
            this.dtpPeriodoAte.TabIndex = 3;
            this.dtpPeriodoAte.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // lbPeriodoAte
            // 
            this.lbPeriodoAte.AutoSize = true;
            this.lbPeriodoAte.Location = new System.Drawing.Point(141, 18);
            this.lbPeriodoAte.Name = "lbPeriodoAte";
            this.lbPeriodoAte.Size = new System.Drawing.Size(23, 13);
            this.lbPeriodoAte.TabIndex = 2;
            this.lbPeriodoAte.Text = "Até";
            // 
            // dtpPeriodoDe
            // 
            this.dtpPeriodoDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoDe.Location = new System.Drawing.Point(19, 35);
            this.dtpPeriodoDe.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpPeriodoDe.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpPeriodoDe.Name = "dtpPeriodoDe";
            this.dtpPeriodoDe.Size = new System.Drawing.Size(106, 20);
            this.dtpPeriodoDe.TabIndex = 1;
            this.dtpPeriodoDe.Value = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            // 
            // lbPeriodoDe
            // 
            this.lbPeriodoDe.AutoSize = true;
            this.lbPeriodoDe.Location = new System.Drawing.Point(19, 18);
            this.lbPeriodoDe.Name = "lbPeriodoDe";
            this.lbPeriodoDe.Size = new System.Drawing.Size(21, 13);
            this.lbPeriodoDe.TabIndex = 0;
            this.lbPeriodoDe.Text = "De";
            // 
            // lbSituacaoTitulo
            // 
            this.lbSituacaoTitulo.AutoSize = true;
            this.lbSituacaoTitulo.Location = new System.Drawing.Point(374, 27);
            this.lbSituacaoTitulo.Name = "lbSituacaoTitulo";
            this.lbSituacaoTitulo.Size = new System.Drawing.Size(80, 13);
            this.lbSituacaoTitulo.TabIndex = 5;
            this.lbSituacaoTitulo.Text = "Situação Título";
            // 
            // cboSituacaoTitulo
            // 
            this.cboSituacaoTitulo.FormattingEnabled = true;
            this.cboSituacaoTitulo.Location = new System.Drawing.Point(374, 43);
            this.cboSituacaoTitulo.MaxLength = 8;
            this.cboSituacaoTitulo.Name = "cboSituacaoTitulo";
            this.cboSituacaoTitulo.Size = new System.Drawing.Size(155, 21);
            this.cboSituacaoTitulo.TabIndex = 6;
            // 
            // btnAlunosBusca
            // 
            this.btnAlunosBusca.Enabled = false;
            this.btnAlunosBusca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlunosBusca.Location = new System.Drawing.Point(347, 43);
            this.btnAlunosBusca.Name = "btnAlunosBusca";
            this.btnAlunosBusca.Size = new System.Drawing.Size(23, 23);
            this.btnAlunosBusca.TabIndex = 4;
            this.btnAlunosBusca.Text = "+";
            this.btnAlunosBusca.UseVisualStyleBackColor = true;
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNomeAluno.Location = new System.Drawing.Point(96, 27);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(34, 13);
            this.lbNomeAluno.TabIndex = 2;
            this.lbNomeAluno.Text = "Aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(96, 43);
            this.txtNomeAluno.MaxLength = 6;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(244, 20);
            this.txtNomeAluno.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 43);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 20);
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
            // grdConsultaPagamentos
            // 
            this.grdConsultaPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaPagamentos.Location = new System.Drawing.Point(12, 165);
            this.grdConsultaPagamentos.Name = "grdConsultaPagamentos";
            this.grdConsultaPagamentos.Size = new System.Drawing.Size(546, 279);
            this.grdConsultaPagamentos.TabIndex = 1;
            // 
            // FrmPagamentosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 538);
            this.Controls.Add(this.grdConsultaPagamentos);
            this.Controls.Add(this.grpConsultaPagamentos);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "FrmPagamentosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - CONSULTA PAGAMENTOS";
            this.pnlBotoes.ResumeLayout(false);
            this.grpConsultaPagamentos.ResumeLayout(false);
            this.grpConsultaPagamentos.PerformLayout();
            this.pnlBotoesFiltro.ResumeLayout(false);
            this.grpPeriodoVencimentoTitulo.ResumeLayout(false);
            this.grpPeriodoVencimentoTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpConsultaPagamentos;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnAlunosBusca;
        private System.Windows.Forms.Label lbSituacaoTitulo;
        private System.Windows.Forms.ComboBox cboSituacaoTitulo;
        private System.Windows.Forms.GroupBox grpPeriodoVencimentoTitulo;
        private System.Windows.Forms.DateTimePicker dtpPeriodoAte;
        private System.Windows.Forms.Label lbPeriodoAte;
        private System.Windows.Forms.DateTimePicker dtpPeriodoDe;
        private System.Windows.Forms.Label lbPeriodoDe;
        private System.Windows.Forms.DataGridView grdConsultaPagamentos;
        private System.Windows.Forms.Panel pnlBotoesFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}