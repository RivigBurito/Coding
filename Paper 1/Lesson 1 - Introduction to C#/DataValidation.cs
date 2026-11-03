//Exercise 1: Odd or Even

/*
 int n = -5;
    if ((n % 2) == 0)
{
    Console.WriteLine("n is even");
}
else
{
    Console.WriteLine("n is odd");
}
*/


// TODO: build ONE boolean expression using  &&  ||  and  ==/!=
// Remember precedence - use brackets to be clear.

/*
Console.WriteLine("enter a year");
int year = 0;
year = int.Parse(Console.ReadLine());

if ((year % 4) == 0)
{
    Console.WriteLine("yr is leap");
}
else
{
    Console.WriteLine("yr is not leap");
}
*/

// ============================================================
//  Reads three whole numbers and prints the largest.
//  Watch out: don't start your "biggest so far" at 0 -
//  all three numbers could be negative!
// ------------------------------------------------------------

float a = 2,b =4, c = 3, temp = 0;

if (a < b)
{
    temp = b;
}
else
{
    temp = a;
}
if (c < temp)
{
    Console.WriteLine(temp);
}
else
{
    Console.WriteLine(c);
}



// ============================================================
//  Return EXACTLY one of:  "Equilateral"  "Isosceles"  "Scalene"  "Not a triangle"
//  Rules, in order:
//    1. every side must be a positive number       (else Not a triangle)
//    2. each side must be strictly less than the sum of the other two
//       (use  <  not  <= , or 1,2,3 wrongly counts as a triangle)
//    3. 3 equal -> Equilateral; exactly 2 equal -> Isosceles; else Scalene
// ------------------------------------------------------------