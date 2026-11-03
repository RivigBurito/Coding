// ============================================================
//  Lesson 1  -  "Hello, World!"  check & extension
//  A-Level Computer Science (AQA 7517)  -  Hills Road SFC
// ============================================================
// AIM: prove your C# environment runs, then stretch yourself.
//
// If you completed the summer work, Parts 1 and 2 will feel
// familiar - go straight to the EXTENSION section and see how
// far you can get.

using System;

namespace HelloWorldExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---- Part 1: the classic (everyone) ----
            Console.WriteLine("Hello, World!");

            // ---- Part 2: make it personal (everyone) ----
            // A VARIABLE is a named box in memory that holds a value.
            // Its DATA TYPE (here, string) says what kind of value it holds.
            string name = "Sam";                       // <-- change to your name
            Console.WriteLine("Hello! My name is " + name + ".");

            // ============================================================
            //  EXTENSION  (if you finished the summer work)
            // ============================================================
            // Tackle these in order. Run the program after each change
            // so you can see exactly what your code did.

            // E1) Ask the user for their name instead of hard-coding it.
            //     Hint: Console.Write(...) to prompt, then Console.ReadLine().

            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username + "!");


            // E2) Ask for their favourite whole number, then print it doubled.
            //     Hint: text from the console must be CONVERTED to an int
            //           before you can do maths with it -> int.Parse(...)
            

            // E3) Print a short "profile card" over several lines using
            //     ONE Console.WriteLine and the newline symbol \n.

            Console.WriteLine("Profile Card:\nName: " + username + "\nFavourite Number: " + "N/A" + "\nDoubled Number: " + "N/A");




            // E4) CHALLENGE: what happens if the user types "cat" when you
            //     asked for a number? Try it on purpose. Read the error.
            //     We will learn how to handle this together.

           

            Console.WriteLine();
            Console.WriteLine("Press ENTER to close...");
            Console.ReadLine();   // keeps the console window open in Visual Studio
        }
    }
}
