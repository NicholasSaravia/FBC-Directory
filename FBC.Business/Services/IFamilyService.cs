using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FBC.Business.Models;

namespace FBC.Business.Services
{
    public interface IFamilyService
    {
        Task<IEnumerable<Family>> GetALLFamilies();
        Task<Family> GetFamily(int id);
        Task UpdateFamily(Family family);
        Task UpdateContactInfo(ContactInfo contactInfo);
    }
}
