using Mernis.Abstracts;
using Mernis.Adapters;
using Mernis.Concretes;
using Mernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mernis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new SturbucksCustomerManager(new MernisServieAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001,11,11) , FirstName="Mehmet" , LastName="Zengin" , NationalityIdenty="00000000000"});
            Console.ReadLine();
        }
    }
}
