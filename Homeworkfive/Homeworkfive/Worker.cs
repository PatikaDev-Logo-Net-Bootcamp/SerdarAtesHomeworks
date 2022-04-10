using Homeworkfive.Business.Abstracts;

using Homeworkfive.Domain.Entities;

using Microsoft.Extensions.Hosting;

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Homeworkfive
{
    public class Worker : BackgroundService
    {

        private HttpClient httpClient;
        private readonly Lazy<IPostService> _postService;


        public Worker(Lazy<IPostService> postService)
        {
            _postService = postService;
          



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
                            

                    var posts = await httpClient.GetFromJsonAsync<Post[]>("posts");
                    foreach (var post in posts)
                    _postService.Value.AddPost(new Post
                    {
                        postid = post.id,
                        body = post.body,
                        userId = post.userId,
                        title = post.title,
                    });


            }
            await Task.Delay(5000, stoppingToken);
        }
        }
    }

