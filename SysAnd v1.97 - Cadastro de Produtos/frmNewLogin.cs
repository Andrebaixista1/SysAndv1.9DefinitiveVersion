using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmNewLogin : Form
    {
        public frmNewLogin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;
        private void saveInDataBase()
        {




            try
            {

                string senha = txtSenha.Text;
                string login = txtLogin.Text;
                string nome = txtNome.Text;


                if (senha == "" || login == "" || nome == "")
                {
                    MessageBox.Show("Preencha todos campos ! ", "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {


                    SqlCommand cm = new SqlCommand();
                    cn.Open();



                    cm.CommandText = "select * from loginUser";
                    cm.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cm; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    



                    string sql = "insert into loginUser(lg_user,pass_user,nm_user) values(@login,@senha,@nome)";
                    SqlCommand cmd = new SqlCommand(sql, cn);


                   
                    cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    

                    cmd.ExecuteNonQuery(); //Executar sem consulta

                    MessageBox.Show("Usuário cadastrado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveInDataBase();
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtNome.Focus();

        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtNome.Focus();
        }
    }
}
