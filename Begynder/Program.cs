//Beginner lesson C#.
//Make a matrix with the numbers 1 to 10 on top of each other 10 times
//Using an Array, a "while-loop" and a "for-loop".

using System;

namespace Begynder
{
    class Program
    {
        static void Main()
        {
            int number1 = 0;
            while (number1 < 10)
            {
                    //REMARK! The Array is merely used as a counter. It can be numbers or strings, it doesn't matter.)            
                int[] numbers = {0,1,2,3,4,7,6,7,8,9};
                //string[] cars = { "Saab", "Volvo", "BMW", "Ford", "Toyota", "VW", "Hyundai", "Morris", "Jaguar", "Skoda" };

                for (int i = 1; i <= numbers.Length; i++)
                //for (int i = 0; i < numbers.Length; i++ )
                {
                    Console.Write(i + " ");

                    //REMARK! Just code to demo print of the arrays.
                //Console.Write(cars[number1] + " ");
                //Console.Write(numbers[number1] + " ");
                }
             Console.Write("\n");
             number1++;
            }

                //REMARK! This line is only to stop the code from continuing before a key is pressed.
            Console.ReadKey();
        }
    }
}
