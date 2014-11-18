using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracklePop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i%15 == 0)
                {
                    Console.WriteLine("CracklePop");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("Crackle");
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("Pop");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
