
using Homeworkfive.Business.Abstracts;
using Homeworkfive.Business.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace Homeworkfive
{
    public class Program
    {
   
    public static void Main(string[] args)
        {
 
            CreateHostBuilder(args).Build().Run();

        }
  
        public static IHostBuilder CreateHostBuilder(string[] args) =>

            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {

     
                    services.AddHostedService<Worker>();
                  

                })
               .UseDefaultServiceProvider((env, c) =>
               {
                   if (env.HostingEnvironment.IsDevelopment())
                   {
                    
                       c.ValidateScopes = true;
                   }
               })
            ;
    }
}
