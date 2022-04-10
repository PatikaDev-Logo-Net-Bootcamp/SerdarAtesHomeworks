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
    public class BillService : IBillService
    {
        private readonly IRepository<Bill> repository;
        private readonly IUnitOfWork unitOfWork;

        public BillService(IRepository<Bill> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddBill(Bill bill)
        {
            repository.Add(bill);
            unitOfWork.Commit();
        }

        public void DeleteBill(Bill bill)
        {
            repository.Delete(bill);
            unitOfWork.Commit();
        }

        public List<Bill> GetAllBill()
        {
            return repository.Get().ToList();
        }

        public void UpdateBill(Bill bill)
        {
            repository.Update(bill);
            unitOfWork.Commit();
        }
    }
}
