using System.Diagnostics;

namespace tpp_desktop.Utilities
{
    internal static class PythonUtilities
    {
        public static void RunScript(string path, string arguments)
        {
            // TODO: Fetch from settings
            var pythonExecutablePath = "C:\\Python27\\python.exe";

            var processStartInfo = new ProcessStartInfo
            {
                FileName = pythonExecutablePath,
                Arguments = $"{path} {arguments}",
                UseShellExecute = true,
            };

            Process.Start(processStartInfo);
        }
    }
}
