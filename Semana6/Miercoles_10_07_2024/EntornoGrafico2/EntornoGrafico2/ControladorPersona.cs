using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntornoGrafico2
{
    public class ControladorPersona
    {
        private List<Persona> listPersonas;

        public ControladorPersona()
        {
            listPersonas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            listPersonas.Add(persona);
        }

        public List<Persona> ObtenerPersonas()
        {
            return listPersonas;
        }

        public void EliminarPersona(Persona persona)
        {
            listPersonas.Remove(persona);
        }
    }
}
