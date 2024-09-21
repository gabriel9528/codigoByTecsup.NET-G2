using Microsoft.EntityFrameworkCore;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly DbContext dbContext;
        internal DbSet<T> dbSet;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string? includeProperties = null)
        {
            //Se crea una consulta IQueryable a partir del DbSet del contexto
            IQueryable<T> query = dbSet;

            if(filter != null)
            {
                query = query.Where(filter);
            }

            //Se hace la relacion entre entidades, se incluyen propiedades de navegacion si se proporcionan
            if(includeProperties != null)
            {
                //Ejemplo: 
                //string includeProperties = "Property1,Property2,,Property3,";
                //var result = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                // Resultado: ["Property1", "Property2", "Property3"]

                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            //Se aplica el ordenamiento si se proporciona
            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            //Se hace la relacion entre entidades, se incluyen propiedades de navegacion si se proporcionan
            if (includeProperties != null)
            {
                //Ejemplo: 
                //string includeProperties = "Property1,Property2,,Property3,";
                //var result = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                // Resultado: ["Property1", "Property2", "Property3"]

                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(int id)
        {
            T entityRemove = dbSet.Find(id);
            dbSet.Remove(entityRemove);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
