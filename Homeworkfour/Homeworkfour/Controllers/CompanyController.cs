using Homeworkfour.Business.Abstract;
using Homeworkfour.Business.DTOs;
using Homeworkfour.Domain.Entities;
using Homeworkfour.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Homeworkfour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [Route("Compaines")]
        [HttpGet]
        public IActionResult Get()
        {
            var companies = companyService.GetAllCompany().Select(x => new CompanyDTO
            {
                Name = x.Name,
                Address = x.Address,
                City = x.City,
                Country = x.Country,
                Description = x.Description,
                Location = x.Location,
                Phone = x.Phone
            });
            return Ok(new CompanyResponse { Data = companies, Success = true });
        }
        [Route("AddCompany")]
        [HttpPost]
        public IActionResult Post([FromBody] CompanyDTO model)
        {
            companyService.AddCompany(new Company
            {
                Address = model.Address,
                City = model.City,
                Description = model.Description,
                CreatedBy = "SAMET",
                CreatedAt = System.DateTime.Now,
                IsDeleted = false,
                Name = model.Name.ToUpper(),
                Country = model.Country,
                Phone = model.Phone,
                Location = model.Location,
            });
            return Ok(
                new CompanyResponse
                {
                    Data = "İşleminiz Başarıyla Tamamlandı",
                    Success = true
                });
        }
        [Route("DeleteCompany")]
        [HttpPost]
        public IActionResult Delete([FromBody] CompanyDeleteUpdateDTO model)
        {
            companyService.DeleteCompany(new Company
            {
                Id = model.id,
                Name=model.name,
                CreatedBy = "serdar",
                CreatedAt = System.DateTime.Now
            }); ;

            return Ok(
                new CompanyResponse
                {
                    Data = "İşleminiz Başarıyla Tamamlandı",
                    Success = true
                });
        }

        [Route("UpdateCompany")]
        [HttpPost]
        public IActionResult Update([FromBody] Company model)
        {
            companyService.UpdateCompany(model);

            return Ok(
                new CompanyResponse
                {
                    Data = "İşleminiz Başarıyla Tamamlandı",
                    Success = true
                });
        }
    }
}
