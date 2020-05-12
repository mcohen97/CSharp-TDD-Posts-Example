using System;

namespace DataAccess
{
    public class PostNotFoundExeption : Exception
    {
        public PostNotFoundExeption() : base("The post does not exist.") {
        }
    }
}