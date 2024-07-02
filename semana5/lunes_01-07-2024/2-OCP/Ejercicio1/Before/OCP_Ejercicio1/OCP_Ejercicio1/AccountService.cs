using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ejercicio1
{
    public class AccountService
    {
        public Staff Create(Person persona)
        {
            Staff staff = new Staff();
            staff.FirstName = persona.FirstName;
            staff.LastName = persona.LastName;
            switch (persona.Role)
            {
                case Role.Doctor:
                    staff.Email = $"{persona.FirstName}.{persona.LastName}@doctor.com";
                    break;
                case Role.Nurse:
                    staff.Email = $"{persona.FirstName}.{persona.LastName}@nurse.com";
                    break;
                case Role.None:
                    staff.Email = $"{persona.FirstName}.{persona.LastName}@staff.com";
                    break;
            }
            staff.Role = persona.Role;

            return staff;
        }

    }
}
