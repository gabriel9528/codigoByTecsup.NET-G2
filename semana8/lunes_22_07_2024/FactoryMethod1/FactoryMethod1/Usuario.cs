using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod1
{
    public class Usuario
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        private Usuario(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = country;
        }

        public class UsuarioFactory
        {
            public static Usuario CreateWithDefaultCountry(string name, string email)
            {
                return new Usuario(name, email, "Peru");
            }
            public static Usuario CreateWithDefaultEmail(string name, string country)
            {
                return new Usuario(name, "gabriel@gmail.com", country);
            }
        }

    }
}
