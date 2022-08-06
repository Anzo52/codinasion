// Write a programme to divide two numbers
using System;

public class DivideTwoNumbers
{
    public static void Main()
    {
        Console.Write("Enter two numbers : ");
        string[] numbers = Console.ReadLine().Split(" ");
        float num1 = float.Parse(numbers[0]);
        float num2 = float.Parse(numbers[1]);
        float result = 0;
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Can't divide by 0");
        }
        Console.WriteLine($"\nResult : {result}");
    }
}
