using System;

namespace DataAccess
{
    public class PostAlreadyExistsExeption: Exception
    {
        public PostAlreadyExistsExeption() : base("Post already exists.") {
        }
    }
}