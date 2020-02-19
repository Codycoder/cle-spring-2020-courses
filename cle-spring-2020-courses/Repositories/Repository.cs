using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private UniversityContext db;

        public Repository(UniversityContext db)
        {
            this.db = db;
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

    }
}
