using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float score= 0;
            float c= EvaluateDartThrow();
            if (c<=1)
            {
                score += 10; 
            }
            else if (c>1 && c<=5)
            {
                score += 5;
            }
            else if (c > 5 && c <= 10)
            {
                score += 1;
            }
            else if (c > 10)
            {
                score += 0;
            }
            Console.WriteLine("tvoje score je "+score);
            Console.ReadLine();
        }

        static public float EvaluateDartThrow()
        {
            Console.WriteLine("zadaj 1. bod");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("zadaj 2. bod");
            float y = float.Parse(Console.ReadLine());
            float distance = (float)Math.Sqrt((x * x) + (y * y));
            return distance;
        }
    }
}
