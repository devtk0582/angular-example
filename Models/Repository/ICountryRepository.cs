using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularExample.Models.Repository
{
    public interface ICountryRepository
    {
        Country CreateCountry(Country countryToCreate);
        void DeleteCountry(int id);
        Country UpdateCountry(int id, Country countryToUpdate);
        Country GetCountryById(int id);
        IEnumerable<Country> GetCountries();
    }
}
