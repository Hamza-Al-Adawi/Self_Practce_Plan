namespace Task1._3_C__Fundementals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This task will mainly focus on loops for, while ,do while ,nested loops");
            Console.WriteLine("Enter first Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // FOR LOOP - Count from x to y
            Console.WriteLine("\n--- FOR LOOP ---");
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine($"For Loop: {i}");
            }

            // WHILE LOOP - Repeat while x is less than y
            Console.WriteLine("\n--- WHILE LOOP ---");
            int count = x;
            while (count <= y)
            {
                Console.WriteLine($"While Loop: {count}");
                count++;
            }

            // DO-WHILE LOOP - Execute first, then check condition
            Console.WriteLine("\n--- DO-WHILE LOOP ---");
            int doCount = x;
            do
            {
                Console.WriteLine($"Do-While Loop: {doCount}");
                doCount++;
            } while (doCount <= y);

            // NESTED LOOPS - Loop inside loop
            Console.WriteLine("\n--- NESTED LOOPS ---");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write($"({i},{j}) ");
                }
                Console.WriteLine();
            }
        }
    }
}

