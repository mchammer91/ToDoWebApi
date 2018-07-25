using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace ToDoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
