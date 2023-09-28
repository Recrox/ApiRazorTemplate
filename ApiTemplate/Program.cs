using System.Reflection;

namespace Site;
public class Program
{
    public static void Main(string[] args)
    {
        //var test = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}