using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PostsDBRepository : IRepository<Post>
    {
        public void Add(Post post)
        {
            using (PostsContext context = new PostsContext()) {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (PostsContext context = new PostsContext())
            {
                Post toRemove = context.Posts.First(p => p.Id == id);

                if (toRemove == null)
                {
                    throw new PostNotFoundExeption();
                }

                context.Posts.Remove(toRemove);
                context.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            using (PostsContext context = new PostsContext())
            {
                return context.Posts.Any(p => p.Id == id);
            }
        }

        public Post Get(int id)
        {
            using (PostsContext context = new PostsContext())
            {
                Post found = context.Posts.First(p => p.Id == id);

                if (found == null)
                {
                    throw new PostNotFoundExeption();
                }

                return found;
            }
        }

        public IEnumerable<Post> GetAll()
        {
            using (PostsContext context = new PostsContext())
            {
                return context.Posts;
            }
        }

        public bool IsEmpty()
        {
            using (PostsContext context = new PostsContext())
            {
                return !context.Posts.Any();
            }
        }
    }
}
