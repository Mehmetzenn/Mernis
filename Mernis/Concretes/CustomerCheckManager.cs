
using Mernis.Abstracts;
using Mernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mernis.Concretes
{
    public class CustomerCheckManager :IPersonCheckService 
    {
        public Boolean CheckedIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
