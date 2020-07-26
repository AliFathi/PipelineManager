using System.Diagnostics;

namespace PipelineManager
{
    public static class Proccess
    {
        public static ProccessResult InvokeProccess(string path, string arguments)
        {
            using (var p = CreateProcess(path, arguments))
            {
                p.Start();
                var outputReader = p.StandardOutput;
                var errorReader = p.StandardError;
                p.WaitForExit();

                return new ProccessResult
                {
                    Output = outputReader.ReadToEnd(),
                    Error = errorReader.ReadToEnd(),
                };
            }
        }

        private static Process CreateProcess(string path, string arguments)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo(path, arguments)
                {
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                }
            };
        }
    }

    public class ProccessResult
    {
        public ProccessResult()
        {
        }

        public ProccessResult(System.Exception ex)
        {
            Error = ex.ToString();
        }

        public string Output { get; set; }

        public string Error { get; set; }

        public bool Ok => string.IsNullOrWhiteSpace(Error);
    }
}
