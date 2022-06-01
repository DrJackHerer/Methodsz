using System;

namespace MethodDemo
{
     class Program
    {
        //definition
       

        public static int Add(int x, int y)
        {
            return x + y;
        } 
        static void Main(string[] args)
        {
            //Method call
            Console.WriteLine (Program.Add(4,8));
        }
        public static void subtract(int x, int  y)
        {
            var answer = x- y;
            Console.Write(answer);
        }
    }
}
