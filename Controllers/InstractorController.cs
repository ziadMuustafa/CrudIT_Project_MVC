using CrudIT_Project.Models;
using CrudIT_Project.Reposatories;
using CrudIT_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CrudIT_Project.Controllers
{
    public class InstractorController : Controller
    {

        private readonly IInstractorRepo _instractorRepo;
        private readonly IDepRepo _depRepo;
        private readonly ICourseRepo _courseRepo;

        public InstractorController(IInstractorRepo instractorRepo , IDepRepo depRepo , ICourseRepo courseRepo)
        {
            _instractorRepo = instractorRepo;
            _depRepo = depRepo;
            _courseRepo = courseRepo;


        }

        public IActionResult GetAll()
        {
            var instractors = _instractorRepo.GetAll();
            return View("GetAll" , instractors);
        }






        [HttpGet]
        public IActionResult Create() 
        {
            var Model = new InstractorCourseDep();

            Model.departments = _depRepo.GetAll().ToList();
            Model.courses = _courseRepo.GetAll().ToList();
            return View("Create",Model);

        }

        [HttpPost]
        public IActionResult Create(InstractorCourseDep instractorCourseDep)
        {

            if (ModelState.IsValid)
            {

                _instractorRepo.Create(instractorCourseDep);
                _instractorRepo.Save();
                return RedirectToAction("GetAll");
            }
            instractorCourseDep.departments = _depRepo.GetAll().ToList();
            instractorCourseDep.courses = _courseRepo.GetAll().ToList();

            return View("Create", instractorCourseDep);
        }




        [HttpGet]
        public IActionResult Edit(int Id)
        {
            InstractorCourseDep instractorCourseDep = new InstractorCourseDep(); 
        
            instractorCourseDep.TempId = Id;    
            instractorCourseDep.courses = _courseRepo.GetAll().ToList();
            instractorCourseDep.departments = _depRepo.GetAll().ToList();

                

            return View("Edit" , instractorCourseDep);
        }

        [HttpPost]
        public IActionResult Edit(InstractorCourseDep instractorCourseDep) 
        {

            if (ModelState.IsValid)
            {
                Instractor? instractor = _instractorRepo.GetById(instractorCourseDep.TempId);
                                        //.GetAll()
                                        //.FirstOrDefault(e => e.Id == instractorCourseDep.TempId);

                instractor.Address = instractorCourseDep.Address;
                instractor.Name = instractorCourseDep.Name; 
                instractor.Img = instractorCourseDep.Img;
                instractor.DepartmentId = instractorCourseDep.DepartmentId;
                instractor.CourseId = instractorCourseDep.CourseId;
                instractor.Salary = instractorCourseDep.Salary;

                _instractorRepo.Update(instractor);
                _instractorRepo.Save();

                return RedirectToAction("GetAll");

            }

            else
            {
                instractorCourseDep.TempId = instractorCourseDep.TempId;
                instractorCourseDep.courses = _courseRepo.GetAll().ToList();
                instractorCourseDep.departments = _depRepo.GetAll().ToList();

                return View("Edit", instractorCourseDep);
            }

        }




        [HttpDelete]
        public IActionResult Delete(int Id) 
        {
        
            _instractorRepo.Delete(Id);

            return RedirectToAction("GetAll");
        }

    }
}
