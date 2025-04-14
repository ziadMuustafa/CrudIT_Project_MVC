using CrudIT_Project.CrudItContext;
using CrudIT_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudIT_Project.Reposatories
{
    public class DepRepo : IDepRepo
    {
        AppDBcontext _dBcontext;

        public IEnumerable<Department> GetAll()
        {
            IEnumerable<Department> departments = _dBcontext.Departments
                                                               .Include(e => e.Courses)
                                                               .Include(e => e.Instractors);

            return departments;
        }

        public Department GetById(int id)
        {
            Department? dep = _dBcontext.Departments.Find(id);

            return dep;
        }


        public DepRepo(AppDBcontext dBcontext)
        {
            _dBcontext = dBcontext;

        }

        public void Create(object entity)
        {

            _dBcontext.Departments.Add((Department)entity);
            
        }

        public void Delete(int id)
        {
           
        }

        public void DeleteAll()
        {
            
        }


        public void Save()
        {
            
        }

        public void Update(object entity)
        {
            
        }
    }
}
