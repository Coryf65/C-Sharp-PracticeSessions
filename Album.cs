using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_PracticeSessions
{
    class Album : MediaType
    {
        //field
        //public readonly string Artist;

        //changing this fiel to a prop
        public string Artist { get; private set; }


        public Album(string title, string artist)
            : base(title)
        {
            Artist = artist;
        }

        public string GetDisplayText()
        {
            string text = "Album: " + Title + " by " + Artist;

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
