using System;

namespace HomeworkFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: write code to ask for input array of numbers, then which number we want to find
            // and then output first and last occurrences into console

            Console.WriteLine("How long you want your array to be?");
            int a = 0;
            int b = 0;
            a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];

            int count = 0;
            int x = 0;

            while (count < a)
            {
                Console.WriteLine("Introduce number");
                x = Convert.ToInt32(Console.ReadLine());
                array[count] = x;
                count = count + 1;
            }
            Console.WriteLine("Please enter the number you want to find");

            b = Convert.ToInt32(Console.ReadLine());

            LastIntegerIndex(array, a, b);
            FirstIntegerIndex(array, a, b);
            Console.ReadLine();
        }

        // TODO : Find index of first occurrence in integer array. Solve using loop of your choice.


        public static int LastIntegerIndex(int[] items, int smth, int numberToFind)
        {
            // TODO: Delete following line before implementing.
            int n2 = 0;
            int[] array = new int[smth];
            while (n2 < smth)
            {
                if (array[n2] == numberToFind)
                {
                    n2 = n2 + 1;
                }
                else
                {
                    Console.WriteLine("Last ocurrence is" + n2);
                }
            }
        }
    


        // TODO : Find index of last occurrence in given array. Solve using loop of your choice.
              

        public static int FirstIntegerIndex(int[] items, int smth1, int numberToFind)
        {
            // TODO: Delete following line before implementing.
            int n1 = 0;
            int[] array = new int[smth1];

            if (array[n1] == numberToFind)
            {
                Console.WriteLine("First ocurrence is" + n1);            
            }
            else
            {
                n1 = n1 + 1;
            }
        }
    }
}