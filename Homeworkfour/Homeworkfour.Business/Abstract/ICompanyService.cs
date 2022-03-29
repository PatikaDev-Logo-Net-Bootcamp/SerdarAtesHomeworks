
using Homeworkfour.Domain.Entities;

using System.Collections.Generic;


namespace Homeworkfour.Business.Abstract
{
    public interface ICompanyService
    {

        List<Company> GetAllCompany();
        void AddCompany(Company company);
        void UpdateCompany(Company company);

        void DeleteCompany(Company company);

    }
}
