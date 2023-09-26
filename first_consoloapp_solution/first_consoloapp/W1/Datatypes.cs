/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consoloapp.W1
{
    internal class Datatypes { }
    internal class Program
    {
        enum Days { SUN, MON, TUE };

        struct Student
        {
            public int sid;
            public string name;
        };

        static void Main(string[] args)
        {
            bool b;
            char ch;
            byte b1;
            sbyte b2;// un-signed
            short s1;// signed
            ushort s2;
            int i1;
            uint i2;
            long l1;
            ulong l2;
            float f1;
            double d1;
            decimal d2;

            // user defined basic type
            Days day1 = Days.SUN;
            day1 = Days.MON;
            Console.WriteLine(day1);
            day1 = Days.TUE;
            Console.WriteLine(day1);

            Student stu1;
            stu1.sid = 1;
            stu1.name = "KRSL";
            Console.WriteLine(stu1.sid +
                 ", " + stu1.name);

        }

    }
}
*/