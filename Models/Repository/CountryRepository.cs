using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularExample.Models.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private AngularExampleDBEntities entites;

        public CountryRepository()
        {
            entites = new AngularExampleDBEntities();
        }

        public Country CreateCountry(Country countryToCreate)
        {
            entites.Countries.Add(countryToCreate);
            entites.SaveChanges();
            return countryToCreate;
        }

        public void DeleteCountry(int id)
        {
            var originalCountry = GetCountryById(id);
            originalCountry.Active = false;
            entites.SaveChanges();
        }

        public Country UpdateCountry(int id, Country countryToUpdate)
        {
            var originalCountry = GetCountryById(id);
            originalCountry.CountryCode = countryToUpdate.CountryCode;
            originalCountry.CountryName = countryToUpdate.CountryName;
            originalCountry.ISO3Code = countryToUpdate.ISO3Code;
            entites.SaveChanges();
            return originalCountry;
        }

        public Country GetCountryById(int id)
        {
            return entites.Countries.Where(country => country.CountryID == id).FirstOrDefault();
        }

        public IEnumerable<Country> GetCountries()
        {
            return entites.Countries.ToList();
        }
    }
}