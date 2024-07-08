using Mernis.Abstracts;
using Mernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mernis.Concretes
{
    public class SturbucksCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public SturbucksCustomerManager (IPersonCheckService personCheckService)
        {
            this._personCheckService = personCheckService;  
        }
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckedIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person ");
            }
        }

        private void CheckedIfRealPerson()
        {
            
        }
    }
}
