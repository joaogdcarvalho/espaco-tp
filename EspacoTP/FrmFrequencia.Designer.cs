namespace EspacoTP
{
    partial class FrmFrequencia
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
            this.lbHorario = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.txtCodigoAluno = new System.Windows.Forms.TextBox();
            this.lbCodigoAluno = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.grpFrequencia = new System.Windows.Forms.GroupBox();
            this.grdFrequencia = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.grpDetalhes.SuspendLayout();
            this.grpFrequencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFrequencia)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalhes
            // 
            this.grpDetalhes.Controls.Add(this.chkAtivo);
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
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(317, 21);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(41, 13);
            this.lbHorario.TabIndex = 13;
            this.lbHorario.Text = "Horário";
            // 
            // cboHorario
            // 
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(317, 40);
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
            this.lbDia.Location = new System.Drawing.Point(161, 21);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(23, 13);
            this.lbDia.TabIndex = 11;
            this.lbDia.Text = "Dia";
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(161, 40);
            this.cboDia.MaxLength = 8;
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(137, 21);
            this.cboDia.TabIndex = 12;
            // 
            // grpFrequencia
            // 
            this.grpFrequencia.Controls.Add(this.grdFrequencia);
            this.grpFrequencia.Location = new System.Drawing.Point(14, 12);
            this.grpFrequencia.Name = "grpFrequencia";
            this.grpFrequencia.Size = new System.Drawing.Size(546, 297);
            this.grpFrequencia.TabIndex = 5;
            this.grpFrequencia.TabStop = false;
            this.grpFrequencia.Text = "Frequência";
            // 
            // grdFrequencia
            // 
            this.grdFrequencia.AllowUserToAddRows = false;
            this.grdFrequencia.AllowUserToDeleteRows = false;
            this.grdFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFrequencia.Location = new System.Drawing.Point(11, 21);
            this.grdFrequencia.Name = "grdFrequencia";
            this.grdFrequencia.ReadOnly = true;
            this.grdFrequencia.Size = new System.Drawing.Size(518, 259);
            this.grdFrequencia.TabIndex = 0;
            this.grdFrequencia.TabStop = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnDesfazer);
            this.pnlBotoes.Location = new System.Drawing.Point(14, 323);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 47);
            this.pnlBotoes.TabIndex = 6;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(11, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
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
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkAtivo.Location = new System.Drawing.Point(470, 40);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(71, 17);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.Text = "Presença";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 479);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpFrequencia);
            this.Controls.Add(this.grpDetalhes);
            this.Name = "FrmFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - FREQUÊNCIA";
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.grpFrequencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFrequencia)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.GroupBox grpFrequencia;
        private System.Windows.Forms.DataGridView grdFrequencia;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.TextBox txtCodigoAluno;
        private System.Windows.Forms.Label lbCodigoAluno;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}