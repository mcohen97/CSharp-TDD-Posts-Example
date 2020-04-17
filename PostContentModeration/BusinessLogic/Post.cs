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

        public bool ContainsWord(string word)
        {
            List<string> tokens = new List<string>();

            string delimiterRegex = @"\W+";

            tokens.AddRange(Regex.Split(Body, delimiterRegex));
            tokens.AddRange(Regex.Split(Title, delimiterRegex));

            return tokens.Any(t => t.Equals(word));
        }
    }
}
