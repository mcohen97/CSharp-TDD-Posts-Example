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
                if (context.Posts.Any(p => p.Id == post.Id)) {
                    throw new PostAlreadyExistsExeption();
                }

                PostEntity toAdd = toEntity(post);
                context.Posts.Add(toAdd);
                context.SaveChanges();
                post.Id = toAdd.Id;
            }
        }

        public void Clear()
        {
            using (PostsContext context = new PostsContext())
            {
                context.Posts.RemoveRange(context.Posts);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (PostsContext context = new PostsContext())
            {
                PostEntity toRemove = context.Posts.FirstOrDefault(p => p.Id == id);

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
                PostEntity found = context.Posts.FirstOrDefault(p => p.Id == id);

                if (found == null)
                {
                    throw new PostNotFoundExeption();
                }

                return toObject(found);
            }
        }

        public IEnumerable<Post> GetAll()
        {
            using (PostsContext context = new PostsContext())
            {
                IEnumerable<PostEntity> retrieved = context.Posts.ToList();
                return retrieved.Select(p => toObject(p));
            }
        }

        public bool IsEmpty()
        {
            using (PostsContext context = new PostsContext())
            {
                return !context.Posts.Any();
            }
        }

        private PostEntity toEntity(Post post) {
            return new PostEntity()
            {
                Id = post.Id,
                Title = post.Title,
                Body = post.Body,
                PublishedDate = post.DatePublished
            };

        }

        private Post toObject(PostEntity entity) {
            return new Post(entity.Id, entity.Title, entity.Body, entity.PublishedDate);

        }
    }
}
