using Memory;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Packaging;

namespace BrotatoTrainer
{
    public partial class MainWindow : Form
    {
        private readonly Mem mem = new();
        private int processId;
        private readonly string baseAddress = "Brotato.exe+025362D0";
        private bool isGameOpen = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void ChangeMoneyButton_Click(object sender, EventArgs e)
        {
            string address = $"{baseAddress},148,108,38,58,20,200";
            string targetMoney = moneyInput.Text;
            WriteMem(address, "int", targetMoney);
        }

        private void WriteMem(string address, string type, string value)
        {
            if (!isGameOpen)
            {
                return;
            }
            if (int.TryParse(value, out _))
            {
                mem.WriteMemory(address, type, value);
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            processId = mem.GetProcIdFromName("Brotato");
            if (processId != 0)
            {
                if (mem.OpenProcess(processId))
                {
                    isGameOpen = true;
                    processStatus.Invoke(new MethodInvoker(delegate
                    {
                        processStatus.Text = "Game is running";
                    }));
                }
                else
                {
                    isGameOpen = false;
                    processStatus.Invoke(new MethodInvoker(delegate
                    {
                        processStatus.Text = "ProcessId error";
                    }));
                }
            }
            else
            {
                isGameOpen = false;
                processStatus.Invoke(new MethodInvoker(delegate
                {
                    processStatus.Text = "Game is not running";
                }));
            }
            Thread.Sleep(2000);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }
    }
}
