using CompaniSirket.Models.Entity.BaseEntity;
using System.Linq.Expressions;

namespace CompaniSirket.Inrasturuce.Repolar.InterfaceRepo
{
    public interface IBaseRepository<T> where T : BaseClas
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Getir(Expression<Func<T, bool>> Expression);
        List<T>  GetirList(Expression<Func<T, bool>> Expression);



    }
}
