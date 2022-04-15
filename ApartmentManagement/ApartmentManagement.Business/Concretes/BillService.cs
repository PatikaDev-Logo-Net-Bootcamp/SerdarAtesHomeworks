using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Business.DTOs;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public void AddBillMultiple(Bill bill)
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
            try
            {
                if (bill == null)
                {
                    throw new ArgumentNullException();
                }
                repository.Update(bill);
                unitOfWork.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<BillDto> GetAllBillsWithFlatsAndUsers()
        {
            var AllBills = repository.Get().Include(x => x.BillType).Include(x => x.Flat).ThenInclude(x => x.Owner).OrderBy(x => x.BillDate).ToList();
            var Bills = AllBills.Select(x => new BillDto()
            {
                Id = x.Id,
                IsActive = x.IsActive,
                Price = x.Price,
                BillDate=x.BillDate,
                BillTypeName=x.BillType.BillTypeName,
                FlatNumber = x.Flat.FlatNo,
                FullName = x.Flat.Owner.FirstName+" "+x.Flat.Owner.LastName,
             
            }).ToList();
            return Bills;
        }
        public List<BillDto> GetAllPaidBillsWithFlatsAndUsers()
        {
            var PayedBills = GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive = true).ToList();
            return PayedBills;
        }
        public List<BillDto> GetAllNotPaidActiveBillsWithFlatsAndUsers()
        {
            var NotPayed = GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive = false).ToList();
            return NotPayed;
        }
        public List<BillDto> GetAllUsersPaidBillsWithFlatsAndUsers(int id)
        {
            var PayedBills = repository.Get().Include(x => x.BillType).Include(x => x.Flat).ThenInclude(x => x.Owner).Where(x=>x.Flat.Id==id&&x.IsActive==true).ToList();
            var Bills = PayedBills.Select(x => new BillDto()
            {
                Id = x.Id,
                IsActive = x.IsActive,
                Price = x.Price,
                BillDate = x.BillDate,
                BillTypeName = x.BillType.BillTypeName,
                FlatNumber = x.Flat.FlatNo,
                FullName = x.Flat.Owner.FirstName + " " + x.Flat.Owner.LastName,

            }).ToList();
            return Bills;
        }
        public List<BillDto> GetAllUsersNotPaidActiveBillsWithFlatsAndUsers(int id)
        {
            var NotPayedBills = repository.Get().Include(x => x.BillType).Include(x => x.Flat).ThenInclude(x => x.Owner).Where(x => x.Flat.Id == id && x.IsActive == false).ToList();
            var Bills = NotPayedBills.Select(x => new BillDto()
            {
                Id = x.Id,
                IsActive = x.IsActive,
                Price = x.Price,
                BillDate = x.BillDate,
                BillTypeName = x.BillType.BillTypeName,
                FlatNumber = x.Flat.FlatNo,
                FullName = x.Flat.Owner.FirstName + " " + x.Flat.Owner.LastName,

            }).ToList();
            return Bills;
        }

     
    }
}
