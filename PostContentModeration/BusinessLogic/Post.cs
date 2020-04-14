using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Post
    {
        public string Title { get; private set; }
        public string Body { get; private set; }
        public DateTime DatePublished { get; private set; }

        public Post(string aTitle, string aBody, DateTime aDate) {
            Title = aTitle;
            Body = aBody;
            DatePublished = aDate;
        }
    }
}
