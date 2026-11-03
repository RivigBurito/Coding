// Lesson 3 - Guided build: Dice roller (loops + Random)
// A-Level Computer Science (AQA 7517)
//
// This is the exercise you discussed before the break. We build it together
// after learning the Random syntax. It has TWO parts:
//   Part 1 - keep rolling until you get a six   (a do...while loop)
//   Part 2 - roll 20 times and count the sixes  (a for loop)
//
// The file already compiles and runs. Complete each TODO in order and
// re-run after every change.

using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            // One Random object for the whole program.
            // (Never create a new Random() object inside a loop.)
            Random rng = new Random();

            Console.WriteLine("=== Part 1: roll until you get a six ===");

            int roll = 0;
            int rollCount = 0;

            // A single example roll
            //roll = rng.Next(1, 7);   // Next(1, 7) gives 1..6  (7 is EXCLUSIVE)
            //Console.WriteLine("You rolled a " + roll);

            // TODO 1: Turn the single roll above into a do...while loop.
            //   - roll the die
            //   - print the roll
            //   - add 1 to rollCount
            //   Keep going WHILE the roll is not a six.
            //   Why do...while and not while? Because you always roll at least once.
            // TODO 2: After the loop, print how many rolls it took (rollCount).

            do
            {


                roll = rng.Next(1, 7);
                Console.WriteLine(roll);
                rollCount++;
            } while (roll != 6);
            Console.WriteLine($"it took {rollCount} rolls to role a 6");


            Console.WriteLine();
            Console.WriteLine("=== Part 2: 20 rolls, count the sixes ===");

            int sixes = 0;

            // TODO 3: Write a for loop that runs 20 times.
            //   Each time: roll the die, and if it is a six, add 1 to sixes.
            //   (This is where you combine a loop with an if statement.)

            // TODO 4: After the loop, print how many sixes came up out of 20.

            for (int i = 0; i < 20; i++)
            {
                
                roll = rng.Next(1, 7);
                if (roll == 6)
                {
                    sixes = sixes + 1;
                }


            }

            Console.WriteLine(sixes);
            Console.WriteLine("Press ENTER to close...");
            Console.ReadLine();
        }
    }
}
