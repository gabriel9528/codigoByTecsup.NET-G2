using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository.IRepository
{
    //IDisposable: Interfaz que proporciona un mecanismo para liberar recursos no administrados.
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository ICategoriaRepository { get; }
        IArticuloRepository IArticuloRepository { get; }
        ISliderRepository ISliderRepository { get; }
        IUsuarioRepository IUsuarioRepository { get; }

        void Save();
    }
}
