using System;

namespace ConsoleApp7
{
     class Test
    {

        public int elem;
        public static bool operator * (Test a, Test b)
        {
            if(a.elem == b.elem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test A = new Test();
            A.elem = 5;
            Test B = new Test();
            B.elem = 5;
            if (A * B)
            {
                Console.WriteLine(" true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }


}
