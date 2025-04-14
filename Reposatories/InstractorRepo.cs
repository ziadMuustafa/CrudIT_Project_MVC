
using CrudIT_Project.CrudItContext;
using CrudIT_Project.Models;
using CrudIT_Project.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CrudIT_Project.Reposatories
{
    public class InstractorRepo : IInstractorRepo
    {
        AppDBcontext _appDBcontext;
        public InstractorRepo(AppDBcontext appDBcontext)
        {
            this._appDBcontext = appDBcontext; 
        }


        public void Create(object entity)
        {

            InstractorCourseDep instractorCourseDep = (InstractorCourseDep)entity;

            Instractor instractor = new Instractor()
            { Address = instractorCourseDep.Address ,
              CourseId = instractorCourseDep.CourseId ,
              DepartmentId = instractorCourseDep.DepartmentId ,
              Img = instractorCourseDep.Img,
              Name = instractorCourseDep.Name,
              Salary = instractorCourseDep.Salary 
            };

            _appDBcontext.Instractors.Add(instractor);
        }


        public void Delete(int id)
        {
            //Instractor instractor = _appDBcontext.Instractors.Find(id);
            Instractor? instractor = _appDBcontext.Instractors.FirstOrDefault(e => e.Id == id);

            if (instractor != null)
            {
                _appDBcontext.Instractors.Remove(instractor);
            }

        }


        public void DeleteAll()
        {
            _appDBcontext.Instractors.RemoveRange(_appDBcontext.Instractors);

        }

        public IEnumerable<Instractor> GetAll()
        {
            IEnumerable<Instractor> instractors = _appDBcontext.Instractors
                                                               .Include(e => e.Course)
                                                               .Include(e => e.Department);
            return instractors;
        }

        public Instractor GetById(int id)
        {
            Instractor? instractor  = _appDBcontext.Instractors.Find(id);

            return instractor;
        }

        public void Save()
        {
            _appDBcontext.SaveChanges();    

        }

        public void Update(object entity)
        {
            Instractor instractor = (Instractor)entity;

            _appDBcontext.Instractors.Update(instractor);

        }
    }
}
