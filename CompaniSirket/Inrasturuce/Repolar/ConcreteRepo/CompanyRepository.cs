using CompaniSirket.Inrasturuce.Repolar.BaseRepo;
using CompaniSirket.Inrasturuce.Repolar.InterfaceRepo;
using CompaniSirket.Models.contex;
using CompaniSirket.Models.Entity.Entitiler;

namespace CompaniSirket.Inrasturuce.Repolar.ConcreteRepo
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {

        public CompanyRepository(Contex contex) : base(contex)
        {

        }
    }
}
