using Homeworkfour.Business.Abstract;
using Homeworkfour.DataAccess.EntityFramework.Repository.Abstracts;
using Homeworkfour.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Homeworkfour.Business.Concretes
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> repository;
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(IRepository<Company> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddCompany(Company company)
        {
            repository.Add(company);
            unitOfWork.Commit();
        }

        public List<Company> GetAllCompany()
        {
            return repository.Get().ToList();
        }
        public void DeleteCompany(Company company)
        {
        
                repository.Update(company);
                unitOfWork.Commit();
        }
        public void UpdateCompany(Company company)
        {
        
                repository.Update(company);
                unitOfWork.Commit();
      
        }







    }
}
