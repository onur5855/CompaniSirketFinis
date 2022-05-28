using CompaniSirket.Inrasturuce.Repolar.InterfaceRepo;
using CompaniSirket.Models.contex;
using CompaniSirket.Models.Entity.BaseEntity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CompaniSirket.Inrasturuce.Repolar.BaseRepo
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseClas
    {
        private readonly Contex Contex;
        private readonly DbSet<T> table;

        public BaseRepository(Contex contex)
        {
            this.Contex = contex;
            table = contex.Set<T>();
        }

        public void Create(T entity)
        {
            table.Add(entity);
            Contex.SaveChanges();
        }
        public void Update(T entity)
        {
            Contex.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.Isactive = false;
            Contex.SaveChanges();
        }
       

        public T Getir(Expression<Func<T, bool>> Expression)
        {
           return table.FirstOrDefault(Expression);
        }

        public List<T> GetirList(Expression<Func<T, bool>> Expression)
        {
            return table.Where(Expression).ToList();
        }

       
    }
}
