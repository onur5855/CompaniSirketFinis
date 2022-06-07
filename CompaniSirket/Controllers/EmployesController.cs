using CompaniSirket.DataTransferObject;
using CompaniSirket.Inrasturuce.Repolar.InterfaceRepo;
using CompaniSirket.Models.Entity.Entitiler;
using CompaniSirket.VM;
using Microsoft.AspNetCore.Mvc;

namespace CompaniSirket.Controllers
{
    public class EmployesController : Controller
    {
        private readonly IEmployeeRepository repo;
        private readonly ICompanyRepository comRepo;

        public EmployesController(IEmployeeRepository repo,ICompanyRepository ComRepo)
        {
            this.repo = repo;
            comRepo = ComRepo;
        }
        public void FillCompany()
        {
          ViewBag.CompanyList = comRepo.GetirList(a => a.Isactive == true);
        }

        public IActionResult Create()
        {
            FillCompany();
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(EmployeCreateDTO model)
        {
            Employee employee=new Employee();
            if (ModelState.IsValid)
            {
                employee.Adi=model.Adi;
                employee.Soyadi=model.Soyadi;
                employee.CompanyID = model.CompanyID;
                employee.EgitimDurumu=model.EgitimDurumu;
                employee.DogumTarihi=model.DogumTarihi;
                employee.Tc=model.Tc;
                employee.Maas=model.Maas;
                repo.Create(employee);
               return RedirectToAction("List");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            FillCompany();
            Employee emp=new Employee();
           emp =repo.Getir(a => a.ID == id);
            EmployesUpdateDTO dto=new EmployesUpdateDTO();
            dto.ID=id;
            dto.Adi=emp.Adi;
            dto.Soyadi=emp.Soyadi;
            dto.Tc=emp.Tc;
            dto.Maas=emp.Maas;
            dto.EgitimDurumu =emp.EgitimDurumu;
            dto.DogumTarihi =emp.DogumTarihi;
            dto.CompanyID =emp.CompanyID;
            
            return View(dto);
        }
        [HttpPost]
        public IActionResult Update(EmployesUpdateDTO dto)
        {
            Employee emp = repo.Getir(a => a.ID == dto.ID);            
            if (ModelState.IsValid)
            {                
                emp.ID = dto.ID;
                emp.Adi=dto.Adi;
                emp.Soyadi = dto.Soyadi;
                emp.DogumTarihi=dto.DogumTarihi;
                emp.Maas=dto.Maas;
                emp.CompanyID =dto.CompanyID;
                emp.EgitimDurumu=dto.EgitimDurumu;
                emp.Tc=dto.Tc;
                repo.Update(emp);
                return RedirectToAction("List");
            }
            else return View(dto);
        }
        public IActionResult Delete(int id)
        {
            repo.Delete(repo.Getir(a => a.ID == id));
            return RedirectToAction("List");
        }



        public IActionResult List()
        {
            return View(repo.GetirList(a => a.Isactive == true));
        }



    }
}
