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
    }
}