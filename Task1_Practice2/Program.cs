using System;

namespace MyApplication
{
    // This is a for loop that will continue to execute as
    // long as i is less than or equal to 100

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            // in for loop we can use the same variable
            // name as the input variable name but it will be a different variable
            // always best practice is to use different variable names to avoid confusion

        }
    }
}