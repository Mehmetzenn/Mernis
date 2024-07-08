using Mernis.Abstracts;
using Mernis.Entities;
using Mernis.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mernis.Adapters
{
    public class MernisServieAdapter : IPersonCheckService
    {
        public bool CheckedIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient ksp = new KPSPublicSoapClient();
            return ksp.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityIdenty),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
