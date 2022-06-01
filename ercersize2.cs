using System;

namespace excersizeee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int answer;
            int remainder;

            a = 17;
            b = 4;

            answer = a / b;
            remainder = a % b;

            Console.WriteLine($"{a} / {b} is {answer} remainder {remainder}");

            Console.WriteLine("whats the radius of your circle");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a  circle with a radius of  {radius} is {Math.Round(area)}.");

        }
        //define a method that forms some sort of functionality
        //that can be used over and over again
        //public static AreaOfCircle(double radius)
        //{

        //}

        //this is the scope of the method
    }
}
