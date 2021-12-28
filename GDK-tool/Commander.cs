using System.Diagnostics;

namespace GDK_tool;

public class Commander
{
    public readonly string BaseArgument =
        @"/k ""C:\Program Files (x86)\Microsoft GDK\Command Prompts\GamingDesktopVars.cmd"" GamingDesktopVS2019 & ";

    public readonly string CmdExe = @"C:\Windows\system32\cmd.exe";

    public string StartConsole(string command)
    {
        Process process = Process.Start(new ProcessStartInfo()
        {
            FileName = CmdExe,
            Arguments = BaseArgument + command + " & exit",
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            UseShellExecute = false,
            
        })!;
        string fullText = process.StandardOutput.ReadToEnd();
        string[] split = fullText.Split("\r\n");
        List<string> consoleLines = new List<string>(split.Length - 3);
        for (int i = 1; i < split.Length - 1; i++)
        {
            consoleLines.Add(split[i]);
        }

        string consoleOutput = string.Concat(consoleLines);

        return consoleOutput;
    }

    public string GetCurrentSandbox()
    {
        return StartConsole("XblPCSandbox /get");
    }

    public string ChangeSandbox(string sandbox)
    {
        string output = "Changing sandbox...\n";
        output += StartConsole("XblPCSandbox " + sandbox);
        if (GetCurrentSandbox().Contains(sandbox))
            output += "\r\nDone!\r\n";
        else 
            output += "\r\nFail!\r\n";

        output += $"Current sandbox is {GetCurrentSandbox()}\r\n";

        return output;
    }
}