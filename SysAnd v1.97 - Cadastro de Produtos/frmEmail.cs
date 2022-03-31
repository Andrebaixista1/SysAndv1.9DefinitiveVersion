using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtRemetente.Text != "" && txtDestinatario.Text != "" && txtCc.Text != "" && txtAssunto.Text != "" && txtMensagem.Text != "")
            {
                EmailEnviar();

            }
            else
            {
                MessageBox.Show("Preencha todos os campos para enviar o email","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void EmailEnviar()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //Servidor SMTP

                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        //smtp.Credentials = new System.Net.NetworkCredential(txtRemetente.Text, "rdosrvstrwbastng"); //Meu Gmail
                        smtp.Credentials = new System.Net.NetworkCredential(txtRemetente.Text, "Brmobile@2020"); //Gmail FIX
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Emais (Mensagem)
                        email.From = new MailAddress(txtRemetente.Text);
                        email.To.Add(txtDestinatario.Text);
                        email.CC.Add(txtCc.Text);

                        email.Subject = txtAssunto.Text;
                        email.IsBodyHtml = true;
                        email.Body = txtMensagem.Text;
                       

                        // Anexo
                        if (txtAnexo.Text != "")
                        {
                            var anexo = txtAnexo.Text.ToString().Split(';');
                            for (int i = 0; i < anexo.Count(); i++)
                                email.Attachments.Add(new Attachment(anexo[i]));
                        }
                            

                        // Enviar email
                        smtp.Send(email);
                        MessageBox.Show("Email enviado","Atenção !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAnexo_Click(object sender, EventArgs e)
        {
            var anexo = new OpenFileDialog();
            anexo.Multiselect = true;
            anexo.Title = "Anexar arquivos";
            
            if (anexo.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < anexo.FileNames.Count(); i++)
                    if(i == 0)
                        txtAnexo.Text = anexo.FileNames[i];
                    else
                        txtAnexo.Text = txtAnexo.Text + ";" + anexo.FileNames[i];

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnexo.Checked)
            {
                txtAnexo.Enabled = true;
            }
            else
            {
                txtAnexo.Enabled = false;
            }
        }

        private void cbEmailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmailType.Text == "Manutenção")
            {
                txtRemetente.Text = "contato@fixmobile.com.br";
                txtDestinatario.Text = "contato@fixmobile.com.br";
                txtCc.Text = "andrbter@gmail.com";
                txtAssunto.Text = "Manutenção do dia - " + DateTime.Now.ToString("d");
            }
        }
    }
}
