using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PostsContext: DbContext
    {
        public PostsContext() : base("name=PostsConnString")
        {

        }

        public DbSet<PostEntity> Posts { get; set; }


    }
}
