using System;

namespace ArgsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArgsCount = args.Length;
            if (ArgsCount < 1)
            {
                Console.WriteLine("No parameters.");
            }
            else
            {
                for (int i = 0; i < ArgsCount; i++)
                {
                    Console.WriteLine($"[{i}]: \"{args[i]}\"");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
