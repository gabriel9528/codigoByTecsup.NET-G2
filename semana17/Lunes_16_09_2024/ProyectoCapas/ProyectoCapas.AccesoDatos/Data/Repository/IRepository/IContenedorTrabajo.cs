using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo
    {
        ICategoriaRepository ICategoriaRepository { get; }
        IArticuloRepository IArticuloRepository { get; }
        void Save();
    }
}
