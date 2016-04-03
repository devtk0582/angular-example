using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularExample.Models.Repository
{
    public interface IZipCodeRepository
    {
        ZipCode CreateZipCode(ZipCode zipCodeToCreate);
        void DeleteZipCode(int id);
        ZipCode UpdateZipCode(int id, ZipCode zipCodeToUpdate);
        ZipCode GetZipCodeById(int id);
        IEnumerable<ZipCode> GetZipCodes();
    }
}
