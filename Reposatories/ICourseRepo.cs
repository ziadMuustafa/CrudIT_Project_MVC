using CrudIT_Project.Models;

namespace CrudIT_Project.Reposatories
{
    public interface ICourseRepo : IReposatory
    {
        public IEnumerable<Course> GetAll();

        public Course GetById(int id);

    }
}
