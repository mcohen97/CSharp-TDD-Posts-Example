using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class PostsRepository
    {
        private List<Post> posts;

        public PostsRepository() {
            posts = new List<Post>();
        }

        public void Add(Post post)
        {
            if (posts.Any(p => p.Id == post.Id)) {
                throw new PostAlreadyExistsExeption();
            }
            posts.Add(post);
        }
        public bool IsEmpty()
        {
            return !posts.Any();
        }

        public bool Exists(int id)
        {
            return posts.Any(p => p.Id == id);
        }

        public Post Get(int id)
        { 
            Post result =  posts.FirstOrDefault(p => p.Id == id);
            if (result == null) {
                throw new PostNotFoundExeption();
            }
            return result;
        }

        public IEnumerable<Post> GetAll()
        {
            return posts.AsEnumerable();
        }

        public void Delete(int id)
        {
            int deleted = posts.RemoveAll(p => p.Id == id);
            if (deleted == 0) {
                throw new PostNotFoundExeption();
            }
        }
    }
}