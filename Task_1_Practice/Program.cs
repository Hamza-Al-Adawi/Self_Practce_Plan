using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number less than 10: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int x = i;

            // This is a while loop that will continue to execute as long as x is less than 10

            // use x instead of i because i is the input number and
            // x is the variable that will be incremented

            while (x < 10)
            {
                x++; // increment x by 1
                Console.WriteLine(x);
            }
        }
    }
}