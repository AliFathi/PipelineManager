namespace PipelineManager
{
    public static class PowerShell
    {
        private const string _PSPATH = "powershell";
        //private const string _PSPATH = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";

        public static ProccessResult InvokeFile(string path)
        {
            var args = $"-executionpolicy bypass \"& '{path}'\"";
            return InvokeProccess(args);
        }

        public static ProccessResult InvokeScript(string script)
        {
            var args = $"\"{script}\"";
            return InvokeProccess(args);
        }

        #region Helpers

        private static ProccessResult InvokeProccess(string arguments)
        {
            return Proccess.InvokeProccess(_PSPATH, arguments);
        }

        #endregion
    }
}
