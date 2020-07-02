﻿using System;
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            grades.Add(56.1);

            var result = 0.0;

            foreach (double number in grades)
            {
                result += number;
            }

            result = result / grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}