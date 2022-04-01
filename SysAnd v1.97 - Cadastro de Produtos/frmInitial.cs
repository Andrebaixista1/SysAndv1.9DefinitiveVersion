using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmInitial : Form
    {

        public frmInitial()
        {
            InitializeComponent();

        }
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();


        private void desativarCampos()
        {
            txtData.Text = DateTime.Now.ToString();
            txtData.Enabled = false;
            txtCod.Text.ToUpper();
            rbLaudo.Select();
            txtSaida.Enabled = false;
            txtSaida.Text = "01011999";
            cbEntrada.Enabled = false;
            cbSaida.Enabled = false;

            //Limpar

            txtOS.Text = "000000";
            txtCod.Text = "";
            cbModelo.Text = "";
            cbColor.Text = "";
            txtDefeito.Text = "";
            txtReparo.Text = "";
            txtObs.Text = "";
            lblLast.Text = "";


            //Desativar
            txtOS.Enabled = false;
            txtCod.Enabled = false;
            cbModelo.Enabled = false;
            cbColor.Enabled = false;
            txtDefeito.Enabled = false;
            txtReparo.Enabled = false;
            txtObs.Enabled = false;
            gbGarantia.Enabled = false;
            gbLaudo.Enabled = false;
            rbNaoG.Select();
            rbNaoL.Select();
            gbStatus.Enabled = false;
            rbLaudo.Select();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            

        }

        private void habilitaCampos()
        {
            txtData.Text = DateTime.Now.ToString();
            txtData.Enabled = false;
            txtCod.Text.ToUpper();
            rbLaudo.Select();
            txtSaida.Enabled = false;
            txtSaida.Text = "01011999";
            cbEntrada.Enabled = true;
            cbSaida.Enabled = true;

            if (lblLast.Text != "")
            {
                lblAtualizacao.Visible = true;
            }
            else
            {
                lblAtualizacao.Visible = false;
            }

            //Ativar
            txtOS.Enabled = true; txtOS.Text = "000000";
            txtCod.Enabled = true; txtCod.Text = "";
            cbModelo.Enabled = true; cbModelo.Text = "";
            cbColor.Enabled = true; cbColor.Text = "";
            txtDefeito.Enabled = true; txtDefeito.Text = "";
            txtReparo.Enabled = true; txtReparo.Text = "";
            txtObs.Enabled = true; txtObs.Text = "";
            gbGarantia.Enabled = true;
            gbLaudo.Enabled = true;
            rbNaoG.Select();
            rbNaoL.Select();
            gbStatus.Enabled = true;
            rbLaudo.Select();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;



        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        private void saveInDataBase()
        {




            try
            {

                string patrimonio = txtCod.Text;
                string OS = txtOS.Text;
                string modelo = cbModelo.Text;
                string cor = cbColor.Text;

                string defeito = txtDefeito.Text;


                if (patrimonio == "" || OS == "" || modelo == "" || cor == "" || defeito == "" || txtSaida.Text == "")
                {
                    MessageBox.Show("Preencha os campos obrigatórios ! (Patrimonio, OS, Modelo, Cor e Defeito)", "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {


                    SqlCommand cm = new SqlCommand();
                    cn.Open();



                    cm.CommandText = "select * from Fix_ManutencaoNew";
                    cm.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cm; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    /*dgvTabela.DataSource = dt;*/ //Tabela que será preenchida
                                                   // cn.Close();

                    /*int ids = dt.Rows.Count;
                    ids += 1;



                    int id = ids;*/

                    DateTime entrada = Convert.ToDateTime(txtData.Text);


                    string reparo = txtReparo.Text;

                    string obs = txtObs.Text;

                    DateTime saida = Convert.ToDateTime(txtSaida.Text);

                    DateTime lastUp = DateTime.Now;

                    string status = string.Empty;
                    string laudo = string.Empty;
                    string garantia = string.Empty;

                    if (rbLaudo.Checked)
                    {
                        status = rbLaudo.Text;
                    }
                    else if (rbVTecnico.Checked)
                    {
                        status = rbVTecnico.Text;
                    }
                    else if (rbACompra.Checked)
                    {
                        status = rbACompra.Text;
                    }
                    else if (rbAChegada.Checked)
                    {
                        status = rbAChegada.Text;
                    }
                    else if (rbAReparo.Checked)
                    {
                        status = rbAReparo.Text;
                    }
                    else if (rbRIniciado.Checked)
                    {
                        status = rbRIniciado.Text;
                    }
                    else if (rbSucata.Checked)
                    {
                        status = rbSucata.Text;
                    }
                    else
                    {
                        status = rbConcluido.Text;
                    }


                    if (rbSimL.Checked)
                    {
                        laudo = "Sim";
                    }
                    else
                    {
                        laudo = "Não";
                    }


                    if (rbSimG.Checked)
                    {
                        garantia = "Sim";
                    }
                    else
                    {
                        garantia = "Não";
                    }




                    /*Console.WriteLine(defeito, "Deu certo !");
                    Console.WriteLine(laudo, "Deu certo !");
                    Console.WriteLine(garantia, "Deu certo !");*/




                    string sql = "insert into Fix_ManutencaoNew(entrada,os,patrimonio,modelo,cor,defeito,reparo,status_tb,obs,saida,laudo,garantia,last_update) values(@entrada,@os,@patrimonio,@modelo,@cor,@defeito,@reparo,@status,@obs,@saida,@laudo,@garantia,@lastUp)";
                    SqlCommand cmd = new SqlCommand(sql, cn);


                    cmd.Parameters.Add("@entrada", SqlDbType.DateTime).Value = entrada;
                    cmd.Parameters.Add("@patrimonio", SqlDbType.VarChar).Value = patrimonio;
                    cmd.Parameters.Add("@os", SqlDbType.VarChar).Value = OS;
                    cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                    cmd.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor;
                    cmd.Parameters.Add("@defeito", SqlDbType.Text).Value = defeito;
                    cmd.Parameters.Add("@reparo", SqlDbType.Text).Value = reparo;
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                    cmd.Parameters.Add("@obs", SqlDbType.Text).Value = obs;
                    cmd.Parameters.Add("@saida", SqlDbType.DateTime).Value = saida;
                    cmd.Parameters.Add("@laudo", SqlDbType.Text).Value = laudo;
                    cmd.Parameters.Add("@garantia", SqlDbType.Text).Value = garantia;
                    cmd.Parameters.Add("@lastUp", SqlDbType.DateTime).Value = lastUp;

                    cmd.ExecuteNonQuery(); //Executar sem consulta

                    MessageBox.Show("Aparelho cadastrado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void loadDataBase2()
        {
            try
            {

                cmd.CommandText = "select * from Fix_ManutencaoNew";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adp.SelectCommand = cmd;
                adp.Fill(dt);

                dgvTabela.DataSource = dt;
                dgvTabela.Columns[0].HeaderText = "ID";
                dgvTabela.Columns[1].HeaderText = "Entrada";
                dgvTabela.Columns[2].HeaderText = "OS";
                dgvTabela.Columns[3].HeaderText = "Patrimônio";
                dgvTabela.Columns[4].HeaderText = "Modelo";
                dgvTabela.Columns[5].HeaderText = "Cor";
                dgvTabela.Columns[6].HeaderText = "Defeito";
                dgvTabela.Columns[7].HeaderText = "Reparo";
                dgvTabela.Columns[8].HeaderText = "Status";
                dgvTabela.Columns[9].HeaderText = "Obs.";
                dgvTabela.Columns[10].HeaderText = "Saida";
                dgvTabela.Columns[11].HeaderText = "Laudo";
                dgvTabela.Columns[12].HeaderText = "Garantia";
                dgvTabela.Columns[13].HeaderText = "Ultima Atualização";



            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema no banco de dados!", "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

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

                dgvTabela.DataSource = dt;
                dgvTabela.Columns[0].HeaderText = "ID";
                dgvTabela.Columns[1].HeaderText = "Entrada";
                dgvTabela.Columns[2].HeaderText = "OS";
                dgvTabela.Columns[3].HeaderText = "Patrimônio";
                dgvTabela.Columns[4].HeaderText = "Modelo";
                dgvTabela.Columns[5].HeaderText = "Cor";
                dgvTabela.Columns[6].HeaderText = "Defeito";
                dgvTabela.Columns[7].HeaderText = "Reparo";
                dgvTabela.Columns[8].HeaderText = "Status";
                dgvTabela.Columns[9].HeaderText = "Obs.";
                dgvTabela.Columns[10].HeaderText = "Saida";
                dgvTabela.Columns[11].HeaderText = "Laudo";
                dgvTabela.Columns[12].HeaderText = "Garantia";
                dgvTabela.Columns[13].HeaderText = "Ultima Atualização";


            }

            catch (Exception ex)
            {
                MessageBox.Show("Problema no banco de dados!", "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
            finally
            {

                cn.Close();
            }

        }
        private void frmInitial_Load(object sender, EventArgs e)
        {
            desativarCampos();
            loadDataBase();
            if (lblLast.Text != "")
            {
                lblAtualizacao.Visible = true;
            }
            else
            {
                lblAtualizacao.Visible = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEntrada.Checked)
            {
                txtData.Enabled = true;
            }
            else
            {
                txtData.Enabled = false;
            }

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtOS.Text = "";
        }

        private void rbConcluido_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void rbConcluido_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (cbSaida.Checked)
            {
                txtSaida.Text = DateTime.Now.ToString();
                txtSaida.Enabled = true;
            }
            else
            {
                txtSaida.Enabled = false;
                txtSaida.Text = "01011999";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDefeito_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReparo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtOS.Enabled == false)
            {
                habilitaCampos();
            }
            else
            {
                var menssagem = MessageBox.Show("Deseja criar um novo registro? Se ja possuir dados preenchidos eles seram perdidos!", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (menssagem == DialogResult.Yes)
                {
                    habilitaCampos();
                }

            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (txtOS.Enabled == false)
            {
                desativarCampos();
            }
            else
            {
                var menssagem = MessageBox.Show("Deseja cancelar o novo registro? Se ja possuir dados preenchidos eles seram perdidos!", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (menssagem == DialogResult.Yes)
                {
                    desativarCampos();
                }

            }
        }

        private void abrirPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmail email = new frmEmail();
            email.ShowDialog();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            saveInDataBase();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtOS.Enabled == false)
            {
                habilitaCampos();
            }
            else
            {
                var menssagem = MessageBox.Show("Deseja criar um novo registro? Se ja possuir dados preenchidos eles seram perdidos!", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (menssagem == DialogResult.Yes)
                {
                    habilitaCampos();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveInDataBase();
            loadDataBase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" && cbModelo.Text == "" && cbColor.Text == "" && txtDefeito.Text == "" && txtReparo.Text == "" && txtObs.Text == "")
            {
                desativarCampos();
                btnNew.Enabled = true;
            }
            else
            {
                var menssagem = MessageBox.Show("Deseja cancelar o novo registro? Se ja possuir dados preenchidos eles seram perdidos!", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (menssagem == DialogResult.Yes)
                {
                    desativarCampos();
                    btnNew.Enabled = true;
                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                int id = Convert.ToInt32(txtID.Text);
                string patrimonio = txtCod.Text;
                string modelo = cbModelo.Text;
                string cor = cbColor.Text;
                string defeito = txtDefeito.Text;
                string reparo = txtReparo.Text;
                string OS = txtOS.Text;
                DateTime lastUp = DateTime.Now;
                // Radio Button

                string status = string.Empty;
                string laudo = string.Empty;
                string garantia = string.Empty;

                if (rbLaudo.Checked)
                {
                    status = rbLaudo.Text;
                }
                else if (rbVTecnico.Checked)
                {
                    status = rbVTecnico.Text;
                }
                else if (rbACompra.Checked)
                {
                    status = rbACompra.Text;
                }
                else if (rbAChegada.Checked)
                {
                    status = rbAChegada.Text;
                }
                else if (rbAReparo.Checked)
                {
                    status = rbAReparo.Text;
                }
                else if (rbRIniciado.Checked)
                {
                    status = rbRIniciado.Text;
                }
                else if (rbSucata.Checked)
                {
                    status = rbSucata.Text;
                }
                else
                {
                    status = rbConcluido.Text;
                }


                if (rbSimL.Checked)
                {
                    laudo = "Sim";
                }
                else
                {
                    laudo = "Não";
                }


                if (rbSimG.Checked)
                {
                    garantia = "Sim";
                }
                else
                {
                    garantia = "Não";
                }



                string obs = txtObs.Text;
                DateTime saida = Convert.ToDateTime(txtSaida.Text.ToString());


                string sql = "UPDATE Fix_ManutencaoNew set patrimonio=@patrimonio, OS=@os,modelo=@modelo, cor=@cor, defeito=@defeito, reparo=@reparo, status_tb=@status, obs=@obs, saida=@saida, laudo=@laudo, garantia=@garantia, last_update=@lastUp WHERE id=@id";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@patrimonio", SqlDbType.VarChar).Value = patrimonio;
                cmd.Parameters.Add("@os", SqlDbType.VarChar).Value = OS;
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                cmd.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor;
                cmd.Parameters.Add("@defeito", SqlDbType.Text).Value = defeito;
                cmd.Parameters.Add("@reparo", SqlDbType.Text).Value = reparo;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                cmd.Parameters.Add("@obs", SqlDbType.Text).Value = obs;
                cmd.Parameters.Add("@saida", SqlDbType.DateTime).Value = saida;
                cmd.Parameters.Add("@laudo", SqlDbType.VarChar).Value = laudo;
                cmd.Parameters.Add("@garantia", SqlDbType.VarChar).Value = garantia;
                cmd.Parameters.Add("@lastUp", SqlDbType.VarChar).Value = lastUp;





                cmd.ExecuteNonQuery(); //Executar sem consulta
                cmd.Parameters.Clear(); //Limpa os parâmetros após usado
                desativarCampos();
                loadDataBase2();
                btnNew.Enabled = true;
                cbSaida.Checked = false;
                MessageBox.Show("Aparelho alterado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja realmente excluir esse item ? (todas as informações relacionadas a ele será excluida permanentemente)", "Atenção !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                try
                {

                    cn.Open();
                    int id = Convert.ToInt32(txtID.Text);

                    string sql = "DELETE FROM Fix_ManutencaoNew WHERE id=@id";


                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;



                    cmd.ExecuteNonQuery(); //Executar sem consulta
                    cmd.Parameters.Clear(); //Limpa os parâmetros após usado
                    habilitaCampos();

                    btnNew.Enabled = true;
                    MessageBox.Show("Aparelho excluido com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataBase2();
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
            else
            {
                MessageBox.Show("Nenhum registro foi excluido fique tranquilo","Operação cancelada !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void dgvTabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            habilitaCampos();
            carregaDados();

            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancel.Enabled = true;

            txtSaida.Enabled = false;
        }

        private void carregaDados()
        {
            txtID.Text = dgvTabela.SelectedRows[0].Cells[0].Value.ToString();
            txtData.Text = dgvTabela.SelectedRows[0].Cells[1].Value.ToString();
            txtOS.Text = dgvTabela.SelectedRows[0].Cells[2].Value.ToString();
            txtCod.Text = dgvTabela.SelectedRows[0].Cells[3].Value.ToString();
            cbModelo.Text = dgvTabela.SelectedRows[0].Cells[4].Value.ToString();
            cbColor.Text = dgvTabela.SelectedRows[0].Cells[5].Value.ToString();
            txtDefeito.Text = dgvTabela.SelectedRows[0].Cells[6].Value.ToString();
            txtReparo.Text = dgvTabela.SelectedRows[0].Cells[7].Value.ToString();
            txtObs.Text = dgvTabela.SelectedRows[0].Cells[9].Value.ToString();
            lblLast.Text = dgvTabela.SelectedRows[0].Cells[13].Value.ToString();

            cbSaida.Select();
            txtSaida.Text = dgvTabela.SelectedRows[0].Cells[10].Value.ToString();


            string status = dgvTabela.SelectedRows[0].Cells[8].Value.ToString();

            if (status == "Laudo Inicial")
            {
                rbLaudo.Select();
            }
            else if (status == "Validação Técnico")
            {
                rbVTecnico.Select();
            }
            else if (status == "Aguardando Compra")
            {
                rbACompra.Select();
            }
            else if (status == "Aguardando Chegada")
            {
                rbAChegada.Select();
            }
            else if (status == "Aguardando Reparo")
            {
                rbAReparo.Select();
            }
            else if (status == "Reparo Iniciado")
            {
                rbRIniciado.Select();
            }
            else if (status == "Sucata")
            {
                rbSucata.Select();
            }
            else
            {
                rbConcluido.Select();
            }

            string laudo = dgvTabela.SelectedRows[0].Cells[11].Value.ToString();

            if (laudo == "Sim")
            {
                rbSimL.Select();
            }
            else
            {
                rbNaoL.Select();
            }

            string garantia = dgvTabela.SelectedRows[0].Cells[12].Value.ToString();

            if (garantia == "Sim")
            {
                rbSimG.Select();
            }
            else
            {
                rbNaoG.Select();
            }


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            if (txtBuscar.Text != "")
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Fix_ManutencaoNew where patrimonio like ('%" + txtBuscar.Text + "%') or modelo like ('%" + txtBuscar.Text + "%') or status_tb like ('" + txtBuscar.Text + "%') or os like ('%" + txtBuscar.Text + "%')or reparo like ('" + txtBuscar.Text + "%') or cor like ('" + txtBuscar.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvTabela.DataSource = dt; //Tabela que será preenchida

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //dgvPesq.DataSource = null;
                /*cn.Open();*/
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Fix_ManutencaoNew";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                adp.Fill(dt); //preenchendo o DataTable

                dgvTabela.DataSource = dt; //Tabela que será preenchida
                /*cn.Close();*/
            }
            cn.Close();
        }

       
        private void openToExcel()
        {
            if (dgvTabela.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgvTabela.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvTabela.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgvTabela.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvTabela.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvTabela.Rows[i].Cells[j].Value.ToString();
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

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }
        private DataParameter _inputparameter;
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblProgress.Visible = true;
            if (!backgroundWorker1.IsBusy)
            {
                _inputparameter.Delay = 100;
                _inputparameter.Process = 150;
                backgroundWorker1.RunWorkerAsync(_inputparameter);
            }
            
        }

        private void statusBar_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var msg = MessageBox.Show("Carregamento concluído !","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (msg == DialogResult.OK)
            {
                backgroundWorker1.CancelAsync();
                progressBar1.Value = 0;
                lblProgress.Visible = false;
            }
            frmInitial menu = new frmInitial();
            this.BringToFront();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = String.Format("Loading... {0}%", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);
                        
                    }
                }
                openToExcel();
            }
            catch (Exception ex)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

