using System;
using System.Text;
using System.Text.RegularExpressions;

namespace BookShop.Models
{
    public class Book
    {
        private decimal price;
        private string author;
        private string title;

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        protected string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                string[] authorNames = value.Split();
                string pattern = @"^\d";
                Regex regex=new Regex(pattern);
                if (authorNames.Length>1&&regex.IsMatch(authorNames[1]))
                {
                    throw new ArgumentException($"{nameof(this.Author)} not valid!");
                }
                this.author = value;
            }
        }

        protected string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(this.Title)} not valid!");
                }
                this.title = value;
            }
        }

        protected virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Price)} not valid!");
                }
                this.price = value;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append($"Price: {this.Price:F1}")//.Append(this.Price)
                    .Append(Environment.NewLine);

            return sb.ToString();
        }


    }
}
