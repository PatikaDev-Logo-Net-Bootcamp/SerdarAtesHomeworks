using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Business.DTOs;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        public List<FlatDto> GetFlatsWithUsersAndBlocks()
        {
            
            var AllFlats = repository.Get().Include(x=>x.Owner).Include(x=>x.Blocks).OrderBy(x=>x.Blocks.BlockName).ToList();
            var flats = AllFlats.Select(x => new FlatDto()
            {
                Id = x.Id,
                BlockName=x.Blocks.BlockName,
                FlatType=x.Type,
                Floor=x.Floor,
                FlatNumber=x.FlatNo,
                FullName=x.Owner.FirstName +" "+ x.Owner.LastName,
                IsEmpty=x.IsEmpty,
            }).ToList();
            return flats;

        }
    }
}
