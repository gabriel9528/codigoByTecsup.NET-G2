using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before
{
    public class AccountService
    {
        public Membership Create(Person person)
        {
            Membership newMembership = new Membership();
            newMembership.FirstName = person.FirstName;
            newMembership.LastName = person.LastName;

            newMembership.Id = Guid.NewGuid().ToString();

            switch (person.MembresiaType)
            {
                case MembresiaType.Basico:
                    newMembership.Email = $"{person.FirstName}.{person.LastName}@basico.com";
                    newMembership.Price = 30;
                    break;
                case MembresiaType.Gold:
                    newMembership.Email = $"{person.FirstName}.{person.LastName}@gold.com";
                    newMembership.Price = 80;
                    break;
                case MembresiaType.Platinium:
                    newMembership.Email = $"{person.FirstName}.{person.LastName}@platinium.com";
                    newMembership.Price = 300;
                    break;
            }
            newMembership.MembresiaType = person.MembresiaType;

            return newMembership;
        }
    }
}
