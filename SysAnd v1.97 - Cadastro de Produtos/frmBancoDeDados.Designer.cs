namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    partial class frmBancoDeDados
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
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.dgvContagem = new System.Windows.Forms.DataGridView();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.AllowUserToAddRows = false;
            this.dgvDataBase.AllowUserToDeleteRows = false;
            this.dgvDataBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBase.Location = new System.Drawing.Point(12, 174);
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.ReadOnly = true;
            this.dgvDataBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataBase.Size = new System.Drawing.Size(1464, 645);
            this.dgvDataBase.TabIndex = 0;
            // 
            // dgvContagem
            // 
            this.dgvContagem.AllowUserToAddRows = false;
            this.dgvContagem.AllowUserToDeleteRows = false;
            this.dgvContagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContagem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContagem.Location = new System.Drawing.Point(12, 12);
            this.dgvContagem.Name = "dgvContagem";
            this.dgvContagem.ReadOnly = true;
            this.dgvContagem.RowTemplate.Height = 19;
            this.dgvContagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContagem.Size = new System.Drawing.Size(217, 150);
            this.dgvContagem.TabIndex = 1;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Validação Técnico",
            "Sucata",
            "Reparo Iniciado",
            "Concluído",
            "Aguardando Reparo",
            "Aguardando Compra"});
            this.cbFiltro.Location = new System.Drawing.Point(235, 131);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(198, 21);
            this.cbFiltro.TabIndex = 2;
            this.cbFiltro.Text = "Selecione o Status...";
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            this.cbFiltro.DataSourceChanged += new System.EventHandler(this.cbFiltro_DataSourceChanged);
            this.cbFiltro.TextChanged += new System.EventHandler(this.cbFiltro_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Enabled = false;
            this.btnExcel.Location = new System.Drawing.Point(440, 130);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(93, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Abrir no Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 831);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgvContagem);
            this.Controls.Add(this.dgvDataBase);
            this.Name = "frmBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysAnd v1.97 - Banco de Dados";
            this.Load += new System.EventHandler(this.frmBancoDeDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataBase;
        private System.Windows.Forms.DataGridView dgvContagem;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnExcel;
    }
}