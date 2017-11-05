namespace EspacoTP
{
    partial class FrmPagamentosCadastro
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
            this.btnAdicionarObservacao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBonificarTitulo = new System.Windows.Forms.Button();
            this.btnCancelarTitulo = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grpCadastroPagamentos = new System.Windows.Forms.GroupBox();
            this.grpValoresTitulo = new System.Windows.Forms.GroupBox();
            this.lbValorPago = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lbValorTitulo = new System.Windows.Forms.Label();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.lbValorMulta = new System.Windows.Forms.Label();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.nudTaxaMulta = new System.Windows.Forms.NumericUpDown();
            this.lbTaxaMulta = new System.Windows.Forms.Label();
            this.lbValorDesconto = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.nudTaxaDesconto = new System.Windows.Forms.NumericUpDown();
            this.lbTaxaDesconto = new System.Windows.Forms.Label();
            this.lbObservacoes = new System.Windows.Forms.Label();
            this.rtxtObservacoes = new System.Windows.Forms.RichTextBox();
            this.grpPeriodoVencimentoTitulo = new System.Windows.Forms.GroupBox();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.dtpDataCancelamento = new System.Windows.Forms.DateTimePicker();
            this.lbDataCancelamento = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.lbDataVencimento = new System.Windows.Forms.Label();
            this.dtpDataGeracao = new System.Windows.Forms.DateTimePicker();
            this.lbDataGeracao = new System.Windows.Forms.Label();
            this.lbSituacaoTitulo = new System.Windows.Forms.Label();
            this.cboSituacaoTitulo = new System.Windows.Forms.ComboBox();
            this.btnAlunosBusca = new System.Windows.Forms.Button();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.grpCadastroPagamentos.SuspendLayout();
            this.grpValoresTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxaMulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxaDesconto)).BeginInit();
            this.grpPeriodoVencimentoTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.btnAdicionarObservacao);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnBonificarTitulo);
            this.pnlBotoes.Controls.Add(this.btnCancelarTitulo);
            this.pnlBotoes.Controls.Add(this.btnDesfazer);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 431);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 74);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnAdicionarObservacao
            // 
            this.btnAdicionarObservacao.Enabled = false;
            this.btnAdicionarObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarObservacao.Location = new System.Drawing.Point(223, 12);
            this.btnAdicionarObservacao.Name = "btnAdicionarObservacao";
            this.btnAdicionarObservacao.Size = new System.Drawing.Size(132, 23);
            this.btnAdicionarObservacao.TabIndex = 2;
            this.btnAdicionarObservacao.Text = "Adicionar &Observação";
            this.btnAdicionarObservacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(427, 40);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnBonificarTitulo
            // 
            this.btnBonificarTitulo.Enabled = false;
            this.btnBonificarTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBonificarTitulo.Location = new System.Drawing.Point(175, 40);
            this.btnBonificarTitulo.Name = "btnBonificarTitulo";
            this.btnBonificarTitulo.Size = new System.Drawing.Size(101, 23);
            this.btnBonificarTitulo.TabIndex = 4;
            this.btnBonificarTitulo.Text = "&Bonificar Título";
            this.btnBonificarTitulo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTitulo
            // 
            this.btnCancelarTitulo.Enabled = false;
            this.btnCancelarTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelarTitulo.Location = new System.Drawing.Point(68, 40);
            this.btnCancelarTitulo.Name = "btnCancelarTitulo";
            this.btnCancelarTitulo.Size = new System.Drawing.Size(101, 23);
            this.btnCancelarTitulo.TabIndex = 3;
            this.btnCancelarTitulo.Text = "&Cancelar Título";
            this.btnCancelarTitulo.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(427, 12);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(101, 23);
            this.btnDesfazer.TabIndex = 5;
            this.btnDesfazer.Text = "&Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(118, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
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
            // 
            // grpCadastroPagamentos
            // 
            this.grpCadastroPagamentos.Controls.Add(this.grpValoresTitulo);
            this.grpCadastroPagamentos.Controls.Add(this.lbObservacoes);
            this.grpCadastroPagamentos.Controls.Add(this.rtxtObservacoes);
            this.grpCadastroPagamentos.Controls.Add(this.grpPeriodoVencimentoTitulo);
            this.grpCadastroPagamentos.Controls.Add(this.lbSituacaoTitulo);
            this.grpCadastroPagamentos.Controls.Add(this.cboSituacaoTitulo);
            this.grpCadastroPagamentos.Controls.Add(this.btnAlunosBusca);
            this.grpCadastroPagamentos.Controls.Add(this.lbNomeAluno);
            this.grpCadastroPagamentos.Controls.Add(this.txtNomeAluno);
            this.grpCadastroPagamentos.Controls.Add(this.txtCodigo);
            this.grpCadastroPagamentos.Controls.Add(this.lbCodigo);
            this.grpCadastroPagamentos.Location = new System.Drawing.Point(12, 12);
            this.grpCadastroPagamentos.Name = "grpCadastroPagamentos";
            this.grpCadastroPagamentos.Size = new System.Drawing.Size(546, 410);
            this.grpCadastroPagamentos.TabIndex = 0;
            this.grpCadastroPagamentos.TabStop = false;
            this.grpCadastroPagamentos.Text = "Cadastro Títulos de Pagamento";
            // 
            // grpValoresTitulo
            // 
            this.grpValoresTitulo.Controls.Add(this.lbValorPago);
            this.grpValoresTitulo.Controls.Add(this.txtValorPago);
            this.grpValoresTitulo.Controls.Add(this.lbValorTitulo);
            this.grpValoresTitulo.Controls.Add(this.txtValorTitulo);
            this.grpValoresTitulo.Controls.Add(this.lbValorMulta);
            this.grpValoresTitulo.Controls.Add(this.txtValorMulta);
            this.grpValoresTitulo.Controls.Add(this.nudTaxaMulta);
            this.grpValoresTitulo.Controls.Add(this.lbTaxaMulta);
            this.grpValoresTitulo.Controls.Add(this.lbValorDesconto);
            this.grpValoresTitulo.Controls.Add(this.txtValorDesconto);
            this.grpValoresTitulo.Controls.Add(this.nudTaxaDesconto);
            this.grpValoresTitulo.Controls.Add(this.lbTaxaDesconto);
            this.grpValoresTitulo.Location = new System.Drawing.Point(6, 142);
            this.grpValoresTitulo.Name = "grpValoresTitulo";
            this.grpValoresTitulo.Size = new System.Drawing.Size(522, 118);
            this.grpValoresTitulo.TabIndex = 8;
            this.grpValoresTitulo.TabStop = false;
            this.grpValoresTitulo.Text = "Valores Título";
            // 
            // lbValorPago
            // 
            this.lbValorPago.AutoSize = true;
            this.lbValorPago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbValorPago.Location = new System.Drawing.Point(19, 66);
            this.lbValorPago.Name = "lbValorPago";
            this.lbValorPago.Size = new System.Drawing.Size(59, 13);
            this.lbValorPago.TabIndex = 8;
            this.lbValorPago.Text = "Valor Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(19, 83);
            this.txtValorPago.MaxLength = 6;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(106, 20);
            this.txtValorPago.TabIndex = 9;
            // 
            // lbValorTitulo
            // 
            this.lbValorTitulo.AutoSize = true;
            this.lbValorTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbValorTitulo.Location = new System.Drawing.Point(262, 66);
            this.lbValorTitulo.Name = "lbValorTitulo";
            this.lbValorTitulo.Size = new System.Drawing.Size(62, 13);
            this.lbValorTitulo.TabIndex = 10;
            this.lbValorTitulo.Text = "Valor Título";
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.Enabled = false;
            this.txtValorTitulo.Location = new System.Drawing.Point(262, 83);
            this.txtValorTitulo.MaxLength = 6;
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.Size = new System.Drawing.Size(106, 20);
            this.txtValorTitulo.TabIndex = 11;
            // 
            // lbValorMulta
            // 
            this.lbValorMulta.AutoSize = true;
            this.lbValorMulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbValorMulta.Location = new System.Drawing.Point(384, 19);
            this.lbValorMulta.Name = "lbValorMulta";
            this.lbValorMulta.Size = new System.Drawing.Size(60, 13);
            this.lbValorMulta.TabIndex = 6;
            this.lbValorMulta.Text = "Valor Multa";
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Location = new System.Drawing.Point(384, 37);
            this.txtValorMulta.MaxLength = 6;
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(106, 20);
            this.txtValorMulta.TabIndex = 7;
            // 
            // nudTaxaMulta
            // 
            this.nudTaxaMulta.DecimalPlaces = 2;
            this.nudTaxaMulta.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudTaxaMulta.Location = new System.Drawing.Point(262, 37);
            this.nudTaxaMulta.Name = "nudTaxaMulta";
            this.nudTaxaMulta.Size = new System.Drawing.Size(79, 20);
            this.nudTaxaMulta.TabIndex = 5;
            this.nudTaxaMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTaxaMulta
            // 
            this.lbTaxaMulta.AutoSize = true;
            this.lbTaxaMulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTaxaMulta.Location = new System.Drawing.Point(262, 19);
            this.lbTaxaMulta.Name = "lbTaxaMulta";
            this.lbTaxaMulta.Size = new System.Drawing.Size(60, 13);
            this.lbTaxaMulta.TabIndex = 4;
            this.lbTaxaMulta.Text = "Taxa Multa";
            // 
            // lbValorDesconto
            // 
            this.lbValorDesconto.AutoSize = true;
            this.lbValorDesconto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbValorDesconto.Location = new System.Drawing.Point(141, 19);
            this.lbValorDesconto.Name = "lbValorDesconto";
            this.lbValorDesconto.Size = new System.Drawing.Size(80, 13);
            this.lbValorDesconto.TabIndex = 2;
            this.lbValorDesconto.Text = "Valor Desconto";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(141, 37);
            this.txtValorDesconto.MaxLength = 6;
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(106, 20);
            this.txtValorDesconto.TabIndex = 3;
            // 
            // nudTaxaDesconto
            // 
            this.nudTaxaDesconto.DecimalPlaces = 2;
            this.nudTaxaDesconto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudTaxaDesconto.Location = new System.Drawing.Point(19, 37);
            this.nudTaxaDesconto.Name = "nudTaxaDesconto";
            this.nudTaxaDesconto.Size = new System.Drawing.Size(79, 20);
            this.nudTaxaDesconto.TabIndex = 1;
            this.nudTaxaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTaxaDesconto
            // 
            this.lbTaxaDesconto.AutoSize = true;
            this.lbTaxaDesconto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTaxaDesconto.Location = new System.Drawing.Point(19, 19);
            this.lbTaxaDesconto.Name = "lbTaxaDesconto";
            this.lbTaxaDesconto.Size = new System.Drawing.Size(80, 13);
            this.lbTaxaDesconto.TabIndex = 0;
            this.lbTaxaDesconto.Text = "Taxa Desconto";
            // 
            // lbObservacoes
            // 
            this.lbObservacoes.AutoSize = true;
            this.lbObservacoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbObservacoes.Location = new System.Drawing.Point(11, 264);
            this.lbObservacoes.Name = "lbObservacoes";
            this.lbObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lbObservacoes.TabIndex = 9;
            this.lbObservacoes.Text = "Observações";
            // 
            // rtxtObservacoes
            // 
            this.rtxtObservacoes.Enabled = false;
            this.rtxtObservacoes.Location = new System.Drawing.Point(11, 283);
            this.rtxtObservacoes.Name = "rtxtObservacoes";
            this.rtxtObservacoes.Size = new System.Drawing.Size(517, 116);
            this.rtxtObservacoes.TabIndex = 10;
            this.rtxtObservacoes.Text = "";
            // 
            // grpPeriodoVencimentoTitulo
            // 
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpDataPagamento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbDataPagamento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpDataCancelamento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbDataCancelamento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpDataVencimento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbDataVencimento);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.dtpDataGeracao);
            this.grpPeriodoVencimentoTitulo.Controls.Add(this.lbDataGeracao);
            this.grpPeriodoVencimentoTitulo.Location = new System.Drawing.Point(6, 72);
            this.grpPeriodoVencimentoTitulo.Name = "grpPeriodoVencimentoTitulo";
            this.grpPeriodoVencimentoTitulo.Size = new System.Drawing.Size(522, 66);
            this.grpPeriodoVencimentoTitulo.TabIndex = 7;
            this.grpPeriodoVencimentoTitulo.TabStop = false;
            this.grpPeriodoVencimentoTitulo.Text = "Período Vencimento Título";
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(384, 35);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(106, 20);
            this.dtpDataPagamento.TabIndex = 7;
            // 
            // lbDataPagamento
            // 
            this.lbDataPagamento.AutoSize = true;
            this.lbDataPagamento.Location = new System.Drawing.Point(384, 18);
            this.lbDataPagamento.Name = "lbDataPagamento";
            this.lbDataPagamento.Size = new System.Drawing.Size(87, 13);
            this.lbDataPagamento.TabIndex = 6;
            this.lbDataPagamento.Text = "Data Pagamento";
            // 
            // dtpDataCancelamento
            // 
            this.dtpDataCancelamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCancelamento.Location = new System.Drawing.Point(262, 35);
            this.dtpDataCancelamento.Name = "dtpDataCancelamento";
            this.dtpDataCancelamento.Size = new System.Drawing.Size(106, 20);
            this.dtpDataCancelamento.TabIndex = 5;
            // 
            // lbDataCancelamento
            // 
            this.lbDataCancelamento.AutoSize = true;
            this.lbDataCancelamento.Location = new System.Drawing.Point(262, 18);
            this.lbDataCancelamento.Name = "lbDataCancelamento";
            this.lbDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lbDataCancelamento.TabIndex = 4;
            this.lbDataCancelamento.Text = "Data Cancelamento";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(141, 35);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(106, 20);
            this.dtpDataVencimento.TabIndex = 3;
            // 
            // lbDataVencimento
            // 
            this.lbDataVencimento.AutoSize = true;
            this.lbDataVencimento.Location = new System.Drawing.Point(141, 18);
            this.lbDataVencimento.Name = "lbDataVencimento";
            this.lbDataVencimento.Size = new System.Drawing.Size(89, 13);
            this.lbDataVencimento.TabIndex = 2;
            this.lbDataVencimento.Text = "Data Vencimento";
            // 
            // dtpDataGeracao
            // 
            this.dtpDataGeracao.Enabled = false;
            this.dtpDataGeracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataGeracao.Location = new System.Drawing.Point(19, 35);
            this.dtpDataGeracao.Name = "dtpDataGeracao";
            this.dtpDataGeracao.Size = new System.Drawing.Size(106, 20);
            this.dtpDataGeracao.TabIndex = 1;
            // 
            // lbDataGeracao
            // 
            this.lbDataGeracao.AutoSize = true;
            this.lbDataGeracao.Location = new System.Drawing.Point(19, 18);
            this.lbDataGeracao.Name = "lbDataGeracao";
            this.lbDataGeracao.Size = new System.Drawing.Size(74, 13);
            this.lbDataGeracao.TabIndex = 0;
            this.lbDataGeracao.Text = "Data Geração";
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
            this.cboSituacaoTitulo.Enabled = false;
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
            // FrmPagamentosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 516);
            this.Controls.Add(this.grpCadastroPagamentos);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "FrmPagamentosCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - CADASTRO PAGAMENTOS";
            this.pnlBotoes.ResumeLayout(false);
            this.grpCadastroPagamentos.ResumeLayout(false);
            this.grpCadastroPagamentos.PerformLayout();
            this.grpValoresTitulo.ResumeLayout(false);
            this.grpValoresTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxaMulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxaDesconto)).EndInit();
            this.grpPeriodoVencimentoTitulo.ResumeLayout(false);
            this.grpPeriodoVencimentoTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpCadastroPagamentos;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnAlunosBusca;
        private System.Windows.Forms.Label lbSituacaoTitulo;
        private System.Windows.Forms.ComboBox cboSituacaoTitulo;
        private System.Windows.Forms.GroupBox grpPeriodoVencimentoTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.Label lbDataVencimento;
        private System.Windows.Forms.DateTimePicker dtpDataGeracao;
        private System.Windows.Forms.Label lbDataGeracao;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnBonificarTitulo;
        private System.Windows.Forms.Button btnCancelarTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.DateTimePicker dtpDataCancelamento;
        private System.Windows.Forms.Label lbDataCancelamento;
        private System.Windows.Forms.RichTextBox rtxtObservacoes;
        private System.Windows.Forms.Label lbObservacoes;
        private System.Windows.Forms.Button btnAdicionarObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpValoresTitulo;
        private System.Windows.Forms.Label lbValorPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lbValorTitulo;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.Label lbValorMulta;
        private System.Windows.Forms.TextBox txtValorMulta;
        private System.Windows.Forms.NumericUpDown nudTaxaMulta;
        private System.Windows.Forms.Label lbTaxaMulta;
        private System.Windows.Forms.Label lbValorDesconto;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.NumericUpDown nudTaxaDesconto;
        private System.Windows.Forms.Label lbTaxaDesconto;
    }
}