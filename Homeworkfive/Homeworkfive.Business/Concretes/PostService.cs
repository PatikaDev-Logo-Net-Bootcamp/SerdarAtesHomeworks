using Homeworkfive.Business.Abstracts;
using Homeworkfive.DataAccess.EntityFramework.Repository.Abstracts;
using Homeworkfive.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfive.Business.Concretes
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> repository;
        private readonly IUnitOfWork unitOfWork;





        public PostService(
         IRepository<Post> repository,
         IUnitOfWork unitOfWork
         )
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            
        }
        public void AddPost(Post post)
        {
            repository.Add(post);
            unitOfWork.Commit();
        }

        public List<Post> GetAllPost()
        {
           return repository.Get().ToList();
        }
    }
}
