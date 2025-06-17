// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************


using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TickTack;

public static partial class EditingExtensions
{
    public static bool EditUsingEnvironmentVar(this string filePath, string variableName = "EDITOR") {
        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath)) {
            MessageBox.Show($"History file '{filePath}' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        string? env_var = Environment.GetEnvironmentVariable(variableName);
        if (env_var is null) {
            MessageBox.Show($"Environment variable '{variableName}' not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        int split = env_var.IndexOf(' ');
        string exe_path = split > 0 ? env_var[..split] : env_var;
        if (!exe_path.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            exe_path += ".exe";
        exe_path = NonWindowsPathStartRegex().Replace(exe_path, @"$1:\\").Replace('/', '\\');
        string args = split > 0 ? env_var[(split + 1)..] : string.Empty;
        if (!File.Exists(exe_path)) {
            MessageBox.Show($"Executable {exe_path} does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        Process.Start(new ProcessStartInfo() {
            UseShellExecute = false,
            Arguments = $"{args} {filePath}",
            FileName = exe_path
        })?.WaitForExit();
        return true;
    }

    [GeneratedRegex(@"^/(w)/")]
    private static partial Regex NonWindowsPathStartRegex();
}
