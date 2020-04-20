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
            return posts.First(p => p.Id == id);
        }
    }
}