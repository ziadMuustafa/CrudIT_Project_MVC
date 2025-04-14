namespace CrudIT_Project.Reposatories
{
    public interface IReposatory 
    {

        public void Create(object entity);

        public void Update(object entity);

        public void Delete(int id);

        public void DeleteAll();

        public void Save();

    }
}
