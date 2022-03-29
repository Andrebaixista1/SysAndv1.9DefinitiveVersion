using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmPlanilha : Form
    {
        public frmPlanilha()
        {
            InitializeComponent();
            
        }

        

        DataTable dtd = new DataTable();
        string arq = @"C:\Users\Administrador\Desktop\TabelaFix.csv";

        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        
        private void loadDataBase()
        {
            try
            {

                cn.Open();


                cmd.CommandText = "select * from DB_Manutencao";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adp.SelectCommand = cmd;
                adp.Fill(dt);

                dgvPlan.DataSource = dt;
                dgvPlan.Columns[0].HeaderText = "ID";
                dgvPlan.Columns[1].HeaderText = "Entrada";
                dgvPlan.Columns[2].HeaderText = "OS";
                dgvPlan.Columns[3].HeaderText = "Patrimônio";
                dgvPlan.Columns[4].HeaderText = "Modelo";
                dgvPlan.Columns[5].HeaderText = "Cor";
                dgvPlan.Columns[6].HeaderText = "Defeito";
                dgvPlan.Columns[7].HeaderText = "Reparo";
                dgvPlan.Columns[8].HeaderText = "Status";
                dgvPlan.Columns[9].HeaderText = "Obs.";
                dgvPlan.Columns[10].HeaderText = "Saida";
                dgvPlan.Columns[11].HeaderText = "Laudo";
                dgvPlan.Columns[12].HeaderText = "Garantia";
                lblStatus.Text = "Banco de Dados Conectado !";
                lblStatus.ForeColor = System.Drawing.Color.DarkGreen;


                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema no banco de dados!", "Atenção !!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                lblStatus.Text = "Erro no Banco de Dados SQL !";
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            }

        }


        private void frmPlanilha_Load(object sender, EventArgs e)
        {

            loadDataBase();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void dgvPlan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
            loadDataBase();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from DB_Manutencao where patrimonio like ('" + txtBuscar.Text + "%') or modelo like ('%" + txtBuscar.Text + "%') or status like ('" + txtBuscar.Text + "%') or os like ('" + txtBuscar.Text + "%')or reparo like ('" + txtBuscar.Text + "%') or cor like ('" + txtBuscar.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvPlan.DataSource = dt; //Tabela que será preenchida
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //dgvPesq.DataSource = null;
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from DB_Manutencao";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                adp.Fill(dt); //preenchendo o DataTable

                dgvPlan.DataSource = dt; //Tabela que será preenchida
                cn.Close();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataObject copyData = dgvPlan.GetClipboardContent();
            if (copyData != null) Clipboard.SetDataObject(copyData);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.;
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1,1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("select * from DB_Manutencao",cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvPlan.DataSource= dt;

        }
    }
}

