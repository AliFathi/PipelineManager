namespace PipelineManager
{
    public static class IIS
    {
        public static ProccessResult StopSites()
        {
            try
            {
                return PowerShell.InvokeFile(@"scripts\iis-stop-websites.ps1");
            }
            catch (System.Exception ex)
            {
                return new ProccessResult(ex);
            }
        }

        public static ProccessResult StartSites()
        {
            try
            {
                return PowerShell.InvokeFile(@"scripts\iis-start-websites.ps1");
            }
            catch (System.Exception ex)
            {
                return new ProccessResult(ex);
            }
        }

        public static ProccessResult AddAppOffline()
        {
            try
            {
                return PowerShell.InvokeFile(@"scripts\add-app-offline.ps1");
            }
            catch (System.Exception ex)
            {
                return new ProccessResult(ex);
            }
        }

        public static ProccessResult RemoveAppOffline()
        {
            try
            {
                return PowerShell.InvokeFile(@"scripts\remove-app-offline.ps1");
            }
            catch (System.Exception ex)
            {
                return new ProccessResult(ex);
            }
        }
    }
}
