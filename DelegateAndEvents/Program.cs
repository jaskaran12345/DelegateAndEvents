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
    public class DelegateExercises
    {
        public delegate void MyDelegate();


        void Method1()
        {

            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
namespace anmol
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO DO: Call Method2 from the DelegateExercises Class
        }
    }
}