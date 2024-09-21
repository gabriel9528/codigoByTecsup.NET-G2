using ProyectoCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository.IRepository
{
    public interface IUsuarioRepository : IRepository<ApplicationUser>
    {
        void BloquearUsuario(string userId);
        void DesbloquearUsuario(string userId);
    }
}
