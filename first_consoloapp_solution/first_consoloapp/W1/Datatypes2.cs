using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first_consoloapp.W1
{

    class Person
    {
        int pid;
        string name;
        public Person(int pid, string name)
        {
            this.pid = pid;
            this.name = name;
        }

        override
        public string ToString()
        {
            return (this.pid + ", " + this.name);
        }
    }

    interface Inf1
    {
        void f1();
    }

    class Class1 : Inf1
    {
        //implements Inf1
        public void f1()
        {
            Console.WriteLine("Hello from f1 of Class1");
        }
    }


    class Class2 : Inf1
    {
        //implements Inf1
        public void f1()
        {
            Console.WriteLine("Hello from f1 of Class2");
        }
    }

    delegate int DelegateFunction(int x, int y);
    internal class DelegateTest
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Prd(int x, int y)
        {
            return x + y;
        }
    }

    public class OldStudent
    {
        public int sid;
        public string name;

        public OldStudent(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
    }

    public record class NewStudent
    {
        public int sid { get; set; } = default;

        public string name { get; set; } = default;
    }


    /*class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, I am under the water";
            Console.WriteLine(str1);

            String str2 = "Please save me";

            Object obj1 = new Object();
            obj1 = new Object();
            obj1 = str1;

            Person p1;
            p1 = new Person(1, "PDSN");
            Console.WriteLine(p1);


            Class1 obj2 = new Class1();
            Class2 obj3 = new Class2();
            obj2.f1();
            obj3.f1();
            new Class2().f1();
            new Class1().f1();

            DelegateFunction df1 = new DelegateTest().Sum;
            int result = df1(8, 7);
            Console.WriteLine(result);
            df1 = new DelegateTest().Prd;
            result = df1(2, 3);
            Console.WriteLine(result);

            OldStudent s01 = new OldStudent(1, "Prabin");
            OldStudent s02 = new OldStudent(1, "Prabin");
            bool res = (s01 == s02);
            Console.WriteLine(res);

            var s3 = new NewStudent
            {
                sid = 2,
                name = "KRSL"
            };
            var s4 = new NewStudent { sid = 2, name = "KRSL" };
            res = (s3 == s4);
            Console.WriteLine(res);


        }
    }*/
}
