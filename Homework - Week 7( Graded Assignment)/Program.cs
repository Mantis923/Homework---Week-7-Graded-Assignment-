using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork7Week7
{
    ///HomeWork7Week7
    /// File Name: Homework - Week 7( Graded Assignment)
    /// Student: Samuel Peppetta
    /// Miracosta college fall 2021
    /// Professor Mark Akola
    class Program
    {
        ///This is a defined class called Counter whose objects count things.
        ///An object of this class records a count that is a nonnegative integer.
        ///Included are  methods to set the counter to 0, to increase the count by 1, and 
        ///to decrease the count by 1. No method allows the value of the 
        ///counter to become negative.Included is a getter method that returns the current count 
        ///value and a method that outputs the count to the screen.There's no input method 
        ///or other setter methods.  The only method that can set the counter is the one that sets it to 0.  
        ///Included is a ToString methods and a Equals method. A driver program  includes a menu to
        ///interactively test each method in the program. A menu should have an option that
        ///test each method and operates on 1 object for example you should be able to select the increment 
        ///method which would increment your Counter.

        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Console.Write("The value is : ");
            c1.OutputCountToScreen();
            c1.addOneToCount();
            Console.WriteLine(" The counter val is: " + c1.ToString());
            c1.setCounterToZero();
            Console.WriteLine(" The counter val is: " + c1.ToString());

            c1.subtractOnceFromCounter();
            Console.WriteLine(" making count not be negative " + c1.ToString());

            Boolean equalityTest = c1.equals(c2);

            if (equalityTest)
            {
                Console.Write(" they are both equal");
            }
            else
                Console.Write("Both are not equal");
            Console.ReadLine();
        }
    }
}
