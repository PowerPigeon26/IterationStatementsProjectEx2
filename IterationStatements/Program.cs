using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                
            var numbers = new List<int>();

            int num = 0;

            do
            {
                num++;

                numbers.Add(num);

            } while (num < 100);
            
            while (num < 200)
            {
                num++;
                
                numbers.Add(num);
            }

            foreach(int i in numbers)
            {
                Console.WriteLine($"Increase: {i}");
            }
            
            Console.WriteLine("");
            for (int i = 199; i <= numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"Decrease: {numbers[i]}");
            }
        }
    }
}
