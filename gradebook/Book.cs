using System.Collections.Generic;
using System;
using System.Net.NetworkInformation;

namespace gradebook
{
    public class Book
    {

        public Book(string name) 
         {
            grades = new List<double>();

            this.name = name; 
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();

            result.Average = 0.0;

            result.High = double.MinValue;

            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);

                result.High = Math.Max(grade, result.High);
             
                result.Average += grade;
            }

            result.Average /= grades.Count;
        }

        private List<double> grades;
        private string name;
    }
}