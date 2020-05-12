using System;

namespace BusinessLogic
{
    public class PostNotFoundExeption : Exception
    {
        public PostNotFoundExeption() : base("The post does not exist.") {
        }
    }
}