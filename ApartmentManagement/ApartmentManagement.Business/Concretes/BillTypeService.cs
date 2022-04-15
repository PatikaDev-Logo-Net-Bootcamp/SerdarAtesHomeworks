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
    public class BillTypeService : IBillTypeService
    {
        private readonly IRepository<BillType> repository;
        private readonly IUnitOfWork unitOfWork;

        public BillTypeService(IRepository<BillType> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddBillType(BillType billType)
        {
            repository.Add(billType);
            unitOfWork.Commit();
        }

        public void DeleteBillType(BillType billType)
        {
            repository.Delete(billType);
            unitOfWork.Commit();
        }

        public List<BillType> GetAllBillType()
        {
            return repository.Get().ToList();
        }

        public void UpdateBillType(BillType billType)
        {
            try
            {
                if (billType == null)
                {
                    throw new ArgumentNullException();
                }
                repository.Update(billType);
                unitOfWork.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
