using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnShow.Visible = false;          
            
            

            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            /*for (int i = 0; i < txtSenha.Text.Length; i++)
            {
                
            }*/
            txtSenha.UseSystemPasswordChar = false;
            Thread.Sleep(150);
            txtSenha.UseSystemPasswordChar = true;


        }

        private void loginValidate()
        {


            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    SqlCommand cm = new SqlCommand();
                    cn.Open();
                    cm.CommandText = "select * from loginUser where lg_user = ('" + txtLogin.Text + "') and pass_user = ('" + txtSenha.Text + "') ";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();

                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    
                   if (dt.HasRows)
                   {
                        cn.Close();
                        registraEntrada();
                        
                        this.Hide();
                        frmInitial registro = new frmInitial();
                        registro.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado! Verifique o usuário/senha", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no banco de dados '" + ex.Message + "'", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                }
                finally
                {


                    cn.Close();


                }
            }
        }
        private void registraEntrada()
        {
            try
            {

                cn.Open();
                    SqlCommand cm = new SqlCommand();
                    



                    cm.CommandText = "select * from marcaPonto";
                    cm.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cm; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    string login = txtLogin.Text;
                    string entrada = "Entrada";
                    DateTime lastUp = DateTime.Now;


                    string sql = "insert into marcaPonto(lg_user,ent_sai,registerHour) values(@login,@entrada,@lastUp)";
                    SqlCommand cmd = new SqlCommand(sql, cn);


                    cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@entrada", SqlDbType.VarChar).Value = entrada;
                    cmd.Parameters.Add("lastUp", SqlDbType.DateTime).Value = lastUp;
                    

                    cmd.ExecuteNonQuery(); //Executar sem consulta

                MessageBox.Show("Horario de entrada: " + lastUp, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Marcar entrada ?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                loginValidate();
            }
            else
            {
                this.Hide();
                frmInitial registro = new frmInitial();
                registro.Show();
            }
            

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();          

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            frmNewLogin novo = new frmNewLogin();
            novo.ShowDialog();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            btnShow.Visible = true;
            txtSenha.UseSystemPasswordChar = false;

        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            btnShow.Visible=false;
            txtSenha.UseSystemPasswordChar = true;

        }
    }
}
