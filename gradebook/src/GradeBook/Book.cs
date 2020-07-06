using System.Collections.Generic;
using System;
using System.Net.NetworkInformation;

namespace GradeBook
{
    public class Book
    {

        public Book(string name) 
         {
            grades = new List<double>();

            Name = name; 
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0) 
            {
                 grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();

            result.Average = 0.0;

            result.High = double.MinValue;

            result.Low = double.MaxValue;

            //foreach loop
           /* foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);

                result.High = Math.Max(grade, result.High);
             
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result; */


            //do while loop
           /* var index = 0;
             do
            {
                result.Low = Math.Min(grades[index], result.Low);

                result.High = Math.Max(grades[index], result.High);
             
                result.Average += grades[index];

                index += 1; 
            } while(index < grades.Count); 

            result.Average /= grades.Count;

            return result; */


            //while loop
             /*  var index = 0;
             while(index < grades.Count);
            {
                result.Low = Math.Min(grades[index], result.Low);

                result.High = Math.Max(grades[index], result.High);
             
                result.Average += grades[index];

                index += 1; 
            } 

            result.Average /= grades.Count;

            return result; */


            //for loop
             for(var index = 0; index < grades.Count; index +=1)
            {

                result.Low = Math.Min(grades[index], result.Low);

                result.High = Math.Max(grades[index], result.High);
             
                result.Average += grades[index];
            } 

            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}