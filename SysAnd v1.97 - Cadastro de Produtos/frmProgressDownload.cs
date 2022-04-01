using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd_v1._97___Cadastro_de_Produtos
{
    public partial class frmProgressDownload : Form
    {
        public frmProgressDownload()
        {
            InitializeComponent();
        }
        
        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputparameter;

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.Delay = 100;
                _inputparameter.Process = 1200;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }
        }

        

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            lblProgress.Text = String.Format("Processando...{0}%", e.ProgressPercentage);
            progress.Update();


        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Concluído !");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);

                        // Adicione o código aqui...

                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }
    }
    }

