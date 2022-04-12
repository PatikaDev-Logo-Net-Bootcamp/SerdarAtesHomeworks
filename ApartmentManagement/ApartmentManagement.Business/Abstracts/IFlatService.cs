using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Abstracts
{
    public interface IFlatService
    {
        List<Flats> GetAllFlats();
        void AddFlats(Flats flat);
        void UpdateFlats(Flats flat);
        List<FlatDto> GetFlatsWithUsersAndBlocks();
        void DeleteFlats(Flats flat);
    }
}
