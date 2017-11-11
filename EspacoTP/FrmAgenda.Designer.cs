namespace EspacoTP
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.grpConsultaAgendamentos = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.pnlBotoesFiltro = new System.Windows.Forms.Panel();
            this.btnImprimirCronograma = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BtnHora1 = new System.Windows.Forms.Button();
            this.lbHora1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHora14 = new System.Windows.Forms.Button();
            this.lbHora14 = new System.Windows.Forms.Label();
            this.BtnHora13 = new System.Windows.Forms.Button();
            this.lbHora13 = new System.Windows.Forms.Label();
            this.BtnHora12 = new System.Windows.Forms.Button();
            this.lbHora12 = new System.Windows.Forms.Label();
            this.BtnHora11 = new System.Windows.Forms.Button();
            this.lbHora11 = new System.Windows.Forms.Label();
            this.BtnHora10 = new System.Windows.Forms.Button();
            this.lbHora10 = new System.Windows.Forms.Label();
            this.BtnHora9 = new System.Windows.Forms.Button();
            this.lbHora9 = new System.Windows.Forms.Label();
            this.BtnHora8 = new System.Windows.Forms.Button();
            this.lbHora8 = new System.Windows.Forms.Label();
            this.BtnHora7 = new System.Windows.Forms.Button();
            this.lbHora7 = new System.Windows.Forms.Label();
            this.BtnHora6 = new System.Windows.Forms.Button();
            this.lbHora6 = new System.Windows.Forms.Label();
            this.BtnHora5 = new System.Windows.Forms.Button();
            this.lbHora5 = new System.Windows.Forms.Label();
            this.BtnHora4 = new System.Windows.Forms.Button();
            this.lbHora4 = new System.Windows.Forms.Label();
            this.BtnHora3 = new System.Windows.Forms.Button();
            this.lbHora3 = new System.Windows.Forms.Label();
            this.BtnHora2 = new System.Windows.Forms.Button();
            this.lbHora2 = new System.Windows.Forms.Label();
            this.grpConsultaAgendamentos.SuspendLayout();
            this.pnlBotoesFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultaAgendamentos
            // 
            this.grpConsultaAgendamentos.Controls.Add(this.dtpData);
            this.grpConsultaAgendamentos.Controls.Add(this.lbData);
            this.grpConsultaAgendamentos.Controls.Add(this.pnlBotoesFiltro);
            this.grpConsultaAgendamentos.Location = new System.Drawing.Point(14, 12);
            this.grpConsultaAgendamentos.Name = "grpConsultaAgendamentos";
            this.grpConsultaAgendamentos.Size = new System.Drawing.Size(546, 94);
            this.grpConsultaAgendamentos.TabIndex = 0;
            this.grpConsultaAgendamentos.TabStop = false;
            this.grpConsultaAgendamentos.Text = "Consulta Agendamento de Horários";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(43, 54);
            this.dtpData.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(223, 20);
            this.dtpData.TabIndex = 1;
            this.dtpData.Value = new System.DateTime(2017, 10, 25, 0, 0, 0, 0);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(43, 33);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data";
            // 
            // pnlBotoesFiltro
            // 
            this.pnlBotoesFiltro.BackColor = System.Drawing.Color.MintCream;
            this.pnlBotoesFiltro.Controls.Add(this.btnImprimirCronograma);
            this.pnlBotoesFiltro.Controls.Add(this.btnBuscar);
            this.pnlBotoesFiltro.Controls.Add(this.btnLimpar);
            this.pnlBotoesFiltro.Location = new System.Drawing.Point(351, 27);
            this.pnlBotoesFiltro.Name = "pnlBotoesFiltro";
            this.pnlBotoesFiltro.Size = new System.Drawing.Size(177, 47);
            this.pnlBotoesFiltro.TabIndex = 2;
            // 
            // btnImprimirCronograma
            // 
            this.btnImprimirCronograma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimirCronograma.Location = new System.Drawing.Point(83, 38);
            this.btnImprimirCronograma.Name = "btnImprimirCronograma";
            this.btnImprimirCronograma.Size = new System.Drawing.Size(111, 23);
            this.btnImprimirCronograma.TabIndex = 2;
            this.btnImprimirCronograma.Text = "Im&primir Cronograma";
            this.btnImprimirCronograma.UseVisualStyleBackColor = true;
            this.btnImprimirCronograma.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(90, 12);
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
            this.btnLimpar.Location = new System.Drawing.Point(10, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BtnHora1
            // 
            this.BtnHora1.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora1.Enabled = false;
            this.BtnHora1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora1.Location = new System.Drawing.Point(44, 51);
            this.BtnHora1.Name = "BtnHora1";
            this.BtnHora1.Size = new System.Drawing.Size(60, 60);
            this.BtnHora1.TabIndex = 1;
            this.BtnHora1.UseVisualStyleBackColor = false;
            this.BtnHora1.Click += new System.EventHandler(this.BtnHora1_Click);
            // 
            // lbHora1
            // 
            this.lbHora1.AutoSize = true;
            this.lbHora1.Location = new System.Drawing.Point(55, 36);
            this.lbHora1.Name = "lbHora1";
            this.lbHora1.Size = new System.Drawing.Size(37, 13);
            this.lbHora1.TabIndex = 0;
            this.lbHora1.Text = "07h00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHora14);
            this.groupBox1.Controls.Add(this.lbHora14);
            this.groupBox1.Controls.Add(this.BtnHora13);
            this.groupBox1.Controls.Add(this.lbHora13);
            this.groupBox1.Controls.Add(this.BtnHora12);
            this.groupBox1.Controls.Add(this.lbHora12);
            this.groupBox1.Controls.Add(this.BtnHora11);
            this.groupBox1.Controls.Add(this.lbHora11);
            this.groupBox1.Controls.Add(this.BtnHora10);
            this.groupBox1.Controls.Add(this.lbHora10);
            this.groupBox1.Controls.Add(this.BtnHora9);
            this.groupBox1.Controls.Add(this.lbHora9);
            this.groupBox1.Controls.Add(this.BtnHora8);
            this.groupBox1.Controls.Add(this.lbHora8);
            this.groupBox1.Controls.Add(this.BtnHora7);
            this.groupBox1.Controls.Add(this.lbHora7);
            this.groupBox1.Controls.Add(this.BtnHora6);
            this.groupBox1.Controls.Add(this.lbHora6);
            this.groupBox1.Controls.Add(this.BtnHora5);
            this.groupBox1.Controls.Add(this.lbHora5);
            this.groupBox1.Controls.Add(this.BtnHora4);
            this.groupBox1.Controls.Add(this.lbHora4);
            this.groupBox1.Controls.Add(this.BtnHora3);
            this.groupBox1.Controls.Add(this.lbHora3);
            this.groupBox1.Controls.Add(this.BtnHora2);
            this.groupBox1.Controls.Add(this.lbHora2);
            this.groupBox1.Controls.Add(this.BtnHora1);
            this.groupBox1.Controls.Add(this.lbHora1);
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantidade de Agendamentos";
            // 
            // BtnHora14
            // 
            this.BtnHora14.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora14.Location = new System.Drawing.Point(441, 139);
            this.BtnHora14.Name = "BtnHora14";
            this.BtnHora14.Size = new System.Drawing.Size(60, 60);
            this.BtnHora14.TabIndex = 27;
            this.BtnHora14.UseVisualStyleBackColor = false;
            this.BtnHora14.Click += new System.EventHandler(this.BtnHora14_Click);
            // 
            // lbHora14
            // 
            this.lbHora14.AutoSize = true;
            this.lbHora14.Location = new System.Drawing.Point(452, 124);
            this.lbHora14.Name = "lbHora14";
            this.lbHora14.Size = new System.Drawing.Size(37, 13);
            this.lbHora14.TabIndex = 26;
            this.lbHora14.Text = "20h00";
            // 
            // BtnHora13
            // 
            this.BtnHora13.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora13.Location = new System.Drawing.Point(375, 139);
            this.BtnHora13.Name = "BtnHora13";
            this.BtnHora13.Size = new System.Drawing.Size(60, 60);
            this.BtnHora13.TabIndex = 25;
            this.BtnHora13.UseVisualStyleBackColor = false;
            this.BtnHora13.Click += new System.EventHandler(this.BtnHora13_Click);
            // 
            // lbHora13
            // 
            this.lbHora13.AutoSize = true;
            this.lbHora13.Location = new System.Drawing.Point(386, 124);
            this.lbHora13.Name = "lbHora13";
            this.lbHora13.Size = new System.Drawing.Size(37, 13);
            this.lbHora13.TabIndex = 24;
            this.lbHora13.Text = "19h00";
            // 
            // BtnHora12
            // 
            this.BtnHora12.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora12.Location = new System.Drawing.Point(309, 139);
            this.BtnHora12.Name = "BtnHora12";
            this.BtnHora12.Size = new System.Drawing.Size(60, 60);
            this.BtnHora12.TabIndex = 23;
            this.BtnHora12.UseVisualStyleBackColor = false;
            this.BtnHora12.Click += new System.EventHandler(this.BtnHora12_Click);
            // 
            // lbHora12
            // 
            this.lbHora12.AutoSize = true;
            this.lbHora12.Location = new System.Drawing.Point(320, 124);
            this.lbHora12.Name = "lbHora12";
            this.lbHora12.Size = new System.Drawing.Size(37, 13);
            this.lbHora12.TabIndex = 22;
            this.lbHora12.Text = "18h00";
            // 
            // BtnHora11
            // 
            this.BtnHora11.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora11.Location = new System.Drawing.Point(244, 139);
            this.BtnHora11.Name = "BtnHora11";
            this.BtnHora11.Size = new System.Drawing.Size(60, 60);
            this.BtnHora11.TabIndex = 21;
            this.BtnHora11.UseVisualStyleBackColor = false;
            this.BtnHora11.Click += new System.EventHandler(this.BtnHora11_Click);
            // 
            // lbHora11
            // 
            this.lbHora11.AutoSize = true;
            this.lbHora11.Location = new System.Drawing.Point(255, 124);
            this.lbHora11.Name = "lbHora11";
            this.lbHora11.Size = new System.Drawing.Size(37, 13);
            this.lbHora11.TabIndex = 20;
            this.lbHora11.Text = "17h00";
            // 
            // BtnHora10
            // 
            this.BtnHora10.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora10.Location = new System.Drawing.Point(178, 139);
            this.BtnHora10.Name = "BtnHora10";
            this.BtnHora10.Size = new System.Drawing.Size(60, 60);
            this.BtnHora10.TabIndex = 19;
            this.BtnHora10.UseVisualStyleBackColor = false;
            this.BtnHora10.Click += new System.EventHandler(this.BtnHora10_Click);
            // 
            // lbHora10
            // 
            this.lbHora10.AutoSize = true;
            this.lbHora10.Location = new System.Drawing.Point(189, 124);
            this.lbHora10.Name = "lbHora10";
            this.lbHora10.Size = new System.Drawing.Size(37, 13);
            this.lbHora10.TabIndex = 18;
            this.lbHora10.Text = "16h00";
            // 
            // BtnHora9
            // 
            this.BtnHora9.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora9.Location = new System.Drawing.Point(112, 139);
            this.BtnHora9.Name = "BtnHora9";
            this.BtnHora9.Size = new System.Drawing.Size(60, 60);
            this.BtnHora9.TabIndex = 17;
            this.BtnHora9.UseVisualStyleBackColor = false;
            this.BtnHora9.Click += new System.EventHandler(this.BtnHora9_Click);
            // 
            // lbHora9
            // 
            this.lbHora9.AutoSize = true;
            this.lbHora9.Location = new System.Drawing.Point(123, 124);
            this.lbHora9.Name = "lbHora9";
            this.lbHora9.Size = new System.Drawing.Size(37, 13);
            this.lbHora9.TabIndex = 16;
            this.lbHora9.Text = "15h00";
            // 
            // BtnHora8
            // 
            this.BtnHora8.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora8.Location = new System.Drawing.Point(46, 139);
            this.BtnHora8.Name = "BtnHora8";
            this.BtnHora8.Size = new System.Drawing.Size(60, 60);
            this.BtnHora8.TabIndex = 15;
            this.BtnHora8.UseVisualStyleBackColor = false;
            this.BtnHora8.Click += new System.EventHandler(this.BtnHora8_Click);
            // 
            // lbHora8
            // 
            this.lbHora8.AutoSize = true;
            this.lbHora8.Location = new System.Drawing.Point(57, 124);
            this.lbHora8.Name = "lbHora8";
            this.lbHora8.Size = new System.Drawing.Size(37, 13);
            this.lbHora8.TabIndex = 14;
            this.lbHora8.Text = "14h00";
            // 
            // BtnHora7
            // 
            this.BtnHora7.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora7.Location = new System.Drawing.Point(439, 51);
            this.BtnHora7.Name = "BtnHora7";
            this.BtnHora7.Size = new System.Drawing.Size(60, 60);
            this.BtnHora7.TabIndex = 13;
            this.BtnHora7.UseVisualStyleBackColor = false;
            this.BtnHora7.Click += new System.EventHandler(this.BtnHora7_Click);
            // 
            // lbHora7
            // 
            this.lbHora7.AutoSize = true;
            this.lbHora7.Location = new System.Drawing.Point(450, 36);
            this.lbHora7.Name = "lbHora7";
            this.lbHora7.Size = new System.Drawing.Size(37, 13);
            this.lbHora7.TabIndex = 12;
            this.lbHora7.Text = "13h00";
            // 
            // BtnHora6
            // 
            this.BtnHora6.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora6.Location = new System.Drawing.Point(373, 51);
            this.BtnHora6.Name = "BtnHora6";
            this.BtnHora6.Size = new System.Drawing.Size(60, 60);
            this.BtnHora6.TabIndex = 11;
            this.BtnHora6.UseVisualStyleBackColor = false;
            this.BtnHora6.Click += new System.EventHandler(this.BtnHora6_Click);
            // 
            // lbHora6
            // 
            this.lbHora6.AutoSize = true;
            this.lbHora6.Location = new System.Drawing.Point(384, 36);
            this.lbHora6.Name = "lbHora6";
            this.lbHora6.Size = new System.Drawing.Size(37, 13);
            this.lbHora6.TabIndex = 10;
            this.lbHora6.Text = "12h00";
            // 
            // BtnHora5
            // 
            this.BtnHora5.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora5.Location = new System.Drawing.Point(307, 51);
            this.BtnHora5.Name = "BtnHora5";
            this.BtnHora5.Size = new System.Drawing.Size(60, 60);
            this.BtnHora5.TabIndex = 9;
            this.BtnHora5.UseVisualStyleBackColor = false;
            this.BtnHora5.Click += new System.EventHandler(this.BtnHora5_Click);
            // 
            // lbHora5
            // 
            this.lbHora5.AutoSize = true;
            this.lbHora5.Location = new System.Drawing.Point(318, 36);
            this.lbHora5.Name = "lbHora5";
            this.lbHora5.Size = new System.Drawing.Size(37, 13);
            this.lbHora5.TabIndex = 8;
            this.lbHora5.Text = "11h00";
            // 
            // BtnHora4
            // 
            this.BtnHora4.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora4.Location = new System.Drawing.Point(242, 51);
            this.BtnHora4.Name = "BtnHora4";
            this.BtnHora4.Size = new System.Drawing.Size(60, 60);
            this.BtnHora4.TabIndex = 7;
            this.BtnHora4.UseVisualStyleBackColor = false;
            this.BtnHora4.Click += new System.EventHandler(this.BtnHora4_Click);
            // 
            // lbHora4
            // 
            this.lbHora4.AutoSize = true;
            this.lbHora4.Location = new System.Drawing.Point(253, 36);
            this.lbHora4.Name = "lbHora4";
            this.lbHora4.Size = new System.Drawing.Size(37, 13);
            this.lbHora4.TabIndex = 6;
            this.lbHora4.Text = "10h00";
            // 
            // BtnHora3
            // 
            this.BtnHora3.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora3.Location = new System.Drawing.Point(176, 51);
            this.BtnHora3.Name = "BtnHora3";
            this.BtnHora3.Size = new System.Drawing.Size(60, 60);
            this.BtnHora3.TabIndex = 5;
            this.BtnHora3.UseVisualStyleBackColor = false;
            this.BtnHora3.Click += new System.EventHandler(this.BtnHora3_Click);
            // 
            // lbHora3
            // 
            this.lbHora3.AutoSize = true;
            this.lbHora3.Location = new System.Drawing.Point(187, 36);
            this.lbHora3.Name = "lbHora3";
            this.lbHora3.Size = new System.Drawing.Size(37, 13);
            this.lbHora3.TabIndex = 4;
            this.lbHora3.Text = "09h00";
            // 
            // BtnHora2
            // 
            this.BtnHora2.BackColor = System.Drawing.Color.MintCream;
            this.BtnHora2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHora2.Location = new System.Drawing.Point(110, 51);
            this.BtnHora2.Name = "BtnHora2";
            this.BtnHora2.Size = new System.Drawing.Size(60, 60);
            this.BtnHora2.TabIndex = 3;
            this.BtnHora2.UseVisualStyleBackColor = false;
            this.BtnHora2.Click += new System.EventHandler(this.BtnHora2_Click);
            // 
            // lbHora2
            // 
            this.lbHora2.AutoSize = true;
            this.lbHora2.Location = new System.Drawing.Point(121, 36);
            this.lbHora2.Name = "lbHora2";
            this.lbHora2.Size = new System.Drawing.Size(37, 13);
            this.lbHora2.TabIndex = 2;
            this.lbHora2.Text = "08h00";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConsultaAgendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - AGENDA";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.grpConsultaAgendamentos.ResumeLayout(false);
            this.grpConsultaAgendamentos.PerformLayout();
            this.pnlBotoesFiltro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConsultaAgendamentos;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Panel pnlBotoesFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button BtnHora1;
        private System.Windows.Forms.Label lbHora1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHora14;
        private System.Windows.Forms.Label lbHora14;
        private System.Windows.Forms.Button BtnHora13;
        private System.Windows.Forms.Label lbHora13;
        private System.Windows.Forms.Button BtnHora12;
        private System.Windows.Forms.Label lbHora12;
        private System.Windows.Forms.Button BtnHora11;
        private System.Windows.Forms.Label lbHora11;
        private System.Windows.Forms.Button BtnHora10;
        private System.Windows.Forms.Label lbHora10;
        private System.Windows.Forms.Button BtnHora9;
        private System.Windows.Forms.Label lbHora9;
        private System.Windows.Forms.Button BtnHora8;
        private System.Windows.Forms.Label lbHora8;
        private System.Windows.Forms.Button BtnHora7;
        private System.Windows.Forms.Label lbHora7;
        private System.Windows.Forms.Button BtnHora6;
        private System.Windows.Forms.Label lbHora6;
        private System.Windows.Forms.Button BtnHora5;
        private System.Windows.Forms.Label lbHora5;
        private System.Windows.Forms.Button BtnHora4;
        private System.Windows.Forms.Label lbHora4;
        private System.Windows.Forms.Button BtnHora3;
        private System.Windows.Forms.Label lbHora3;
        private System.Windows.Forms.Button BtnHora2;
        private System.Windows.Forms.Label lbHora2;
        private System.Windows.Forms.Button btnImprimirCronograma;
    }
}