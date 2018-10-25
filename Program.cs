using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_PracticeSessions
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "Part of Objects Practice"

            //Console.WriteLine("C# Practice..." + "\r\n");

            //var album = new Album("Disease", "Beartooth");           
            //var book = new Book("Don't Make Me Think", "Steve Krug");   
            //var movie = new Movie("Lego Movie", "Chris Miller, Phil Lord");


            //Console.WriteLine("Album: " + album.Title + " by, " + album.Artist);
            //Console.WriteLine("Book: " + book.Title + " by, " + book.Author);
            //Console.WriteLine("Movie: " + movie.Title + " by, " + movie.Director);

            //// showing that we can change the fields after
            //album.Title = "Sick";

            //// and now it changed viola!
            //Console.WriteLine("Album: " + album.Title + " by, " + album.Artist);

            #endregion


        #region "Part of Arrays Practice"
            
            // arrays 
            int[] lockcombination = new int[3];

            Console.WriteLine(string.Join(",", lockcombination));

            // do not need to specify length
            int[] lockcombination2 = new int[] { 10, 5, 32 };

            Console.WriteLine(string.Join(",", lockcombination2));

            // or specify type or use new
            int[] lockcombination3 = { 40, 55, 62 };

            Console.WriteLine(string.Join(",", lockcombination3));

            // selecting an item from an array saved as a var
            int last = lockcombination3[2];

            Console.WriteLine("Last item of lockcombination3 = " + last);

            // changing the last item from lockcombination3 ...
            lockcombination3[2] = 20;

            Console.WriteLine("Last item of lockcombination3 is changed to = " + lockcombination3[2]);

            #endregion


        }
    }
}
