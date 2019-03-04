using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_PracticeSessions
{

    /// <summary>
    /// 2nd Challenge
    // In each media type subclass, replace the GetDisplayText() method with a DisplayText computed property.
    // Use either the regular C# property syntax or the more concise expression-bodied property syntax.
    // In the MediaLibrary class, add a NumberOfItems computed property that returns an integer representing the number of items in the media library.
    // Update the Program.cs file as needed.
    // Also add code to the Main() method in order to test the new MediaLibrary NumberOfItems computed property.
    /// </summary>

    class MediaType
    {
        //// Prop
        //private readonly string _title;

        //public string Title
        //{
        //    get { return _title; } 
        //}

        // now using a short hand propert init
        public string Title { get; private set; } //want to set the value to only be like "read only" scope is in this class

        public string Loanee { get; private set; }
        public bool OnLoan { get; private set; }

        public MediaType(string title)
        {

            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("A media type must  have a title");
            }

            // can't set using the shorthand
            //_title = title;
            Title = title;

        }

        public void Loan()
        {
            OnLoan = true;
        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }

    }
}
