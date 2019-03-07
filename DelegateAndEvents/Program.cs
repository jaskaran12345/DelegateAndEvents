//Anmolpreet Singh
//c076606
//Jaskaran Singh
//c0731667
//CSD3354 Section 2
//Assignment 2
//March 6, 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anmol
{
    using System;
    delegate void ExampleDelegte(string xyz);
    class Program
    {
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + " Method1");
        }
        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }



        public static void Main()
        {
            ExampleDelegte ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;
            ex1Delegate = new ExampleDelegte(Method1);
            ex2Delegate = new ExampleDelegte(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            ex2Delegate("AAA");
            ex3Delegate("CCC");
            myDelegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            myDelegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            myDelegate("FFF");
            Console.ReadLine();
        }

    }
}
