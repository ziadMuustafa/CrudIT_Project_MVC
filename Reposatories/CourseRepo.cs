using CrudIT_Project.CrudItContext;
using CrudIT_Project.Models;

namespace CrudIT_Project.Reposatories
{
    public class CourseRepo : ICourseRepo
    {
        private readonly AppDBcontext _appDBcontext;

        public CourseRepo(AppDBcontext appDBcontext)
        {
            this._appDBcontext = appDBcontext;
        }

        public void Create(object entity)
        {

            Course course = (Course)entity;

             _appDBcontext.Courses.Add(course);

        }

        public void Delete(int id)
        {

            Course? course = _appDBcontext.Courses.Find(id);

            if (course != null)
            {
                _appDBcontext.Courses.Remove(course);
            }

        }

        public void DeleteAll()
        {

            _appDBcontext.Courses.RemoveRange(_appDBcontext.Courses);

        }

        public IEnumerable<Course> GetAll()
        {

            IEnumerable<Course> courses = _appDBcontext.Courses;
            return courses;

        }

        public Course GetById(int id)
        {

            Course? course = _appDBcontext.Courses.Find(id);

            return course;

        }

        public void Save()
        {
            _appDBcontext.SaveChanges();

        }

        public void Update(object entity)
        {

            Course course = (Course)entity;

            _appDBcontext.Courses.Update(course);

        }
    }
}
