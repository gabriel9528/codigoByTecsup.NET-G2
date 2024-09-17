﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository.IRepository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        void Update(Categoria categoria);
        IEnumerable<SelectListItem> GetListCategorias();
    }
}
