// ============================================================
//  INDEPENDENT TASK A  -  The Subroutine Calculator
//  A-Level Computer Science (AQA 7517)  -  Hills Road SFC
// ============================================================
// This program ALREADY RUNS. Press Run and you will see a menu.
// Your job is to complete each SUBROUTINE marked "TODO".
// Work top to bottom. Run after every change and test as you go.
//
// A SUBROUTINE is a named block of code that does one job:
//   * a FUNCTION returns a value      (e.g. Add returns an double)
//   * a PROCEDURE does something but returns nothing (void)
//
// You saw exactly this idea in the Morse code program:
//   Decode(...) is a FUNCTION;   DisplayMenu() is a PROCEDURE.

using System;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace SubroutineCalculator
{
    class Program
    {
        // ---- INPUT SUBROUTINE (a function: returns an double) ----
        static double GetNumber(double a, double b)
        {
            Console.WriteLine("enter number 1");
            Console.ReadLine;
            Console.WriteLine("enter number 1");
            Console.ReadLine;

        }

        // ---- ARITHMETIC SUBROUTINES (functions) ----
        static double Add(double a, double b,double result)
        {
            result = a + b;
            return result;
        }

        static double Subtract(double a, double b,double result)
        {
            result = a - b;
            return result;
        }

        static double Multiply(double a, double b,double result)
        {
            result = a * b;
            return result;
        }

        static double Divide(double a, double b,double result)
        {
            result = a / b;
            return result;
        }

        // ---- OUTPUT SUBROUTINE (a procedure: returns nothing) ----
        static void DisplayResult(string label, double value)
        {
            Console.WriteLine("the result is ", result);
        }

        // ---- MENU (already written for you - read it carefully) ----
        static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Calculator Menu");
            Console.WriteLine("===============");
            Console.WriteLine("A - Add");
            Console.WriteLine("S - Subtract");
            Console.WriteLine("M - Multiply");
            Console.WriteLine("D - Divide");
            Console.WriteLine("X - Exit");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool finished = false;
            while (!finished)
            {
                DisplayMenu();
                GetNumber(a, b);
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "X")
                {
                    finished = true;
                }
                else if (choice == "A")
                {
                    reusult = Add(a, b);
                }
                else if (choice == "S")
                {
                    Subtract(a, b);
                }
                else if (choice == "M")
                {
                    Multiply(a, b);
                }
                else if (choice == "D")
                {
                    Divide(a, b);
                }
                else;
            {
                Console.WriteLine("Unknown option - please try again.");
            }
        }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
