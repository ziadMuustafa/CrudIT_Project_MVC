using CrudIT_Project.Models;

namespace CrudIT_Project.Reposatories
{
    public interface IDepRepo : IReposatory 
    {
        public IEnumerable<Department> GetAll();

        public Department GetById(int id);

    }
}
