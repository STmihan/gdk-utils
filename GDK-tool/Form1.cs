using System.Diagnostics;

namespace GDK_tool
{
    public partial class Form1 : Form
    {
        private readonly Commander _commander;
        delegate void SetTextCallback(string text);


        public Form1()
        {
            InitializeComponent();

            _commander = new Commander();
            currentSandboxLable.Text = _commander.GetCurrentSandbox();
        }


        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (log.InvokeRequired)
            {
                SetTextCallback d = SetText;
                Invoke(d, text + "\r\n");
            }
            else
            {
                log.AppendText(text + "\r\n");
            }
        }

        private void ChangeSandboxButton_Click(object sender, EventArgs e)
        {
            string output = _commander.ChangeSandbox(changeSandboxTextBox.Text);
            log.AppendText(output + "\r\n");
            output = _commander.GetCurrentSandbox();
            log.AppendText(output + "\r\n");
            currentSandboxLable.Text = output;
        }

        private void GetCurrentSandboxButton_Click(object sender, EventArgs e)
        {
            string output = _commander.GetCurrentSandbox();
            currentSandboxLable.Text = output;
            log.AppendText("Current sandbox is " + output + "\r\n");
        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            filePathTextBox.Text = openFileDialog.FileName;
        }

        private void installPackageButton_Click(object sender, EventArgs e)
        {
            string filePath = filePathTextBox.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                log.AppendText("Choose package to install!\r\n");
                return;
            }
            Process process = Process.Start(new ProcessStartInfo()
            {
                FileName = _commander.CmdExe,
                Arguments = _commander.BaseArgument + $"wdapp.exe install {filePath} & exit",
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false,
            })!;
            process.BeginOutputReadLine();
            log.AppendText("\r\n");
            process.OutputDataReceived += (o, args) =>
            {
                if (args.Data != null) SetText(args.Data);
            };

        }
    }
}