using CrudIT_Project.Models;

namespace CrudIT_Project.Reposatories
{
    public interface IInstractorRepo : IReposatory
    {
        public IEnumerable<Instractor> GetAll();

        public Instractor GetById(int id);

    }
}
