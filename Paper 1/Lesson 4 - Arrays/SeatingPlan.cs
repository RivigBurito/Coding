// Lesson 4 - PRIMM: the seating plan (2D arrays)
// A-Level Computer Science (AQA 7517)
//
// >>> THIS PROGRAM IS COMPLETE AND WORKING. <<<
// There is nothing to fix. You are going to PREDICT what it does, RUN it,
// INVESTIGATE how it works, and only then MODIFY it.
//
// -------------------------------------------------------------------------
// 1. PREDICT - on paper, BEFORE you run anything. Write your answers down.
//      (a) What exactly will "Line A" print?
//      (b) In what ORDER will the names appear in the grid printout -
//          across the rows, or down the columns?
//      (c) How many names are printed by the grid printout in total?
//
// 2. RUN it. Compare with your prediction. Anything that surprised you goes
//    straight into your Programmer's Log.
//
// 3. INVESTIGATE - see the questions at the bottom of this file.
//
// 4. MODIFY - see the tasks at the bottom of this file.
// -------------------------------------------------------------------------

using System;
using System.ComponentModel.Design.Serialization;
using System.Data;

namespace SeatingPlan
{
  class Program
  {
    static void Main(string[] args)
    {
      // A seating plan: 4 rows of 5 seats.
      // Row 0 is the FRONT row; row 3 is the BACK row.
      // Seat 0 is by the window; seat 4 is by the door.
      string[,] seats = new string[4, 5]
      {
        { "Amira", "Ben",   "Chloe", "Dev",  "Ella"  },
        { "Farid", "Grace", "Hugo",  "Isla", "Jonah" },
        { "Kiera", "Liam",  "Maya",  "Noor", "Omar"  },
        { "Priya", "Quinn", "Rosa",  "Sam",  "Tia"   }
      };

      // ----- Line A -----------------------------------------------------
      Console.WriteLine("Line A: " + seats[1, 2]);
      Console.WriteLine();

      // ----- The whole grid ---------------------------------------------
      // Note the shape: a loop INSIDE a loop. The outer one walks the rows,
      // the inner one walks the seats within that row.
      //Console.WriteLine("=== The seating plan ===");
      for (int row = 0; row < seats.GetLength(0); row++)
      {
        for (int col = 0; col < seats.GetLength(1); col++)
        {
      //    Console.Write(seats[row, col] + "\t");
        }
      //  Console.WriteLine();   // end of a row - move to the next line
      }
      Console.WriteLine();

      // ----- How big is it? ---------------------------------------------
      //Console.WriteLine("GetLength(0) = " + seats.GetLength(0) + "   <- number of ROWS");
      //Console.WriteLine("GetLength(1) = " + seats.GetLength(1) + "   <- number of COLUMNS");
      //Console.WriteLine("Length       = " + seats.Length + "   <- every seat altogether");
      //Console.WriteLine();

      // ----- Just one row -----------------------------------------------
      //Console.WriteLine("=== The back row (row 3) ===");
      for (int col = 0; col < seats.GetLength(1); col++)
      {
        //Console.WriteLine(seats[3, col]);
      }
      //Console.WriteLine();

      // ----- The same thing with foreach --------------------------------
      // foreach visits every element, but it does NOT give you the index,
      // and it cannot change what is stored. It is the read-only shortcut.
      //Console.WriteLine("=== Everyone, via foreach ===");
      foreach (string name in seats)
      {
       // Console.Write(name + " ");   
      }
      //Console.WriteLine();

      //Console.WriteLine();
      //Console.WriteLine("Press ENTER to close...");
      //Console.ReadLine();
      for (int i = 0; i < 0; i++)
      {
          System.Console.WriteLine(seats[i,3]);
      }
    }
  }

}

//   M1. Print seat column 3 only - that is, the 4th person in every row.
//       (Hint: the loop counts the ROWS this time; the column stays at 3.)




// =========================================================================
// 3. INVESTIGATE - answer these with your partner. Try things out.
//
//   Q1. seats.GetLength(0) gives 4 and seats.GetLength(1) gives 5.
//       Which one is the rows and which is the columns? How can you prove
//       it from the output rather than guessing?
//
//   Q2. Line A prints seats[1, 2]. Which row is that, and which seat?
//       Why is it NOT "the 1st row, 2nd seat"?
//
//   Q3. In the grid printout, SWAP the two for loops over - so the outer
//       loop counts col and the inner loop counts row. (You will need to
//       swap the GetLength values too.) What changes about the output?
//       What does the new version actually show you?
//
//   Q4. Change Line A to seats[4, 0] and run it. What is the error called?
//       Why 4? What is the largest row number you are allowed to use?
//       (Put the 1, 2 back afterwards.)
//
//   Q5. The foreach version prints every name too. What can the indexed
//       for loops do that the foreach version cannot?
//
// =========================================================================

//

//
//   M2. Two students want to swap seats: Hugo and Rosa. Swap them inside
//       the array, then reprint the grid to prove it worked.
//       Careful - you cannot just write one over the other, or you lose a
//       name. You need a temporary variable to hold one of them.
//       (Remember this. You need exactly the same trick for bubble sort.)
//
//   M3. Print the plan with the back row FIRST and the front row last.
//
//   M4. Ask the user for a row and a seat number, then print who sits
//       there. Validate the numbers so the program cannot crash.
// =========================================================================
