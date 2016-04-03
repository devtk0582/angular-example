using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularExample.Models.Repository
{
    public interface ICityRepository
    {
        City CreateCity(City cityToCreate);
        void DeleteCity(int id);
        City UpdateCity(int id, City cityToUpdate);
        City GetCityById(int id);
        IEnumerable<City> GetCities();
    }
}
