using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < 10; i++)
            {
                int next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
            }

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }

            string password = "qwerty";
            string? input;
            do
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();
            }
            while (input != password);
            Console.WriteLine("Access granted!");
        }
    }
}
