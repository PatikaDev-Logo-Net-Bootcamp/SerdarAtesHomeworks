using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Abstracts
{
    public interface IBillTypeService
    {
        List<BillType> GetAllBillType();
        void AddBillType(BillType billType);
        void UpdateBillType(BillType billType);

        void DeleteBillType(BillType billType);
    }
}
