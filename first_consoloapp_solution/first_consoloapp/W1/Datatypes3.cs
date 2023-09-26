using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consoloapp.W1
{
   class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 6;
            unsafe
            {
                int* p1;
                p1 = &num1;

                Console.WriteLine(*p1);
                Console.WriteLine((int)p1);
            }
        }
    }
}
