using Homeworkfive.Business.Abstracts;
using Homeworkfive.Business.Concretes;
using Homeworkfive.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Homeworkfive
{
    public class Worker : BackgroundService
    {
        private readonly IServiceScopeFactory serviceFactory;
        private readonly ILogger<Worker> _logger;
        private HttpClient httpClient;


        public Worker(ILogger<Worker> logger,IServiceScopeFactory serviceFactory)
        {
            this.serviceFactory = serviceFactory;
            _logger = logger;

        
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            httpClient = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            httpClient.Dispose();
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)

        {
            
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/");
            while (!stoppingToken.IsCancellationRequested)
            {
                using (IServiceScope scope = serviceFactory.CreateScope())
                {
                   var store = scope.ServiceProvider.GetRequiredService<IPostService>();
              

                    var posts = await httpClient.GetFromJsonAsync<Post[]>("posts");
                    foreach (var post in posts)
                        
                        store.AddPost(new Post
                        {
                            postid = post.id,
                            body = post.body,
                            userId = post.userId,
                            title = post.title,
                        });
                }

            }
            await Task.Delay(5000, stoppingToken);
        }
        }
    }

