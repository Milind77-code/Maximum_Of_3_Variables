﻿using System;

namespace MaximumOfThreeVariables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----Welcome to Maximum Of 3 Variables----");
            MaxNumber max = new MaxNumber();
            int maxNumber = max.MaxInteger(10, 8, 9);
            Console.WriteLine(maxNumber + " is maximum");

            int maxNumberTwo = max.MaxInteger(540, 692, 436);
            Console.WriteLine(maxNumberTwo + " is maximum");

            int maxNumberThree = max.MaxInteger(540, 692, 911);
            Console.WriteLine(maxNumberThree + " is maximum");

            float floatMaxOne = max.MaxFloat(35.1f, 22.4f, 31.9f);
            Console.WriteLine(floatMaxOne + " is maximum");

            float floatMaxTwo = max.MaxFloat(22.4f, 35.1f, 31.9f);
            Console.WriteLine(floatMaxTwo + " is maximum");

            float floatMaxThree = max.MaxFloat(31.9f, 22.4f, 35.1f);
            Console.WriteLine(floatMaxThree + " is maximum");

            string stringMaxOne = max.Maxstring("Peach", "Apple", "Banana");
            Console.WriteLine(stringMaxOne + " is maximum");

            string stringMaxTwo = max.Maxstring("Apple", "Peach", "Banana");
            Console.WriteLine(stringMaxTwo + " is maximum");

            string stringMaxThree = max.Maxstring("Banana", "Apple", "Peach");
            Console.WriteLine(stringMaxThree + " is maximum");
        }
    }
}
