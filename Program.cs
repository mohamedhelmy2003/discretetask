using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
           
            for (var i = 2; i <= 100; i++)
            {
                bool isprimenumber = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { 
                        isprimenumber = false; break;

                    }
                }
                if (isprimenumber)
                {
                    Console.WriteLine(i +"- ");
                }
            }
        }
    }
}
