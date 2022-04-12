using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Concretes
{
    public class BlockService : IBlockService
    {
        private readonly IRepository<Block> repository;
        private readonly IUnitOfWork unitOfWork;

        public BlockService(IRepository<Block> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }


        public void AddBlock(Block block)
        {
            repository.Add(block);
            unitOfWork.Commit();
        }

        public void DeleteBlock(Block block)
        {
            repository.Delete(block);
            unitOfWork.Commit();
        }

        public List<Block> GetAllBlock()
        {
            return repository.Get().ToList();
        }
        public void UpdateBlock(Block block)
        {
            try
            {
                if (block == null)
                {
                    throw new ArgumentNullException();
                }
                repository.Update(block);
                unitOfWork.Commit();
        
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
