using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("Ram and Sita are my parents");
        }
    }

    public class Son : Parent
    {
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son Jenil");
        }
    }
}
