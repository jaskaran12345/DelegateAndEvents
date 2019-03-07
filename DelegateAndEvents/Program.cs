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
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();
        int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }

        int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }

        public void Method4(MyDelegate myDelegate)
        {
            int result = myDelegate(10);
            Console.WriteLine(result);
        }
       
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}
