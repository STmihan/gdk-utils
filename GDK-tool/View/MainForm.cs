using System.Diagnostics;

namespace GDK_tool.View;

public partial class MainForm : Form
{
    private readonly Commander _commander;


    public MainForm()
    {
        InitializeComponent();

        _commander = new Commander();

        currentSandboxLable.Text = _commander.GetCurrentSandbox();
    }

    private void GetCurrentSandboxButton_Click(object sender, EventArgs e)
    {
        string output = _commander.GetCurrentSandbox();
        Process process = _commander.Start("XblPCSandbox /get");
        output = process.StandardOutput.ReadToEnd();
        output = _commander.DeleteLabel(output);
        currentSandboxLable.Text = output;
        log.AppendText("Current sandbox is " + output + "\r\n");
    }

    private void ChangeSandboxButton_Click(object sender, EventArgs e)
    {
        string output = _commander.ChangeSandbox(changeSandboxTextBox.Text);
        log.AppendText(output + "\r\n");
        output = _commander.GetCurrentSandbox();
        log.AppendText(output + "\r\n");
        currentSandboxLable.Text = output;
    }

    private void installPackageButton_Click(object sender, EventArgs e)
    {
        string filePath = filePathTextBox.Text;
        if (string.IsNullOrEmpty(filePath))
        {
            log.AppendText("Choose package to install!\r\n");
            return;
        }

        if (!File.Exists(filePath)) log.AppendText("File not exist");

        Process process = _commander.Start($"wdapp.exe install {filePath} & exit");


        process.BeginOutputReadLine();
        log.AppendText("\r\n");

        process.OutputDataReceived += (o, args) =>
        {
            if (args.Data != null) AppendText(args.Data);
        };
    }

    private void OpenFileDialogButton_Click(object sender, EventArgs e)
    {
        openFileDialog.ShowDialog();
    }

    private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        filePathTextBox.Text = openFileDialog.FileName;
    }

    private void AppendText(string text)
    {
        if (log.InvokeRequired)
        {
            log.Invoke(new Action<string>(AppendText), text + "\r\n");
            return;
        }

        this.log.AppendText(text + "\r\n");
    }
}