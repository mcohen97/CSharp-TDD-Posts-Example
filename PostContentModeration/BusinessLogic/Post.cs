using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Post
    {
        private string title;
        public string Title { get { return title; } private set { setTitle(value); } }

        public string Body { get; private set; }
        public DateTime DatePublished { get; private set; }

        public Post(string aTitle, string aBody, DateTime aDate) {
            Title = aTitle;
            Body = aBody;
            DatePublished = aDate;
        }

        private void setTitle(string aTitle) {
            if (string.IsNullOrWhiteSpace(aTitle)) {
                throw new InvalidPostException("Title can't be empty.");
            }
            title = aTitle;
        }
    }
}
