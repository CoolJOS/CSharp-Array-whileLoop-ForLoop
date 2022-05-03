using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begynder
{
    class Program
    {
        static void Main() //(string[] args)
        {
            int number1 = 1;
            while (number1 <= 10)
            {
                //Console.WriteLine(number1);
                   
                            //BEMÆRK det ekstra 7 tal i numbers for at få den til at skrive det 7 tal i rækken skal koden ændres til den kode der er udnoteret
                    int[] numbers = { 1, 2, 3, 4, 7, 6, 7, 8, 9, 10 };

                    for (int i = 1; i <= numbers.Length; i++)
                    //for (int i = 0; i < numbers.Length; i++ )
                    {
                    Console.Write(i + " ");
                    //Console.Write(numbers[i] + " ");
                    }
             Console.Write("\n");
             number1++;
            }

            Console.ReadKey();

            //int number2 = 1;
            //while (number2 <= 10)
            //{                           
            //   
            //   Console.WriteLine(number2);
            //    number2++;
            //}                         
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
                                  
        }
    }
}
