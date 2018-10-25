using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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

            // C# Collections

            #region "Part of Arrays Practice"

            // arrays 
            //int[] lockcombination = new int[3];

            //Console.WriteLine(string.Join(",", lockcombination));

            //// do not need to specify length
            //int[] lockcombination2 = new int[] { 10, 5, 32 };

            //Console.WriteLine(string.Join(",", lockcombination2));

            //// or specify type or use new
            //int[] lockcombination3 = { 40, 55, 62 };

            //Console.WriteLine(string.Join(",", lockcombination3));

            //// selecting an item from an array saved as a var
            //int last = lockcombination3[2];

            //Console.WriteLine("Last item of lockcombination3 = " + last);

            //// changing the last item from lockcombination3 ...
            //lockcombination3[2] = 20;

            //Console.WriteLine("Last item of lockcombination3 is changed to = " + lockcombination3[2]);

            #endregion


            #region"Multi dimensional Arrays"

            // using Jagged Arrays Far more common

            // added class Cell
            //creating an array of cells, like a Spreadsheet

            //Cell[][] sheet = new Cell[100][];

            //// now to visualize
            //Console.WriteLine(sheet);

            //// creating a 1000 cells inside of an array
            //for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            //{
            //    sheet[rowIndex] = new Cell[10]; // create a row of 10 cells

            //    for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
            //    {
            //        sheet[rowIndex][colIndex] = new Cell();
            //    }
            //}

            //// output


            //// now using a for each loop instead
            //foreach  (Cell[] row in sheet)
            //{
            //    foreach (Cell cell in row)
            //    {
            //        Console.Write(cell);
            //    }
            //    Console.WriteLine();
            //}


            // Using 2D arrays 


            //                   Cell[Row, Columns]
            //Cell[,] sheet2 = new Cell[100, 10];     

            //// showing an spot in that array
            //Console.WriteLine("Showing sheet2's 0,0 spot: " + sheet2[0,0]);

            //// 3 dem array Jagged style
            //Cell[][][] sheet3 = new Cell[100][][];

            //// 3 dim multi style
            //int[,,] threeDimMatrix = new int[5, 5, 5];



            #endregion


            #region "Lists"

            //Generic type
            
            // list of strings
            List<String> students = new List<string>();

            students.Add("Sue");
            students.Add("Bill");
            students.Add("Alan");

            Console.WriteLine("How many students: " + students.Count);

            // a list is pretty much a wrapper around an array and can grow as much as we need

            #endregion

        }

    }
}
