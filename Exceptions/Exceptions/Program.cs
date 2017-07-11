using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First line of the program");
            try
            {
                var x = 0;
                var y = 12 / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("After the division");
            }
        }
    }
}
