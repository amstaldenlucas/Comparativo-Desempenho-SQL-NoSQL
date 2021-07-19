namespace comparativo_Desempenho_SQL_NoSQL
{
    partial class ForInsertDB
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
            this.btnInsereSQLServer = new System.Windows.Forms.Button();
            this.lblSaldacao = new System.Windows.Forms.Label();
            this.btnMongoDB = new System.Windows.Forms.Button();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMarcaHoraIni = new System.Windows.Forms.Label();
            this.lblMarcaHoraFim = new System.Windows.Forms.Label();
            this.lblMarcaStatus = new System.Windows.Forms.Label();
            this.lblQtdInsert = new System.Windows.Forms.Label();
            this.txtQtdInsert = new System.Windows.Forms.TextBox();
            this.lblInserindo2 = new System.Windows.Forms.Label();
            this.lblInserindo3 = new System.Windows.Forms.Label();
            this.lblInserindo1 = new System.Windows.Forms.Label();
            this.lblTempoTotal = new System.Windows.Forms.Label();
            this.txtTempoTotal = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.grCentro = new System.Windows.Forms.GroupBox();
            this.gpMongoDB = new System.Windows.Forms.GroupBox();
            this.lblHoraInicialMongo = new System.Windows.Forms.Label();
            this.lblMarcaHoraIniMongo = new System.Windows.Forms.Label();
            this.txtTempoTotalMongo = new System.Windows.Forms.TextBox();
            this.lblMarcaHoraFimMongo = new System.Windows.Forms.Label();
            this.lblTempoTotalMongo = new System.Windows.Forms.Label();
            this.lblHoraFinalMongo = new System.Windows.Forms.Label();
            this.lblInserindoMongo1 = new System.Windows.Forms.Label();
            this.lblStatusMongo = new System.Windows.Forms.Label();
            this.label8lblInserindoMongo3 = new System.Windows.Forms.Label();
            this.lblMarcaStatusMongo = new System.Windows.Forms.Label();
            this.lblInserindoMongo2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpSelect = new System.Windows.Forms.GroupBox();
            this.btnComparaSelect = new System.Windows.Forms.Button();
            this.btnSelectMongoDB = new System.Windows.Forms.Button();
            this.txtQtdSelect = new System.Windows.Forms.TextBox();
            this.lblQtdSelect = new System.Windows.Forms.Label();
            this.gpSelectMongoDB = new System.Windows.Forms.GroupBox();
            this.txtRegistraTempoLiqSelectMong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRegistaHoraIniSelectMongo = new System.Windows.Forms.Label();
            this.lblRegistaHoraFimSelectMongo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectSQL = new System.Windows.Forms.Button();
            this.gpSelectSQL = new System.Windows.Forms.GroupBox();
            this.txtRegistraHoraLiqSelectSQL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistaHoraIniSelectSQl = new System.Windows.Forms.Label();
            this.lblRegistaHoraFimSelectSQl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarcaLinhasRetornoSQL = new System.Windows.Forms.TextBox();
            this.lblLinhasRetornoSql = new System.Windows.Forms.Label();
            this.txtMarcaLinhasRetornoMongoDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRodaTudo = new System.Windows.Forms.Button();
            this.grCentro.SuspendLayout();
            this.gpMongoDB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpSelect.SuspendLayout();
            this.gpSelectMongoDB.SuspendLayout();
            this.gpSelectSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsereSQLServer
            // 
            this.btnInsereSQLServer.Location = new System.Drawing.Point(16, 23);
            this.btnInsereSQLServer.Name = "btnInsereSQLServer";
            this.btnInsereSQLServer.Size = new System.Drawing.Size(75, 29);
            this.btnInsereSQLServer.TabIndex = 0;
            this.btnInsereSQLServer.Text = "SQL Server";
            this.btnInsereSQLServer.UseVisualStyleBackColor = true;
            this.btnInsereSQLServer.Click += new System.EventHandler(this.btnInsereSQLServer_Click);
            // 
            // lblSaldacao
            // 
            this.lblSaldacao.AutoSize = true;
            this.lblSaldacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldacao.Location = new System.Drawing.Point(229, 9);
            this.lblSaldacao.Name = "lblSaldacao";
            this.lblSaldacao.Size = new System.Drawing.Size(303, 24);
            this.lblSaldacao.TabIndex = 1;
            this.lblSaldacao.Text = "Programa para dar insert no DB";
            this.lblSaldacao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMongoDB
            // 
            this.btnMongoDB.Location = new System.Drawing.Point(22, 23);
            this.btnMongoDB.Name = "btnMongoDB";
            this.btnMongoDB.Size = new System.Drawing.Size(85, 29);
            this.btnMongoDB.TabIndex = 2;
            this.btnMongoDB.Text = "Mongo DB";
            this.btnMongoDB.UseVisualStyleBackColor = true;
            this.btnMongoDB.Click += new System.EventHandler(this.btnMongoDB_Click);
            this.btnMongoDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMongoDB_MouseClick);
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Location = new System.Drawing.Point(37, 64);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(62, 13);
            this.lblHoraInicial.TabIndex = 1;
            this.lblHoraInicial.Text = "Hora inicial:";
            this.lblHoraInicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(37, 94);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(55, 13);
            this.lblHoraFinal.TabIndex = 1;
            this.lblHoraFinal.Text = "Hora final:";
            this.lblHoraFinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 133);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "STATUS:";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarcaHoraIni
            // 
            this.lblMarcaHoraIni.AutoSize = true;
            this.lblMarcaHoraIni.Location = new System.Drawing.Point(116, 61);
            this.lblMarcaHoraIni.Name = "lblMarcaHoraIni";
            this.lblMarcaHoraIni.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaHoraIni.TabIndex = 1;
            this.lblMarcaHoraIni.Text = ".";
            this.lblMarcaHoraIni.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarcaHoraFim
            // 
            this.lblMarcaHoraFim.AutoSize = true;
            this.lblMarcaHoraFim.Location = new System.Drawing.Point(116, 94);
            this.lblMarcaHoraFim.Name = "lblMarcaHoraFim";
            this.lblMarcaHoraFim.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaHoraFim.TabIndex = 1;
            this.lblMarcaHoraFim.Text = ".";
            this.lblMarcaHoraFim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarcaStatus
            // 
            this.lblMarcaStatus.AutoSize = true;
            this.lblMarcaStatus.Location = new System.Drawing.Point(116, 133);
            this.lblMarcaStatus.Name = "lblMarcaStatus";
            this.lblMarcaStatus.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaStatus.TabIndex = 1;
            this.lblMarcaStatus.Text = ".";
            this.lblMarcaStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQtdInsert
            // 
            this.lblQtdInsert.AutoSize = true;
            this.lblQtdInsert.Location = new System.Drawing.Point(86, 41);
            this.lblQtdInsert.Name = "lblQtdInsert";
            this.lblQtdInsert.Size = new System.Drawing.Size(73, 13);
            this.lblQtdInsert.TabIndex = 1;
            this.lblQtdInsert.Text = "QTD INSERT";
            this.lblQtdInsert.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQtdInsert
            // 
            this.txtQtdInsert.Location = new System.Drawing.Point(64, 68);
            this.txtQtdInsert.Name = "txtQtdInsert";
            this.txtQtdInsert.Size = new System.Drawing.Size(117, 20);
            this.txtQtdInsert.TabIndex = 5;
            // 
            // lblInserindo2
            // 
            this.lblInserindo2.AutoSize = true;
            this.lblInserindo2.Location = new System.Drawing.Point(37, 197);
            this.lblInserindo2.Name = "lblInserindo2";
            this.lblInserindo2.Size = new System.Drawing.Size(10, 13);
            this.lblInserindo2.TabIndex = 6;
            this.lblInserindo2.Text = ".";
            // 
            // lblInserindo3
            // 
            this.lblInserindo3.AutoSize = true;
            this.lblInserindo3.Location = new System.Drawing.Point(37, 220);
            this.lblInserindo3.Name = "lblInserindo3";
            this.lblInserindo3.Size = new System.Drawing.Size(10, 13);
            this.lblInserindo3.TabIndex = 7;
            this.lblInserindo3.Text = ".";
            // 
            // lblInserindo1
            // 
            this.lblInserindo1.AutoSize = true;
            this.lblInserindo1.Location = new System.Drawing.Point(37, 170);
            this.lblInserindo1.Name = "lblInserindo1";
            this.lblInserindo1.Size = new System.Drawing.Size(10, 13);
            this.lblInserindo1.TabIndex = 8;
            this.lblInserindo1.Text = ".";
            // 
            // lblTempoTotal
            // 
            this.lblTempoTotal.AutoSize = true;
            this.lblTempoTotal.Location = new System.Drawing.Point(13, 245);
            this.lblTempoTotal.Name = "lblTempoTotal";
            this.lblTempoTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTempoTotal.TabIndex = 9;
            this.lblTempoTotal.Text = "Tempo Total:";
            // 
            // txtTempoTotal
            // 
            this.txtTempoTotal.Enabled = false;
            this.txtTempoTotal.Location = new System.Drawing.Point(89, 242);
            this.txtTempoTotal.Name = "txtTempoTotal";
            this.txtTempoTotal.Size = new System.Drawing.Size(132, 20);
            this.txtTempoTotal.TabIndex = 10;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(81, 126);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(83, 34);
            this.btnComparar.TabIndex = 11;
            this.btnComparar.Text = "COMPARAR";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // grCentro
            // 
            this.grCentro.Controls.Add(this.btnComparar);
            this.grCentro.Controls.Add(this.lblQtdInsert);
            this.grCentro.Controls.Add(this.txtQtdInsert);
            this.grCentro.Location = new System.Drawing.Point(250, 71);
            this.grCentro.Name = "grCentro";
            this.grCentro.Size = new System.Drawing.Size(246, 216);
            this.grCentro.TabIndex = 23;
            this.grCentro.TabStop = false;
            // 
            // gpMongoDB
            // 
            this.gpMongoDB.Controls.Add(this.lblHoraInicialMongo);
            this.gpMongoDB.Controls.Add(this.lblMarcaHoraIniMongo);
            this.gpMongoDB.Controls.Add(this.txtTempoTotalMongo);
            this.gpMongoDB.Controls.Add(this.lblMarcaHoraFimMongo);
            this.gpMongoDB.Controls.Add(this.lblTempoTotalMongo);
            this.gpMongoDB.Controls.Add(this.lblHoraFinalMongo);
            this.gpMongoDB.Controls.Add(this.lblInserindoMongo1);
            this.gpMongoDB.Controls.Add(this.lblStatusMongo);
            this.gpMongoDB.Controls.Add(this.label8lblInserindoMongo3);
            this.gpMongoDB.Controls.Add(this.lblMarcaStatusMongo);
            this.gpMongoDB.Controls.Add(this.lblInserindoMongo2);
            this.gpMongoDB.Controls.Add(this.btnMongoDB);
            this.gpMongoDB.Location = new System.Drawing.Point(502, 48);
            this.gpMongoDB.Name = "gpMongoDB";
            this.gpMongoDB.Size = new System.Drawing.Size(227, 292);
            this.gpMongoDB.TabIndex = 24;
            this.gpMongoDB.TabStop = false;
            // 
            // lblHoraInicialMongo
            // 
            this.lblHoraInicialMongo.AutoSize = true;
            this.lblHoraInicialMongo.Location = new System.Drawing.Point(29, 64);
            this.lblHoraInicialMongo.Name = "lblHoraInicialMongo";
            this.lblHoraInicialMongo.Size = new System.Drawing.Size(62, 13);
            this.lblHoraInicialMongo.TabIndex = 11;
            this.lblHoraInicialMongo.Text = "Hora inicial:";
            // 
            // lblMarcaHoraIniMongo
            // 
            this.lblMarcaHoraIniMongo.AutoSize = true;
            this.lblMarcaHoraIniMongo.Location = new System.Drawing.Point(108, 61);
            this.lblMarcaHoraIniMongo.Name = "lblMarcaHoraIniMongo";
            this.lblMarcaHoraIniMongo.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaHoraIniMongo.TabIndex = 12;
            this.lblMarcaHoraIniMongo.Text = ".";
            // 
            // txtTempoTotalMongo
            // 
            this.txtTempoTotalMongo.Enabled = false;
            this.txtTempoTotalMongo.Location = new System.Drawing.Point(86, 245);
            this.txtTempoTotalMongo.Name = "txtTempoTotalMongo";
            this.txtTempoTotalMongo.Size = new System.Drawing.Size(132, 20);
            this.txtTempoTotalMongo.TabIndex = 21;
            // 
            // lblMarcaHoraFimMongo
            // 
            this.lblMarcaHoraFimMongo.AutoSize = true;
            this.lblMarcaHoraFimMongo.Location = new System.Drawing.Point(108, 94);
            this.lblMarcaHoraFimMongo.Name = "lblMarcaHoraFimMongo";
            this.lblMarcaHoraFimMongo.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaHoraFimMongo.TabIndex = 13;
            this.lblMarcaHoraFimMongo.Text = ".";
            // 
            // lblTempoTotalMongo
            // 
            this.lblTempoTotalMongo.AutoSize = true;
            this.lblTempoTotalMongo.Location = new System.Drawing.Point(10, 248);
            this.lblTempoTotalMongo.Name = "lblTempoTotalMongo";
            this.lblTempoTotalMongo.Size = new System.Drawing.Size(70, 13);
            this.lblTempoTotalMongo.TabIndex = 20;
            this.lblTempoTotalMongo.Text = "Tempo Total:";
            // 
            // lblHoraFinalMongo
            // 
            this.lblHoraFinalMongo.AutoSize = true;
            this.lblHoraFinalMongo.Location = new System.Drawing.Point(29, 94);
            this.lblHoraFinalMongo.Name = "lblHoraFinalMongo";
            this.lblHoraFinalMongo.Size = new System.Drawing.Size(55, 13);
            this.lblHoraFinalMongo.TabIndex = 14;
            this.lblHoraFinalMongo.Text = "Hora final:";
            // 
            // lblInserindoMongo1
            // 
            this.lblInserindoMongo1.AutoSize = true;
            this.lblInserindoMongo1.Location = new System.Drawing.Point(29, 170);
            this.lblInserindoMongo1.Name = "lblInserindoMongo1";
            this.lblInserindoMongo1.Size = new System.Drawing.Size(10, 13);
            this.lblInserindoMongo1.TabIndex = 19;
            this.lblInserindoMongo1.Text = ".";
            // 
            // lblStatusMongo
            // 
            this.lblStatusMongo.AutoSize = true;
            this.lblStatusMongo.Location = new System.Drawing.Point(29, 133);
            this.lblStatusMongo.Name = "lblStatusMongo";
            this.lblStatusMongo.Size = new System.Drawing.Size(53, 13);
            this.lblStatusMongo.TabIndex = 15;
            this.lblStatusMongo.Text = "STATUS:";
            // 
            // label8lblInserindoMongo3
            // 
            this.label8lblInserindoMongo3.AutoSize = true;
            this.label8lblInserindoMongo3.Location = new System.Drawing.Point(29, 220);
            this.label8lblInserindoMongo3.Name = "label8lblInserindoMongo3";
            this.label8lblInserindoMongo3.Size = new System.Drawing.Size(10, 13);
            this.label8lblInserindoMongo3.TabIndex = 18;
            this.label8lblInserindoMongo3.Text = ".";
            // 
            // lblMarcaStatusMongo
            // 
            this.lblMarcaStatusMongo.AutoSize = true;
            this.lblMarcaStatusMongo.Location = new System.Drawing.Point(108, 133);
            this.lblMarcaStatusMongo.Name = "lblMarcaStatusMongo";
            this.lblMarcaStatusMongo.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaStatusMongo.TabIndex = 16;
            this.lblMarcaStatusMongo.Text = ".";
            // 
            // lblInserindoMongo2
            // 
            this.lblInserindoMongo2.AutoSize = true;
            this.lblInserindoMongo2.Location = new System.Drawing.Point(29, 197);
            this.lblInserindoMongo2.Name = "lblInserindoMongo2";
            this.lblInserindoMongo2.Size = new System.Drawing.Size(10, 13);
            this.lblInserindoMongo2.TabIndex = 17;
            this.lblInserindoMongo2.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsereSQLServer);
            this.groupBox1.Controls.Add(this.lblHoraInicial);
            this.groupBox1.Controls.Add(this.lblMarcaHoraIni);
            this.groupBox1.Controls.Add(this.txtTempoTotal);
            this.groupBox1.Controls.Add(this.lblMarcaHoraFim);
            this.groupBox1.Controls.Add(this.lblTempoTotal);
            this.groupBox1.Controls.Add(this.lblHoraFinal);
            this.groupBox1.Controls.Add(this.lblInserindo1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblInserindo3);
            this.groupBox1.Controls.Add(this.lblMarcaStatus);
            this.groupBox1.Controls.Add(this.lblInserindo2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 292);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // gpSelect
            // 
            this.gpSelect.Controls.Add(this.btnComparaSelect);
            this.gpSelect.Controls.Add(this.btnSelectMongoDB);
            this.gpSelect.Controls.Add(this.txtQtdSelect);
            this.gpSelect.Controls.Add(this.lblQtdSelect);
            this.gpSelect.Controls.Add(this.gpSelectMongoDB);
            this.gpSelect.Controls.Add(this.btnSelectSQL);
            this.gpSelect.Location = new System.Drawing.Point(12, 346);
            this.gpSelect.Name = "gpSelect";
            this.gpSelect.Size = new System.Drawing.Size(717, 255);
            this.gpSelect.TabIndex = 26;
            this.gpSelect.TabStop = false;
            // 
            // btnComparaSelect
            // 
            this.btnComparaSelect.Location = new System.Drawing.Point(302, 52);
            this.btnComparaSelect.Name = "btnComparaSelect";
            this.btnComparaSelect.Size = new System.Drawing.Size(117, 26);
            this.btnComparaSelect.TabIndex = 29;
            this.btnComparaSelect.Text = "Comparar Select";
            this.btnComparaSelect.UseVisualStyleBackColor = true;
            this.btnComparaSelect.Click += new System.EventHandler(this.btnComparaSelect_Click);
            // 
            // btnSelectMongoDB
            // 
            this.btnSelectMongoDB.Location = new System.Drawing.Point(619, 49);
            this.btnSelectMongoDB.Name = "btnSelectMongoDB";
            this.btnSelectMongoDB.Size = new System.Drawing.Size(75, 29);
            this.btnSelectMongoDB.TabIndex = 29;
            this.btnSelectMongoDB.Text = "SELECT";
            this.btnSelectMongoDB.UseVisualStyleBackColor = true;
            this.btnSelectMongoDB.Click += new System.EventHandler(this.btnSelectMongoDB_Click);
            // 
            // txtQtdSelect
            // 
            this.txtQtdSelect.Location = new System.Drawing.Point(302, 16);
            this.txtQtdSelect.Name = "txtQtdSelect";
            this.txtQtdSelect.Size = new System.Drawing.Size(117, 20);
            this.txtQtdSelect.TabIndex = 29;
            // 
            // lblQtdSelect
            // 
            this.lblQtdSelect.AutoSize = true;
            this.lblQtdSelect.Location = new System.Drawing.Point(218, 23);
            this.lblQtdSelect.Name = "lblQtdSelect";
            this.lblQtdSelect.Size = new System.Drawing.Size(74, 13);
            this.lblQtdSelect.TabIndex = 28;
            this.lblQtdSelect.Text = "QTD SELECT";
            // 
            // gpSelectMongoDB
            // 
            this.gpSelectMongoDB.Controls.Add(this.txtMarcaLinhasRetornoMongoDB);
            this.gpSelectMongoDB.Controls.Add(this.label2);
            this.gpSelectMongoDB.Controls.Add(this.txtRegistraTempoLiqSelectMong);
            this.gpSelectMongoDB.Controls.Add(this.label6);
            this.gpSelectMongoDB.Controls.Add(this.label7);
            this.gpSelectMongoDB.Controls.Add(this.lblRegistaHoraIniSelectMongo);
            this.gpSelectMongoDB.Controls.Add(this.lblRegistaHoraFimSelectMongo);
            this.gpSelectMongoDB.Controls.Add(this.label10);
            this.gpSelectMongoDB.Location = new System.Drawing.Point(381, 84);
            this.gpSelectMongoDB.Name = "gpSelectMongoDB";
            this.gpSelectMongoDB.Size = new System.Drawing.Size(327, 155);
            this.gpSelectMongoDB.TabIndex = 28;
            this.gpSelectMongoDB.TabStop = false;
            this.gpSelectMongoDB.Text = "SELECT MongoDB";
            // 
            // txtRegistraTempoLiqSelectMong
            // 
            this.txtRegistraTempoLiqSelectMong.Enabled = false;
            this.txtRegistraTempoLiqSelectMong.Location = new System.Drawing.Point(117, 100);
            this.txtRegistraTempoLiqSelectMong.Name = "txtRegistraTempoLiqSelectMong";
            this.txtRegistraTempoLiqSelectMong.Size = new System.Drawing.Size(132, 20);
            this.txtRegistraTempoLiqSelectMong.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tempo Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Hora inicial:";
            // 
            // lblRegistaHoraIniSelectMongo
            // 
            this.lblRegistaHoraIniSelectMongo.AutoSize = true;
            this.lblRegistaHoraIniSelectMongo.Location = new System.Drawing.Point(120, 31);
            this.lblRegistaHoraIniSelectMongo.Name = "lblRegistaHoraIniSelectMongo";
            this.lblRegistaHoraIniSelectMongo.Size = new System.Drawing.Size(10, 13);
            this.lblRegistaHoraIniSelectMongo.TabIndex = 36;
            this.lblRegistaHoraIniSelectMongo.Text = ".";
            // 
            // lblRegistaHoraFimSelectMongo
            // 
            this.lblRegistaHoraFimSelectMongo.AutoSize = true;
            this.lblRegistaHoraFimSelectMongo.Location = new System.Drawing.Point(120, 64);
            this.lblRegistaHoraFimSelectMongo.Name = "lblRegistaHoraFimSelectMongo";
            this.lblRegistaHoraFimSelectMongo.Size = new System.Drawing.Size(10, 13);
            this.lblRegistaHoraFimSelectMongo.TabIndex = 37;
            this.lblRegistaHoraFimSelectMongo.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Hora final:";
            // 
            // btnSelectSQL
            // 
            this.btnSelectSQL.Location = new System.Drawing.Point(15, 51);
            this.btnSelectSQL.Name = "btnSelectSQL";
            this.btnSelectSQL.Size = new System.Drawing.Size(75, 29);
            this.btnSelectSQL.TabIndex = 28;
            this.btnSelectSQL.Text = "SELECT";
            this.btnSelectSQL.UseVisualStyleBackColor = true;
            this.btnSelectSQL.Click += new System.EventHandler(this.btnSelectSQL_Click);
            // 
            // gpSelectSQL
            // 
            this.gpSelectSQL.Controls.Add(this.txtMarcaLinhasRetornoSQL);
            this.gpSelectSQL.Controls.Add(this.lblLinhasRetornoSql);
            this.gpSelectSQL.Controls.Add(this.txtRegistraHoraLiqSelectSQL);
            this.gpSelectSQL.Controls.Add(this.label5);
            this.gpSelectSQL.Controls.Add(this.label1);
            this.gpSelectSQL.Controls.Add(this.lblRegistaHoraIniSelectSQl);
            this.gpSelectSQL.Controls.Add(this.lblRegistaHoraFimSelectSQl);
            this.gpSelectSQL.Controls.Add(this.label4);
            this.gpSelectSQL.Location = new System.Drawing.Point(18, 430);
            this.gpSelectSQL.Name = "gpSelectSQL";
            this.gpSelectSQL.Size = new System.Drawing.Size(327, 165);
            this.gpSelectSQL.TabIndex = 27;
            this.gpSelectSQL.TabStop = false;
            this.gpSelectSQL.Text = "SELECT SQL Server";
            // 
            // txtRegistraHoraLiqSelectSQL
            // 
            this.txtRegistraHoraLiqSelectSQL.Enabled = false;
            this.txtRegistraHoraLiqSelectSQL.Location = new System.Drawing.Point(94, 100);
            this.txtRegistraHoraLiqSelectSQL.Name = "txtRegistraHoraLiqSelectSQL";
            this.txtRegistraHoraLiqSelectSQL.Size = new System.Drawing.Size(132, 20);
            this.txtRegistraHoraLiqSelectSQL.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tempo Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hora inicial:";
            // 
            // lblRegistaHoraIniSelectSQl
            // 
            this.lblRegistaHoraIniSelectSQl.AutoSize = true;
            this.lblRegistaHoraIniSelectSQl.Location = new System.Drawing.Point(101, 31);
            this.lblRegistaHoraIniSelectSQl.Name = "lblRegistaHoraIniSelectSQl";
            this.lblRegistaHoraIniSelectSQl.Size = new System.Drawing.Size(10, 13);
            this.lblRegistaHoraIniSelectSQl.TabIndex = 30;
            this.lblRegistaHoraIniSelectSQl.Text = ".";
            // 
            // lblRegistaHoraFimSelectSQl
            // 
            this.lblRegistaHoraFimSelectSQl.AutoSize = true;
            this.lblRegistaHoraFimSelectSQl.Location = new System.Drawing.Point(101, 64);
            this.lblRegistaHoraFimSelectSQl.Name = "lblRegistaHoraFimSelectSQl";
            this.lblRegistaHoraFimSelectSQl.Size = new System.Drawing.Size(10, 13);
            this.lblRegistaHoraFimSelectSQl.TabIndex = 31;
            this.lblRegistaHoraFimSelectSQl.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Hora final:";
            // 
            // txtMarcaLinhasRetornoSQL
            // 
            this.txtMarcaLinhasRetornoSQL.Enabled = false;
            this.txtMarcaLinhasRetornoSQL.Location = new System.Drawing.Point(94, 135);
            this.txtMarcaLinhasRetornoSQL.Name = "txtMarcaLinhasRetornoSQL";
            this.txtMarcaLinhasRetornoSQL.Size = new System.Drawing.Size(132, 20);
            this.txtMarcaLinhasRetornoSQL.TabIndex = 36;
            // 
            // lblLinhasRetornoSql
            // 
            this.lblLinhasRetornoSql.AutoSize = true;
            this.lblLinhasRetornoSql.Location = new System.Drawing.Point(18, 138);
            this.lblLinhasRetornoSql.Name = "lblLinhasRetornoSql";
            this.lblLinhasRetornoSql.Size = new System.Drawing.Size(76, 13);
            this.lblLinhasRetornoSql.TabIndex = 35;
            this.lblLinhasRetornoSql.Text = "Qtd Linha Ret.";
            // 
            // txtMarcaLinhasRetornoMongoDB
            // 
            this.txtMarcaLinhasRetornoMongoDB.Enabled = false;
            this.txtMarcaLinhasRetornoMongoDB.Location = new System.Drawing.Point(117, 132);
            this.txtMarcaLinhasRetornoMongoDB.Name = "txtMarcaLinhasRetornoMongoDB";
            this.txtMarcaLinhasRetornoMongoDB.Size = new System.Drawing.Size(132, 20);
            this.txtMarcaLinhasRetornoMongoDB.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Qtd Linha Ret.";
            // 
            // btnRodaTudo
            // 
            this.btnRodaTudo.Font = new System.Drawing.Font("MS Reference Specialty", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRodaTudo.Location = new System.Drawing.Point(305, 293);
            this.btnRodaTudo.Name = "btnRodaTudo";
            this.btnRodaTudo.Size = new System.Drawing.Size(126, 50);
            this.btnRodaTudo.TabIndex = 28;
            this.btnRodaTudo.Text = "TUDÃO";
            this.btnRodaTudo.UseVisualStyleBackColor = true;
            this.btnRodaTudo.Click += new System.EventHandler(this.btnRodaTudo_Click);
            // 
            // ForInsertDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 614);
            this.Controls.Add(this.btnRodaTudo);
            this.Controls.Add(this.gpSelectSQL);
            this.Controls.Add(this.gpSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpMongoDB);
            this.Controls.Add(this.grCentro);
            this.Controls.Add(this.lblSaldacao);
            this.Name = "ForInsertDB";
            this.Load += new System.EventHandler(this.ForInsertDB_Load);
            this.grCentro.ResumeLayout(false);
            this.grCentro.PerformLayout();
            this.gpMongoDB.ResumeLayout(false);
            this.gpMongoDB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpSelect.ResumeLayout(false);
            this.gpSelect.PerformLayout();
            this.gpSelectMongoDB.ResumeLayout(false);
            this.gpSelectMongoDB.PerformLayout();
            this.gpSelectSQL.ResumeLayout(false);
            this.gpSelectSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsereSQLServer;
        private System.Windows.Forms.Label lblSaldacao;
        private System.Windows.Forms.Button btnMongoDB;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMarcaHoraIni;
        private System.Windows.Forms.Label lblMarcaHoraFim;
        private System.Windows.Forms.Label lblMarcaStatus;
        private System.Windows.Forms.Label lblQtdInsert;
        private System.Windows.Forms.TextBox txtQtdInsert;
        private System.Windows.Forms.Label lblInserindo2;
        private System.Windows.Forms.Label lblInserindo3;
        private System.Windows.Forms.Label lblInserindo1;
        private System.Windows.Forms.Label lblTempoTotal;
        private System.Windows.Forms.TextBox txtTempoTotal;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.GroupBox grCentro;
        private System.Windows.Forms.GroupBox gpMongoDB;
        private System.Windows.Forms.Label lblHoraInicialMongo;
        private System.Windows.Forms.Label lblMarcaHoraIniMongo;
        private System.Windows.Forms.TextBox txtTempoTotalMongo;
        private System.Windows.Forms.Label lblMarcaHoraFimMongo;
        private System.Windows.Forms.Label lblTempoTotalMongo;
        private System.Windows.Forms.Label lblHoraFinalMongo;
        private System.Windows.Forms.Label lblInserindoMongo1;
        private System.Windows.Forms.Label lblStatusMongo;
        private System.Windows.Forms.Label label8lblInserindoMongo3;
        private System.Windows.Forms.Label lblMarcaStatusMongo;
        private System.Windows.Forms.Label lblInserindoMongo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpSelect;
        private System.Windows.Forms.GroupBox gpSelectMongoDB;
        private System.Windows.Forms.GroupBox gpSelectSQL;
        private System.Windows.Forms.Button btnSelectMongoDB;
        private System.Windows.Forms.Button btnSelectSQL;
        private System.Windows.Forms.Label lblQtdSelect;
        private System.Windows.Forms.TextBox txtQtdSelect;
        private System.Windows.Forms.Button btnComparaSelect;
        private System.Windows.Forms.TextBox txtRegistraTempoLiqSelectMong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRegistaHoraIniSelectMongo;
        private System.Windows.Forms.Label lblRegistaHoraFimSelectMongo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegistraHoraLiqSelectSQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistaHoraIniSelectSQl;
        private System.Windows.Forms.Label lblRegistaHoraFimSelectSQl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarcaLinhasRetornoMongoDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarcaLinhasRetornoSQL;
        private System.Windows.Forms.Label lblLinhasRetornoSql;
        private System.Windows.Forms.Button btnRodaTudo;
    }
}