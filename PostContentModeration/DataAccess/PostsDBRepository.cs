using BusinessLogic;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public class PostsDBRepository : IPostsRepository
    {
        public void Add(Post post)
        {
            using (PostsContext context = new PostsContext()) {
                if (context.Posts.Any(p => p.Id == post.Id)) {
                    throw new PostAlreadyExistsExeption();
                }

                PostEntity toAdd = ToEntity(post);
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

                return ToObject(found);
            }
        }

        public IEnumerable<Post> GetAll()
        {
            try
            {
            return TryGetAll();
            }
            catch (SqlException)
            {
                throw new DataUnavailableException();
            }
            catch (DbException)
            {
                throw new DataUnavailableException();
            }
            catch (EntityException) {
                throw new DataUnavailableException();
            }
        }

       private IEnumerable<Post> TryGetAll() {
            using (PostsContext context = new PostsContext())
            {
                IEnumerable<PostEntity> retrieved = context.Posts.ToList();
                return retrieved.Select(p => ToObject(p));
            }
        }

        public bool IsEmpty()
        {
            using (PostsContext context = new PostsContext())
            {
                return !context.Posts.Any();
            }
        }

        private PostEntity ToEntity(Post post) {
            return new PostEntity()
            {
                Id = post.Id,
                Title = post.Title,
                Body = post.Body,
                PublishedDate = post.DatePublished
            };

        }

        private Post ToObject(PostEntity entity) {
            return new Post(entity.Id, entity.Title, entity.Body, entity.PublishedDate);

        }
    }
}
