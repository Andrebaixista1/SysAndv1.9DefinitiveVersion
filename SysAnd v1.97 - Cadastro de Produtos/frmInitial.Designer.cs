namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    partial class frmInitial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbEntrada = new System.Windows.Forms.CheckBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.txtReparo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbSucata = new System.Windows.Forms.RadioButton();
            this.rbConcluido = new System.Windows.Forms.RadioButton();
            this.rbRIniciado = new System.Windows.Forms.RadioButton();
            this.rbAReparo = new System.Windows.Forms.RadioButton();
            this.rbAChegada = new System.Windows.Forms.RadioButton();
            this.rbACompra = new System.Windows.Forms.RadioButton();
            this.rbVTecnico = new System.Windows.Forms.RadioButton();
            this.rbLaudo = new System.Windows.Forms.RadioButton();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.cbSaida = new System.Windows.Forms.CheckBox();
            this.gbGarantia = new System.Windows.Forms.GroupBox();
            this.rbNaoG = new System.Windows.Forms.RadioButton();
            this.rbSimG = new System.Windows.Forms.RadioButton();
            this.gbLaudo = new System.Windows.Forms.GroupBox();
            this.rbNaoL = new System.Windows.Forms.RadioButton();
            this.rbSimL = new System.Windows.Forms.RadioButton();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblAtualizacao = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbGarantia.SuspendLayout();
            this.gbLaudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.filtrarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_microsoft_excel_2019_32;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.downloadToolStripMenuItem.Text = "Abrir Excel";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_banco_de_dados_32;
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.filtrarToolStripMenuItem.Text = "Banco de Dados";
            this.filtrarToolStripMenuItem.Click += new System.EventHandler(this.filtrarToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_adicionar_usuário_masculino_32;
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(317, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(221, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Patrimônio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(108, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "OS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label13.Location = new System.Drawing.Point(20, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Defeitos";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtID.Location = new System.Drawing.Point(46, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 24);
            this.txtID.TabIndex = 14;
            this.txtID.Text = "00";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(955, 2);
            this.txtData.Mask = "00/00/0000 00:00:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(119, 20);
            this.txtData.TabIndex = 15;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbEntrada
            // 
            this.cbEntrada.AutoSize = true;
            this.cbEntrada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEntrada.Location = new System.Drawing.Point(890, 4);
            this.cbEntrada.Name = "cbEntrada";
            this.cbEntrada.Size = new System.Drawing.Size(63, 17);
            this.cbEntrada.TabIndex = 16;
            this.cbEntrada.Text = "Entrada";
            this.cbEntrada.UseVisualStyleBackColor = false;
            this.cbEntrada.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOS.Location = new System.Drawing.Point(150, 40);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(56, 24);
            this.txtOS.TabIndex = 17;
            this.txtOS.Text = "000000";
            this.txtOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // txtCod
            // 
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCod.Location = new System.Drawing.Point(322, 41);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 24);
            this.txtCod.TabIndex = 18;
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Galaxy A01 Core (A013)",
            "Galaxy A02 (A022)",
            "Galaxy A03s (A037)",
            "Galaxy A10s (A107)",
            "Galaxy A11 (A115)",
            "Galaxy J5 Prime (G570)",
            "Galaxy J5 Pro (J530)",
            "Galaxy J7 Metal (J710)",
            "Galaxy J7 Prime (G610M)",
            "Galaxy J7 Prime 2 (G611)",
            "Galaxy S10 (G973)",
            "Galaxy S10e (G970)",
            "Galaxy S20 (G980)",
            "Galaxy S6 (G920)",
            "Galaxy S7 (G930)",
            "Galaxy S7 Edge (G935)",
            "Galaxy S8 (G950)",
            "Galaxy TAB A - 10.5\" (T590)",
            "Galaxy Tab A 10.1\" (T510)",
            "Galaxy TAB A 8\" (T290)",
            "Galaxy Tab A 9.7\" (P555)",
            "Galaxy Tab A6 7\" (T280)",
            "Galaxy Tab Active 2 (T395)",
            "Galaxy TAB E - 9.6\" (T561M)",
            "iPad Air - 9.7\" Wi-fi (A1475)",
            "iPad Air 2 - 9.7\" 4G (A1396)",
            "iPhone 11 (A2111)",
            "iPhone 11 Pro Max (A2218)",
            "iPhone 6 (A1549)",
            "iPhone 7 (A1660)",
            "iPhone 8 (A1864)",
            "iPhone X (A1865)",
            "iPhone XS Max (A1921)",
            "Moto E6 Plus (XT2025)",
            "Moto E7 Plus (XT2081)",
            "Moto G20 (XT2128)",
            "Moto G5S Plus (XT1802)",
            "Moto G6 Play (XT1922)",
            "Moto G8 Play (XT2015)"});
            this.cbModelo.Location = new System.Drawing.Point(86, 83);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(225, 23);
            this.cbModelo.Sorted = true;
            this.cbModelo.TabIndex = 19;
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Ametista",
            "Azul",
            "Branco",
            "Cinza",
            "Cinza Metálico",
            "Dourado",
            "Indigo",
            "Marrom",
            "Prata",
            "Preto",
            "Vermelho"});
            this.cbColor.Location = new System.Drawing.Point(362, 83);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(106, 23);
            this.cbColor.Sorted = true;
            this.cbColor.TabIndex = 20;
            // 
            // txtDefeito
            // 
            this.txtDefeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDefeito.Location = new System.Drawing.Point(24, 235);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(295, 113);
            this.txtDefeito.TabIndex = 21;
            this.txtDefeito.Tag = "teste";
            this.txtDefeito.TextChanged += new System.EventHandler(this.txtDefeito_TextChanged);
            // 
            // txtReparo
            // 
            this.txtReparo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtReparo.Location = new System.Drawing.Point(342, 235);
            this.txtReparo.Multiline = true;
            this.txtReparo.Name = "txtReparo";
            this.txtReparo.Size = new System.Drawing.Size(295, 113);
            this.txtReparo.TabIndex = 23;
            this.txtReparo.TextChanged += new System.EventHandler(this.txtReparo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(338, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Reparo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbSucata);
            this.gbStatus.Controls.Add(this.rbConcluido);
            this.gbStatus.Controls.Add(this.rbRIniciado);
            this.gbStatus.Controls.Add(this.rbAReparo);
            this.gbStatus.Controls.Add(this.rbAChegada);
            this.gbStatus.Controls.Add(this.rbACompra);
            this.gbStatus.Controls.Add(this.rbVTecnico);
            this.gbStatus.Controls.Add(this.rbLaudo);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbStatus.Location = new System.Drawing.Point(16, 129);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(677, 65);
            this.gbStatus.TabIndex = 24;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbSucata
            // 
            this.rbSucata.AutoSize = true;
            this.rbSucata.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbSucata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbSucata.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbSucata.Location = new System.Drawing.Point(625, 22);
            this.rbSucata.Name = "rbSucata";
            this.rbSucata.Size = new System.Drawing.Size(45, 30);
            this.rbSucata.TabIndex = 7;
            this.rbSucata.TabStop = true;
            this.rbSucata.Text = "Sucata";
            this.rbSucata.UseVisualStyleBackColor = true;
            // 
            // rbConcluido
            // 
            this.rbConcluido.AutoSize = true;
            this.rbConcluido.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbConcluido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbConcluido.Location = new System.Drawing.Point(569, 22);
            this.rbConcluido.Name = "rbConcluido";
            this.rbConcluido.Size = new System.Drawing.Size(60, 30);
            this.rbConcluido.TabIndex = 6;
            this.rbConcluido.TabStop = true;
            this.rbConcluido.Text = "Concluído";
            this.rbConcluido.UseVisualStyleBackColor = true;
            this.rbConcluido.CheckedChanged += new System.EventHandler(this.rbConcluido_CheckedChanged);
            this.rbConcluido.Click += new System.EventHandler(this.rbConcluido_Click);
            // 
            // rbRIniciado
            // 
            this.rbRIniciado.AutoSize = true;
            this.rbRIniciado.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRIniciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbRIniciado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbRIniciado.Location = new System.Drawing.Point(487, 22);
            this.rbRIniciado.Name = "rbRIniciado";
            this.rbRIniciado.Size = new System.Drawing.Size(86, 30);
            this.rbRIniciado.TabIndex = 5;
            this.rbRIniciado.TabStop = true;
            this.rbRIniciado.Text = "Reparo Iniciado";
            this.rbRIniciado.UseVisualStyleBackColor = true;
            // 
            // rbAReparo
            // 
            this.rbAReparo.AutoSize = true;
            this.rbAReparo.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbAReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbAReparo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbAReparo.Location = new System.Drawing.Point(384, 22);
            this.rbAReparo.Name = "rbAReparo";
            this.rbAReparo.Size = new System.Drawing.Size(107, 30);
            this.rbAReparo.TabIndex = 4;
            this.rbAReparo.TabStop = true;
            this.rbAReparo.Text = "Aguardando Reparo";
            this.rbAReparo.UseVisualStyleBackColor = true;
            // 
            // rbAChegada
            // 
            this.rbAChegada.AutoSize = true;
            this.rbAChegada.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbAChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbAChegada.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbAChegada.Location = new System.Drawing.Point(274, 22);
            this.rbAChegada.Name = "rbAChegada";
            this.rbAChegada.Size = new System.Drawing.Size(115, 30);
            this.rbAChegada.TabIndex = 3;
            this.rbAChegada.TabStop = true;
            this.rbAChegada.Text = "Aguardando Chegada";
            this.rbAChegada.UseVisualStyleBackColor = true;
            // 
            // rbACompra
            // 
            this.rbACompra.AutoSize = true;
            this.rbACompra.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbACompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbACompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbACompra.Location = new System.Drawing.Point(170, 22);
            this.rbACompra.Name = "rbACompra";
            this.rbACompra.Size = new System.Drawing.Size(108, 30);
            this.rbACompra.TabIndex = 2;
            this.rbACompra.TabStop = true;
            this.rbACompra.Text = "Aguardando Compra";
            this.rbACompra.UseVisualStyleBackColor = true;
            // 
            // rbVTecnico
            // 
            this.rbVTecnico.AutoSize = true;
            this.rbVTecnico.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbVTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbVTecnico.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbVTecnico.Location = new System.Drawing.Point(73, 22);
            this.rbVTecnico.Name = "rbVTecnico";
            this.rbVTecnico.Size = new System.Drawing.Size(100, 30);
            this.rbVTecnico.TabIndex = 1;
            this.rbVTecnico.TabStop = true;
            this.rbVTecnico.Text = "Validação Técnico";
            this.rbVTecnico.UseVisualStyleBackColor = true;
            // 
            // rbLaudo
            // 
            this.rbLaudo.AutoSize = true;
            this.rbLaudo.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbLaudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbLaudo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbLaudo.Location = new System.Drawing.Point(6, 22);
            this.rbLaudo.Name = "rbLaudo";
            this.rbLaudo.Size = new System.Drawing.Size(71, 30);
            this.rbLaudo.TabIndex = 0;
            this.rbLaudo.TabStop = true;
            this.rbLaudo.Text = "Laudo Inicial";
            this.rbLaudo.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtObs.Location = new System.Drawing.Point(46, 398);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(398, 136);
            this.txtObs.TabIndex = 26;
            this.txtObs.Tag = "teste";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(42, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Observação";
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSaida.Location = new System.Drawing.Point(1143, 1);
            this.txtSaida.Mask = "00/00/0000 00:00:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(119, 23);
            this.txtSaida.TabIndex = 27;
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSaida
            // 
            this.cbSaida.AutoSize = true;
            this.cbSaida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSaida.Location = new System.Drawing.Point(1090, 5);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(53, 17);
            this.cbSaida.TabIndex = 28;
            this.cbSaida.Text = "Saida";
            this.cbSaida.UseVisualStyleBackColor = false;
            this.cbSaida.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // gbGarantia
            // 
            this.gbGarantia.Controls.Add(this.rbNaoG);
            this.gbGarantia.Controls.Add(this.rbSimG);
            this.gbGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbGarantia.Location = new System.Drawing.Point(513, 465);
            this.gbGarantia.Name = "gbGarantia";
            this.gbGarantia.Size = new System.Drawing.Size(79, 69);
            this.gbGarantia.TabIndex = 29;
            this.gbGarantia.TabStop = false;
            this.gbGarantia.Text = "Garantia";
            // 
            // rbNaoG
            // 
            this.rbNaoG.AutoSize = true;
            this.rbNaoG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbNaoG.Location = new System.Drawing.Point(19, 43);
            this.rbNaoG.Name = "rbNaoG";
            this.rbNaoG.Size = new System.Drawing.Size(45, 17);
            this.rbNaoG.TabIndex = 1;
            this.rbNaoG.TabStop = true;
            this.rbNaoG.Text = "Não";
            this.rbNaoG.UseVisualStyleBackColor = true;
            // 
            // rbSimG
            // 
            this.rbSimG.AutoSize = true;
            this.rbSimG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbSimG.Location = new System.Drawing.Point(19, 20);
            this.rbSimG.Name = "rbSimG";
            this.rbSimG.Size = new System.Drawing.Size(42, 17);
            this.rbSimG.TabIndex = 0;
            this.rbSimG.TabStop = true;
            this.rbSimG.Text = "Sim";
            this.rbSimG.UseVisualStyleBackColor = true;
            // 
            // gbLaudo
            // 
            this.gbLaudo.Controls.Add(this.rbNaoL);
            this.gbLaudo.Controls.Add(this.rbSimL);
            this.gbLaudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbLaudo.Location = new System.Drawing.Point(513, 373);
            this.gbLaudo.Name = "gbLaudo";
            this.gbLaudo.Size = new System.Drawing.Size(79, 69);
            this.gbLaudo.TabIndex = 30;
            this.gbLaudo.TabStop = false;
            this.gbLaudo.Text = "Laudo";
            // 
            // rbNaoL
            // 
            this.rbNaoL.AutoSize = true;
            this.rbNaoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbNaoL.Location = new System.Drawing.Point(19, 43);
            this.rbNaoL.Name = "rbNaoL";
            this.rbNaoL.Size = new System.Drawing.Size(45, 17);
            this.rbNaoL.TabIndex = 1;
            this.rbNaoL.TabStop = true;
            this.rbNaoL.Text = "Não";
            this.rbNaoL.UseVisualStyleBackColor = true;
            // 
            // rbSimL
            // 
            this.rbSimL.AutoSize = true;
            this.rbSimL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbSimL.Location = new System.Drawing.Point(19, 20);
            this.rbSimL.Name = "rbSimL";
            this.rbSimL.Size = new System.Drawing.Size(42, 17);
            this.rbSimL.TabIndex = 0;
            this.rbSimL.TabStop = true;
            this.rbSimL.Text = "Sim";
            this.rbSimL.UseVisualStyleBackColor = true;
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(699, 70);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(575, 570);
            this.dgvTabela.TabIndex = 36;
            this.dgvTabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTabela_MouseDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(699, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.Text = "Procurar...";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 623);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 17);
            this.progressBar1.TabIndex = 38;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(124, 625);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(71, 13);
            this.lblProgress.TabIndex = 39;
            this.lblProgress.Text = "Loading... 0%";
            this.lblProgress.Visible = false;
            // 
            // lblAtualizacao
            // 
            this.lblAtualizacao.AutoSize = true;
            this.lblAtualizacao.Location = new System.Drawing.Point(1066, 46);
            this.lblAtualizacao.Name = "lblAtualizacao";
            this.lblAtualizacao.Size = new System.Drawing.Size(94, 13);
            this.lblAtualizacao.TabIndex = 40;
            this.lblAtualizacao.Text = "Ultima Atualização";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(1163, 46);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(13, 13);
            this.lblLast.TabIndex = 41;
            this.lblLast.Text = "0";
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_apagar_para_sempre_25;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(273, 575);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(69, 31);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_atualizações_disponíveis_25;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(186, 575);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(69, 31);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_cancelar_2_25;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(558, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_salvar_25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(103, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 31);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::SysAnd_v1._97___Cadastro_de_Produtos.Properties.Resources.icons8_novo_arquivo_25;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(16, 575);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 31);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 643);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblAtualizacao);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbLaudo);
            this.Controls.Add(this.gbGarantia);
            this.Controls.Add(this.cbSaida);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.txtReparo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDefeito);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.cbEntrada);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysAnd v1.97 - Cadastro de Produtos";
            this.Deactivate += new System.EventHandler(this.frmInitial_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInitial_FormClosed);
            this.Load += new System.EventHandler(this.frmInitial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbGarantia.ResumeLayout(false);
            this.gbGarantia.PerformLayout();
            this.gbLaudo.ResumeLayout(false);
            this.gbLaudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.CheckBox cbEntrada;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.TextBox txtReparo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbLaudo;
        private System.Windows.Forms.RadioButton rbVTecnico;
        private System.Windows.Forms.RadioButton rbConcluido;
        private System.Windows.Forms.RadioButton rbRIniciado;
        private System.Windows.Forms.RadioButton rbAReparo;
        private System.Windows.Forms.RadioButton rbAChegada;
        private System.Windows.Forms.RadioButton rbACompra;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.CheckBox cbSaida;
        private System.Windows.Forms.GroupBox gbGarantia;
        private System.Windows.Forms.RadioButton rbNaoG;
        private System.Windows.Forms.RadioButton rbSimG;
        private System.Windows.Forms.GroupBox gbLaudo;
        private System.Windows.Forms.RadioButton rbNaoL;
        private System.Windows.Forms.RadioButton rbSimL;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbSucata;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblAtualizacao;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
    }
}

