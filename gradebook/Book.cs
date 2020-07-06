using System.Collections.Generic;
using System;


namespace gradebook
{
    class Book
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

        public void ShowStatistics()
        {
            var result = 0.0;

            var highGrade = double.MinValue;

            var lowGrade = double.MaxValue;

            foreach (double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                // if (number > highGrade) {
                //   highGrade = number;
                //  }
                result += number;
            }

            result = result / grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The higest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        private List<double> grades;
        private string name;
    }
}