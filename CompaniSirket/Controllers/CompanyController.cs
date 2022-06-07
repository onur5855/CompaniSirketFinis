using CompaniSirket.DataTransferObject;
using CompaniSirket.Inrasturuce.Repolar.InterfaceRepo;
using CompaniSirket.Models.Entity.Entitiler;
using CompaniSirket.VM;
using Microsoft.AspNetCore.Mvc;

namespace CompaniSirket.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository repo;
        private readonly IEmployeeRepository eRepo;

        public CompanyController(ICompanyRepository repo , IEmployeeRepository eRepo)
        {
            this.repo = repo;
            this.eRepo = eRepo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CompanyCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                Company company=new Company();
                company.Name = model.Name;
                company.Kurucu_Adi=model.Kurucu_Adi;
                company.Kurucu_Soyadi = model.Kurucu_Soyadi;
                company.Kurulum_Tarihi = model.Kurulum_Tarihi;
                company.Adres_Bilgileri=model.Adres_Bilgileri;
                repo.Create(company);
                return RedirectToAction("List");
            }
            else return View(model);
        }
        public IActionResult Delete(int id)
        {
             repo.Delete(repo.Getir(a=>a.ID==id));
            return RedirectToAction("List");
        }

        public IActionResult Update(int id)
        {
            Company com = repo.Getir(a => a.ID == id);
            CompanyUpdateDTO DTO=new CompanyUpdateDTO();
            
            DTO.Name=com.Name;
            DTO.Kurucu_Adi=com.Kurucu_Adi;
            DTO.Kurucu_Soyadi = com.Kurucu_Soyadi;
            DTO.Kurulum_Tarihi=com.Kurulum_Tarihi;
            DTO.Adres_Bilgileri=com.Adres_Bilgileri;
            return View(DTO);
        }
        [HttpPost]
        public IActionResult Update(CompanyUpdateDTO model)
        {

            Company company=repo.Getir(a=>a.ID==model.ID);
            if (ModelState.IsValid)
            {
                company.Name=model.Name;
                company.Kurucu_Adi=model.Kurucu_Adi;
                company.Kurucu_Soyadi=model.Kurucu_Soyadi;
                company.Kurulum_Tarihi=model.Kurulum_Tarihi;
                company.Adres_Bilgileri=model.Adres_Bilgileri;
                repo.Update(company);
                return RedirectToAction("List");
            }
            else return View(model);
        }


        public IActionResult List()
        {
           return View( repo.GetirList(a=>a.Isactive==true));
        }

        //company Detay yapıcam detayta Combobaxda calısanları listelicem tek bu kaldı
        

        public IActionResult Details(int id)
        {
           
            return View(repo.Getir(a => a.ID == id));
        }


    }
}
