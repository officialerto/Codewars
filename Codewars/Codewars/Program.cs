﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class Kata
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine(string.Join(", ", CountBy(2, 5)));

            Console.ReadLine();
        }

        // -------------------- QUESTION 1 -------------------- 

        //Create a function with two arguments that will return an array of the first n multiples of x.
        //Assume both the given number and the number of times to count will be positive numbers greater than 0.
        //Return the results as an array or list(depending on language).

        //countBy(1, 10)  should return  { 1,2,3,4,5,6,7,8,9,10}
        //countBy(2, 5)   should return  { 2,4,6,8,10}

        // -------------------- ANSWER 1 -------------------- 

        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];

            for (int i = 0; i < n; i++)
            {
                z[i] = (i + 1) * x;
            }

            return z;
        }


    }
}

