using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Abstracts
{
    public interface IBillService
    {
        List<Bill> GetAllBill();
        void AddBill(Bill bill);
        void AddBillMultiple(Bill bill);
        void UpdateBill(Bill bill);
        List<BillDto> GetAllBillsWithFlatsAndUsers();
        List<BillDto> GetAllPaidBillsWithFlatsAndUsers();
        List<BillDto> GetAllNotPaidActiveBillsWithFlatsAndUsers();
        List<BillDto> GetAllUsersPaidBillsWithFlatsAndUsers(int id);
        List<BillDto> GetAllUsersNotPaidActiveBillsWithFlatsAndUsers(int id);
        void DeleteBill(Bill bill);
    }
}
