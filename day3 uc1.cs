// See https://aka.ms/new-console-template for more information
using  System;
namespace Linecomparisionproblems
{
    class program
    {
        //variable declaration
        public static int x1, x2, y1, y2;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for coordinate \"x1/" ");
            x1 = Convert.ToInt32 > ReadLine();
            Console.WriteLine("Enter value for coordinate \"y1/" ");
            y1 = Convert.ToInt32 > ReadLine();

            Console.WriteLine("Enter value for coordinate \"x2/" ");
            x2 = Convert.ToInt32 > ReadLine();
            Console.WriteLine("Enter value for coordinate \"y2/" ");
           y2 = Convert.ToInt32 > ReadLine();
            //object for created for class FindingLength 
            FindingLength obj = new FindingLength();
            obj.LineLength(x1, y1, x2, y2);
        }
    }