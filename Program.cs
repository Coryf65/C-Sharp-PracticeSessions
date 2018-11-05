using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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


            #region "Collections Lists"
            ////Generic type
            
            //// list of strings
            //List<String> students = new List<string>();

            //students.Add("Sue");
            //students.Add("Bill");
            //students.Add("Alan");

            //Console.WriteLine("How many students: " + students.Count);

            //// a list is pretty much a wrapper around an array and can grow as much as we need

            //// so the List type save one spot extra
            //Console.WriteLine("Total number of spots in students List: " + students.Capacity);

            //// you could preset the total number of saved spots 100 if you are off it can still add more
            //List<String> students2 = new List<string>(100);

            //// Lists are the most common collection type
            //List<int> lockCombination = new List<int>();

            //Console.WriteLine("Lock Combination: " + lockCombination.ToString());

            //Console.WriteLine("Lock Combination Contents: ");
            //// print out the contents
            //for (int i = 0; i < lockCombination.Count; i++)
            //{
                
            //        Console.WriteLine(" {0}", lockCombination[i]);    
                
            //}

            //lockCombination.Add(12);

            //Console.WriteLine("adding 12: ");
            //// print out the contents
            //for (int i = 0; i < lockCombination.Count; i++)
            //{

            //    Console.WriteLine(" {0}", lockCombination[i]);

            //}

            //lockCombination.Add(42);

            //Console.WriteLine("adding 42: ");
            //// print out the contents
            //for (int i = 0; i < lockCombination.Count; i++)
            //{

            //    Console.WriteLine(" {0}", lockCombination[i]);

            //}
            //lockCombination.Add(13);

            //Console.WriteLine("adding 13: ");
            //// print out the contents
            //for (int i = 0; i < lockCombination.Count; i++)
            //{

            //    Console.WriteLine(" {0}", lockCombination[i]);

            //}

            //Console.WriteLine("What is the Capacity Now?  {0}", lockCombination.Capacity);


            //// Finding and removing an item from the list, without knowing where in the list it is.

            //// creating a list and finding a string then removing it.
            //List <string> students3 = new List<string>() { "Sue", "Frank", "Joe", "Betsy", "Tom", "Simon", "Jill", "Tommy", "Mary", "Armuro" };

            //// trying to find and remove Tom
            //// if we have more than 1 Tom, it would remove the first occurence
            //// this can be slow if the list is long
            //Console.WriteLine("Finding and Removing Tom");
            //var success = students3.Remove("Tom");

            //Console.WriteLine("Did it work? {0}", success);         

            //// Test 1, make a function that gets the powers of 2 to any given #
            //Console.WriteLine("Calling GetPowersOf2...");

            //List<int> powerList = GetPowersOf2(4);

            //Console.WriteLine("Printing out the List... ");
            //// print out the contents
            //for (int i = 0; i < powerList.Count; i++)
            //{

            //    Console.WriteLine(" {0}", powerList[i]);

            //}

            /////// Sorting Lists

            //Console.WriteLine("Original Students 3...");

            //for (int i = 0; i < students3.Count; i++)
            //{
            //    Console.WriteLine(" {0}", students3[i]);
            //}

            //Console.WriteLine("Sorting Student3...");

            //students3.Sort();

            //for (int i = 0; i < students3.Count; i++)
            //{
            //    Console.WriteLine(" {0}", students3[i]);
            //}

            /////// Now Creating a Student Object
            //// the Student.cs

            //Console.WriteLine("Creating Student Object");

            //List<Student> kiddos = new List<Student>
            //{
            //    new Student() { Name = "Sally", GradLevel = 3 },
            //    new Student() { Name = "Bob", GradLevel = 3 },
            //    new Student() { Name = "Sally", GradLevel = 2 }
            //};

            //Console.WriteLine("Sorting... Student Object");

            //kiddos.Sort();

            //Console.WriteLine("Printing... Student Object");

            //foreach (Student student in kiddos)
            //{
            //    Console.WriteLine($"{student.Name} is in grade {student.GradLevel}");
            //}


            /////// Searching Sorted Lists

            //// We can greatly increase the speed of searching a list by sorting it first
            //// We search it after we Sort, using Binary Search can be faster 

            //// 

            //Student newStudent = new Student() { Name = "Joe", GradLevel = 2 };

            //Console.WriteLine("Finding Joe...");

            //// if "Joe" is in the list the result will be a positive int
            //int index = kiddos.BinarySearch(newStudent);


            //// the negative number is its int and -1
            //if (index < 0)
            //{
            //    Console.WriteLine("Adding Joe...");

            //    //  the bitwise compliment
            //    kiddos.Insert((-index)-1, newStudent);
            //    // could also do it with the special Operator "~"
            //    // kiddos.Insert(~index, newStudent              
            //}
            //else
            //{
            //    Console.WriteLine("Found Joe...");
            //}

            //foreach (Student student in kiddos)
            //{
            //    Console.WriteLine($"{student.Name} is in grade {student.GradLevel}");
            //}

            #endregion

            #region "Collection Interfaces"

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------- Collection Interfaces ---------------");

            Console.ForegroundColor = ConsoleColor.White;

            // every collection type inherits ICollection, and IEnumerable

            // creating a class SchoolRoll

            //Read-only Collection Interfaces
            Console.WriteLine("~~~ Read-only Collection Interfaces ~~~");

            #endregion
        }

        // Test 1
        // Create a static method named GetPowersOf2 that returns a list of integers
        // of type List<int> containing the powers of 2 from 0 to the value passed in. 
        // For example, if 4 is passed in, the method should return this list
        // of integers: { 1, 2, 4, 8, 16 }. The System.Math.Pow method will come in handy.
        public static List<int> GetPowersOf2(int endRange)
        {
            //passing to the range of what?
            List<int> list = new List<int>();
            int end;

            int value = 2;
            for (int power = 0; power <= endRange; power++)
            {
                //Console.WriteLine("{0}^{1} = {2}", value, power, (long)Math.Pow(value, power));

                //Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})", value, power, (long)Math.Pow(value, power));
            end = (int)Math.Pow(value, power);
                list.Add(end);
            }               

            return list;
        }
       
    }
}
