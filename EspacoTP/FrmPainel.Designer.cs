using EspacoTP.MODEL;

namespace EspacoTP
{
    partial class FrmPainel
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInstrutores = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAgenda,
            this.mniAlunos,
            this.mniInstrutores,
            this.mniUsuarios});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(926, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "Menu";
            // 
            // mniAgenda
            // 
            this.mniAgenda.Name = "mniAgenda";
            this.mniAgenda.Size = new System.Drawing.Size(56, 20);
            this.mniAgenda.Text = "&Agenda";
            this.mniAgenda.Click += new System.EventHandler(this.mniAgenda_Click);
            // 
            // mniAlunos
            // 
            this.mniAlunos.Name = "mniAlunos";
            this.mniAlunos.Size = new System.Drawing.Size(51, 20);
            this.mniAlunos.Text = "A&lunos";
            this.mniAlunos.Click += new System.EventHandler(this.mniAlunos_Click);
            // 
            // mniInstrutores
            // 
            this.mniInstrutores.Name = "mniInstrutores";
            this.mniInstrutores.Size = new System.Drawing.Size(73, 20);
            this.mniInstrutores.Text = "&Instrutores";
            this.mniInstrutores.Click += new System.EventHandler(this.mniInstrutores_Click);
            // 
            // mniUsuarios
            // 
            this.mniUsuarios.Name = "mniUsuarios";
            this.mniUsuarios.Size = new System.Drawing.Size(60, 20);
            this.mniUsuarios.Text = "&Usuários";
            this.mniUsuarios.Click += new System.EventHandler(this.mniUsuarios_Click);
            // 
            // FrmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 415);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESPAÇO TP - PAINEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mniAgenda;
        private System.Windows.Forms.ToolStripMenuItem mniInstrutores;
        private System.Windows.Forms.ToolStripMenuItem mniAlunos;
    }
}