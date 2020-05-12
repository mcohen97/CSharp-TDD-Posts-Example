using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IRepository<T>
    {
        void Add(Post post);

        bool IsEmpty();

        bool Exists(int id);

        Post Get(int id);

        IEnumerable<Post> GetAll();

        void Delete(int id);
    }
}
