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
    public partial class frmBancoDeDados : Form
    {
        public frmBancoDeDados()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        private void loadDataBase()
        {
            try
            {

                cn.Open();


                cmd.CommandText = "select * from Fix_ManutencaoNew";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adp.SelectCommand = cmd;
                adp.Fill(dt);

                dgvDataBase.DataSource = dt;
                dgvDataBase.Columns[0].HeaderText = "ID";
                dgvDataBase.Columns[1].HeaderText = "Entrada";
                dgvDataBase.Columns[2].HeaderText = "OS";
                dgvDataBase.Columns[3].HeaderText = "Patrimônio";
                dgvDataBase.Columns[4].HeaderText = "Modelo";
                dgvDataBase.Columns[5].HeaderText = "Cor";
                dgvDataBase.Columns[6].HeaderText = "Defeito";
                dgvDataBase.Columns[7].HeaderText = "Reparo";
                dgvDataBase.Columns[8].HeaderText = "Status";
                dgvDataBase.Columns[9].HeaderText = "Obs.";
                dgvDataBase.Columns[10].HeaderText = "Saida";
                dgvDataBase.Columns[11].HeaderText = "Laudo";
                dgvDataBase.Columns[12].HeaderText = "Garantia";
                dgvDataBase.Columns[13].HeaderText = "Ultima Atualização";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            finally
            {
                cn.Close();
            }
        }
        private void frmBancoDeDados_Load(object sender, EventArgs e)
        {
            loadDataBase();
           
            cbFiltro.Sorted = true;
            
            loadNumbers();
        }

        private void tableFilter()
        {
            cn.Open();


            try
            {

                string status = cbFiltro.Text;


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Fix_ManutencaoNew where status_tb like ('" + cbFiltro.Text + "')";
                cmd.Connection = cn;


                SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                adp.Fill(dt); //preenchendo o DataTable

                dgvDataBase.DataSource = dt; //Tabela que será preenchida

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            cn.Close();
        }

        private void loadNumbers()
        {
            cn.Open();
            

            try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select status_tb as Status, count(id) as Total from Fix_ManutencaoNew where status_tb != '' group by status_tb";
                    cmd.Connection = cn;

                    

                    SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvContagem.DataSource = dt; //Tabela que será preenchida

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
            cn.Close();
        }
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        private void openToExcel()
        {
            if (dgvDataBase.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgvDataBase.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvDataBase.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgvDataBase.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvDataBase.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvDataBase.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    XcelApp.Quit();
                }
            }
            /*MessageBox.Show("Carregamento completo !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
        }

        private void cbFiltro_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void cbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "")
            {
                btnExcel.Enabled = false;
            }
            else
            {
                btnExcel.Enabled = true;
            }
            tableFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openToExcel();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                btnExcel.Enabled = true;
            

        }
    } }
