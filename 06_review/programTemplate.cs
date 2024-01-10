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

        }
    }
}