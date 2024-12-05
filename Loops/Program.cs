using System;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ProgramFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=num; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
