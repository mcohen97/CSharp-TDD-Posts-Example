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
        private string body;

        public string Title { get { return title; } private set { SetTitle(value); } }

        public string Body { get { return body; } private set { SetBody(value); } }

        public DateTime DatePublished { get; private set; }

        public Post(string aTitle, string aBody, DateTime aDate)
        {
            Title = aTitle;
            Body = aBody;
            DatePublished = aDate;
        }

        private void SetTitle(string aTitle)
        {
            if (string.IsNullOrWhiteSpace(aTitle))
            {
                throw new InvalidPostException("Title can't be empty.");
            }
            title = aTitle;
        }

        private void SetBody(string aBody)
        {
            if (string.IsNullOrWhiteSpace(aBody))
            {
                throw new InvalidPostException("Body can't be empty.");
            }
            body = aBody;
        }
    }
}
