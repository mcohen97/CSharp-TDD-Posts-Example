using System;

namespace BusinessLogic
{
    public class PostAlreadyExistsExeption: Exception
    {
        public PostAlreadyExistsExeption() : base("Post already exists.") {
        }
    }
}