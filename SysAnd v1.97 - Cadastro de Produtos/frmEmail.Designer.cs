namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    partial class frmEmail
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
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbAnexo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.cbEmailType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(207, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Remetente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(53, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Destinatário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(53, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Assunto";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMensagem.Location = new System.Drawing.Point(143, 208);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(350, 223);
            this.txtMensagem.TabIndex = 26;
            this.txtMensagem.Tag = "<html></html>";
            this.txtMensagem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(53, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mensagem";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnviar.Location = new System.Drawing.Point(210, 475);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(143, 32);
            this.btnEnviar.TabIndex = 29;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtAnexo
            // 
            this.txtAnexo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAnexo.Enabled = false;
            this.txtAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAnexo.Location = new System.Drawing.Point(483, 171);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(10, 23);
            this.txtAnexo.TabIndex = 30;
            this.txtAnexo.Click += new System.EventHandler(this.txtAnexo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbAnexo
            // 
            this.cbAnexo.AutoSize = true;
            this.cbAnexo.Location = new System.Drawing.Point(421, 174);
            this.cbAnexo.Name = "cbAnexo";
            this.cbAnexo.Size = new System.Drawing.Size(56, 17);
            this.cbAnexo.TabIndex = 31;
            this.cbAnexo.Text = "Anexo";
            this.cbAnexo.UseVisualStyleBackColor = true;
            this.cbAnexo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cc";
            // 
            // txtRemetente
            // 
            this.txtRemetente.Enabled = false;
            this.txtRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRemetente.Location = new System.Drawing.Point(210, 58);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(267, 24);
            this.txtRemetente.TabIndex = 33;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDestinatario.Location = new System.Drawing.Point(146, 91);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(267, 24);
            this.txtDestinatario.TabIndex = 34;
            // 
            // txtCc
            // 
            this.txtCc.Enabled = false;
            this.txtCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCc.Location = new System.Drawing.Point(146, 128);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(267, 24);
            this.txtCc.TabIndex = 35;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Enabled = false;
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAssunto.Location = new System.Drawing.Point(146, 167);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(267, 24);
            this.txtAssunto.TabIndex = 36;
            // 
            // cbEmailType
            // 
            this.cbEmailType.FormattingEnabled = true;
            this.cbEmailType.Items.AddRange(new object[] {
            "Manutenção"});
            this.cbEmailType.Location = new System.Drawing.Point(56, 58);
            this.cbEmailType.Name = "cbEmailType";
            this.cbEmailType.Size = new System.Drawing.Size(121, 21);
            this.cbEmailType.TabIndex = 37;
            this.cbEmailType.SelectedIndexChanged += new System.EventHandler(this.cbEmailType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(53, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tipo de Email";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEmailType);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAnexo);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysAnd v1.97 - Email";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbAnexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.ComboBox cbEmailType;
        private System.Windows.Forms.Label label5;
    }
}