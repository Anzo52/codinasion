// Write a programme to convert degree to radian
using System;

public class RadToDeg
{
    public static void Main(string[] args)
    {
        //Checking for valid input
        bool success = false;
        do
        {
            Console.Write("Input radians : ");
            try
            {
                RadianToDegree(Convert.ToDouble(Console.ReadLine()));
                success = true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid Input!!");
            }
        }
        while (!success);
    }

    public static void RadianToDegree(double radians)
    {
        double degrees = (180 / Math.PI) * radians;
        Console
            .WriteLine($"\n{radians} Radians is {Math.Round(degrees, 5)} Degrees.");
    }
}
