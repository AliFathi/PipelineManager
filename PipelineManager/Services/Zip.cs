namespace PipelineManager
{
    public static class Zip
    {
        public static string Extract(string source, string destination)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(
                    source,
                    destination,
                    System.Text.Encoding.UTF8,
                    overwriteFiles: true
                );

                return null;
            }
            catch (System.Exception ex)
            {
                return ex.ToString();
            }
        }

        public static ProccessResult ExtractPS()
        {
            try
            {
                return PowerShell.InvokeFile(@"scripts\extract-zip-archives.ps1");
            }
            catch (System.Exception ex)
            {
                return new ProccessResult(ex);
            }
        }
    }
}

