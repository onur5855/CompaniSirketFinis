using CompaniSirket.Inrasturuce.Repolar.BaseRepo;
using CompaniSirket.Inrasturuce.Repolar.InterfaceRepo;
using CompaniSirket.Models.contex;
using CompaniSirket.Models.Entity.Entitiler;

namespace CompaniSirket.Inrasturuce.Repolar.ConcreteRepo
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(Contex contex) : base(contex)
        {
        }
    }
}
