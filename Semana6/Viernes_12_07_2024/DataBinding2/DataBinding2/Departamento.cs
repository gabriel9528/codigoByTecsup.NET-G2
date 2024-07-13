using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding2
{
    public class Departamento : List<Estudiante>
    {
        public string NombreDepartamento { get; set; }

        public Departamento(string nomreDepartamento)
        {
            NombreDepartamento = nomreDepartamento;
        }

        public List<Estudiante> ListEstudiantes
        {
            get { return this; }
        }
    }
}
