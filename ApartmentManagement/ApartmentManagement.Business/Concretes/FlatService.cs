using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Concretes
{
    public class FlatService : IFlatService
    {
        private readonly IRepository<Flats> repository;
        private readonly IUnitOfWork unitOfWork;

        public FlatService(IRepository<Flats> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public void AddFlats(Flats flat)
        {
            repository.Add(flat);
            unitOfWork.Commit();
        }

        public void DeleteFlats(Flats flat)
        {
            repository.Delete(flat);
            unitOfWork.Commit();
        }

        public List<Flats> GetAllFlats()
        {
            return repository.Get().ToList();
        }

        public void UpdateFlats(Flats flat)
        {
            repository.Update(flat);
            unitOfWork.Commit();
        }
    }
}
