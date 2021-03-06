using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PipelineManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(b => b.UseStartup<Startup>())
                .Build()
                .Run();
        }
    }
}
