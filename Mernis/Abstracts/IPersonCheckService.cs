using Mernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mernis.Abstracts
{
    public interface IPersonCheckService
    {
        Boolean CheckedIfRealPerson(Customer customer);
    }
}
