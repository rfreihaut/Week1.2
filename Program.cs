using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" I am a room calculator");

            Console.WriteLine("Please enter a number for height");
            double height = CheckIsNumber(Console.ReadLine());


            Console.WriteLine("Please enter a number for length");
            double length = CheckIsNumber(Console.ReadLine());


            Console.WriteLine("Please enter a number for width");
            double width = CheckIsNumber(Console.ReadLine());

            Console.WriteLine("The volume of the room is");
            Console.WriteLine(DoMath(height, length, width));

            Console.ReadLine();


         }

        public static double CheckIsNumber(string stringToCheck)
        {

            bool isNumber  =  double.TryParse(stringToCheck, out double goodNumber);

            if (!isNumber)

            { Console.WriteLine("That is not a number");
                return 0;
            }

            else
            {
                return goodNumber;
            }

            Console.ReadLine();
        }


        public static double DoMath(double height, double length, double width)


        {
            return height * length * width;

        }

    }
}
