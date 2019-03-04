using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_PracticeSessions
{
    class Book : MediaType
    {

        public readonly string Author;

        public Book(string title, string author)
            : base(title)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            string text = "Book: " + Title + " by " + Author;

            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan)";
                }
            }

            return text;
        }

    }
}
