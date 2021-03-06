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
        void UpdateBill(Bill bill);
        void UpdateBillPayment(Bill bill);
        List<BillDto> GetAllBillsWithFlatsAndUsers();
        void DeleteBill(Bill bill);
    }
}
