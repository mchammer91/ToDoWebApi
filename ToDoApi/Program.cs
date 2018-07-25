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
            var document = SwaggerDocument.FromJsonAsync("...");

            var settings = new SwaggerToCSharpClientGeneratorSettings
            {
                ClassName = "MyClass",
                CSharpGeneratorSettings =
    {
        Namespace = "MyNamespace"
    }
            };

            var generator = new SwaggerToCSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
