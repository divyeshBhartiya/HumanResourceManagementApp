using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Shared;

namespace HRM.Api.Repositories
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
