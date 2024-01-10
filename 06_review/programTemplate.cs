// Albert Laguerre, Program Template, v0.01
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {

            int myInt = 5;
            // Integer = 4 Bytes

            float myFloat = 3.14F;
            //Float = 4 Bytes

            bool myBool = true;
            // Boolean = 1 Byte

            string myString = "We run the north!"
            //String = 2-Bytes

            long myLong = 1952565741852;
            // Long = 8 bytes

            double myDouble = 9.154165425415D;
            // Double = 8 Bytes

            char myChar = 'C'
            // 2-Bytes

            // Type Casting -- changing one data type to another.
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double
            
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            // EXPLICIT -- Must be done manually when going larger -> smaller.
            // double -> float -> long -> int -> char
            double exampleDouble = 9.7564252451D;
            int myInt = (int) myDouble;

            // Conversion Methods
            Convert.ToString() // String
            Convert.ToDouble() // Double
            Convert.ToInt32() // Integer
            Convert.ToInt64() // Long 

            // Switch Statement
            int dayofWeek = 6;
            switch (dayofWeek)
            {
                case 1:
                    Console.WriteLine("The day is Saturday.\n")
                    break;
                case 2:
                    Console.WriteLine("The day is Sunday.\n")
                    break;
                case 3:
                    Console.WriteLine("The day is Monday.\n")
                    break;
                case 4:
                    Console.WriteLine("The day is Tuesday.\n")
                    break;
                case 5:
                    Console.WriteLine("The day is Wednesday.\n")
                    break;
                case 6:
                    Console.WriteLine("The day is Thursday.\n")
                    break;
                case 7:
                    Console.WriteLine("The day is Friday.\n")
                    break;
                default:
                    Console.WriteLine("No match found.\n");
                    break;
            }


        }
    }
}