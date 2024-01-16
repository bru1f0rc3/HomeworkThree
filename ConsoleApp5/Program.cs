using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0;
            for(int k = 1; k <= 5; k++)
            {
                for (int d = 1; d <= 4; d++) 
                {
                    for (int c = 1; c <= 3; c++)
                    {
                        answer = Log(k + Pow(d,3) + c);
                    }
                }
            }
            Console.WriteLine($"Ответ: {answer:f2}");
        }
    }
}
