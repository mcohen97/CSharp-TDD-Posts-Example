﻿using System;
using System.Collections.Generic;
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

    }
}
