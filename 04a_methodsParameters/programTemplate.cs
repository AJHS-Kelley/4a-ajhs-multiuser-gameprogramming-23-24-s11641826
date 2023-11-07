// Albert Laguerre, Program template, v0.01
// All required examples provided. 
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- name block of code, can be used over and over
        // Example Signature
        // ALL methods have a SIGNATURE that defines their name, parameters, and output.

        static void MyMethod()
        {
            Console.WriteLine("I like mine with lettuce and tomatoes, Heinz 57, french fries potatoes.\n");
        }
        // static -- This method belongs to the current class, it is not an object
        // void -- This method has no return value

        static int DoubleUp():
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n")
            Console.WriteLine("Please enter a number on the next line.\n")
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum); 
            return sum;
        }

        //Methods with Parameters
        static void makePancakes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered" + num + "eggs cooked" + style + ".\n")
        }

        //Named Arguments
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + "hamburgers.\n")
        }

        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is " + child3);
        }

        //METHOD OVERLOADING
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("sum: " + sum); 
            return sum;
        }
        
        // Find Sum of Double
        static int FindSum(double x, double y)
        {
            int sum = x + y;
            Console.WriteLine("sum: " + sum); 
            return sum;
        }

        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //makePancakes(10);
            //MakeEggs(10, "sunny side up");
            //MakeBurger();
            //MakeBurger(10);
            //AllMyChildren(child3: "Steve", child2: "Susan", child1: "Chewbacca");
            FindSum(1, 5); // TWO INTEGERS
            FindSum(9.5, 2.4); // TWO DOUBLES
            FindSum(5, 2.5) // ONE OF EACH

            float = 1.9999999999
            double = 1.9999999999999999999999
        }
    }
    
   
    

    
}