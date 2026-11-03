Console.WriteLine("Enter the first number:");
var firstNumber = Console.ReadLine();

Console.WriteLine("Enter the second number:");
var secondNumber = Console.ReadLine();

Console.WriteLine("Enter the operation (+, -, *, /):");
var operation = Console.ReadLine();

float Calculate(string firstNumber, string secondNumber, string operation)
{
    float num1 = float.Parse(firstNumber);
    float num2 = float.Parse(secondNumber);


    if (operation == "+")
            return num1 + num2;
    if (operation == "-")
            return num1 - num2;
    if (operation == "*")
            return num1 * num2;
    if (operation == "/")
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        default;
            throw new InvalidOperationException("Invalid operation.");
}

Console.WriteLine("The result is:");
Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is: {Calculate(firstNumber, secondNumber, operation)}");


