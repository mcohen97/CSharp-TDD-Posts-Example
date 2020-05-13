using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Post
    {
        private static readonly int MAX_TITLE_LENGTH = 50;
        private static readonly int MAX_BODY_LENGTH = 300;

        private string title;
        private string body;
        private DateTime publishedDate;

        public string Title { get { return title; } private set { SetTitle(value); } }

        public string Body { get { return body; } private set { SetBody(value); } }

        public DateTime DatePublished { get { return publishedDate;  } private set { SetPublishedDate(value); } }

        public int Id { get;  set; }

        public Post(string aTitle, string aBody, DateTime aDate)
        {
            Title = aTitle;
            Body = aBody;
            DatePublished = aDate;
        }

        public Post(int id, string aTitle, string aBody, DateTime aDate): this(aTitle,aBody,aDate){
            Id = id;
        }

        private void SetTitle(string aTitle)
        {
            if (string.IsNullOrWhiteSpace(aTitle))
            {
                throw new InvalidPostException("Title can't be empty.");
            }
            if (aTitle.Length > MAX_TITLE_LENGTH) {
                throw new InvalidPostException($"Title can't exceed {MAX_TITLE_LENGTH} characters.");
            }
            title = aTitle;
        }

        private void SetBody(string aBody)
        {
            if (string.IsNullOrWhiteSpace(aBody))
            {
                throw new InvalidPostException("Body can't be empty.");
            }
            if (aBody.Length > MAX_BODY_LENGTH) {
                throw new InvalidPostException($"Title can't exceed {MAX_BODY_LENGTH} characters.");
            }
            body = aBody;
        }

        private void SetPublishedDate(DateTime date)
        {
            if (date > DateTime.Now) {
                throw new InvalidPostException("Posts can't have future dates.");
            }
            publishedDate = date;
        }

        public bool ContainsWord(string word)
        {
            List<string> tokens = new List<string>();

            string delimiterRegex = @"\W+";

            tokens.AddRange(Regex.Split(Body, delimiterRegex));
            tokens.AddRange(Regex.Split(Title, delimiterRegex));

            return tokens.Any(t => t.Equals(word));
        }

        public override string ToString()
        {
            return $"Title: {Title} \nBody: {Body} \nPublished: {DatePublished}";
        }
    }
}
