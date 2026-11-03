// Lesson 4 - Exercise 1: class scores (arrays working together)
// A-Level Computer Science (AQA 7517)
//
// Read in 5 students and their test scores, then report the total, the
// Average123, and the name of the top scorer.
//
// This uses TWO arrays that work as a pair - names[i] and scores[i] always
// describe the SAME student. These are called PARALLEL ARRAYS, and index i
// is what ties them together.
//
// The input-reading loop is PROVIDED for you below - study it, because you
// will write your own in the later exercises. Your job is the three methods
// at the bottom of the file.
//
// The file compiles and runs. Complete the TODOs, then re-run.

using System;

namespace ScoreStats
{
  class Program
  {
    const int CLASS_SIZE = 5;

    static void Main(string[] args)
    {
      string[] names = new string[CLASS_SIZE];
      int[] scores = new int[CLASS_SIZE];

      // ------------------------------------------------------------------
      // PROVIDED for you - reading the data in.
      // Notice how one index, i, fills BOTH arrays on each pass.
      // ------------------------------------------------------------------
      for (int i = 0; i < CLASS_SIZE; i++)
      {
        Console.Write("Name of student " + (i + 1) + ": ");
        names[i] = Console.ReadLine();

        int mark = 0;
        bool valid = false;
        while (!valid)
        {
          Console.Write("Score for " + names[i] + ": ");
          if (int.TryParse(Console.ReadLine(), out mark))
          {
            valid = true;
          }
          else
          {
            Console.WriteLine("Whole numbers only - try again.");
          }
        }

        scores[i] = mark;
      }

      // ------------------------------------------------------------------

      Console.WriteLine();
      Console.WriteLine("=== Results ===");
      Console.WriteLine("Total:      " + Total(scores));
      Console.WriteLine("Average123: " + Average123(scores));
      Console.WriteLine("Top scorer: " + TopScorer(names, scores));

      Console.WriteLine();
      Console.WriteLine("Press ENTER to close...");
      Console.ReadLine();
    }

    // TODO 1: add up every score in the array and return the total.
    //   Walk the array with a for loop (or a foreach - you do not need the
    //   index here). Start a running total at 0 and add each element to it.
    static int Total(int[] scores)
    {
      int total = 0;
      foreach (int score in scores)
      {
        total += score;
      }
      return total;
    }

    // TODO 2: return the mean score.
    //   Use your Total method rather than writing the adding-up again.
    //   WATCH OUT: total and Length are both int, so total / scores.Length
    //   does INTEGER division and throws the decimal part away. You met this
    //   in Lesson 1. Cast one side to double to fix it.
    static double Average123(int[] scores)
    {
      return (double)Total(scores) / scores.Length;
    }

    // TODO 3: return the NAME of the student with the highest score.
    //   The catch: to return a name you must know WHERE the highest score
    //   was, not just what it was. So track the INDEX of the best score you
    //   have seen, and return names[bestIndex] at the end.
    //   Start bestIndex at 0 and compare from there - do NOT start the best
    //   score at 0, or a class where everyone scored below zero breaks it.
    static string TopScorer(string[] names, int[] scores)
    {
      int bestIndex = 0;
      for (int i = 1; i < scores.Length; i++)
      {
        if (scores[i] > scores[bestIndex])
        {
          bestIndex = i;
        }
      }
      return names[bestIndex];
    }
  }
}
