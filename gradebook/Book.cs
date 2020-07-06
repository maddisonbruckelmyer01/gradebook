using System.Collections.Generic;

namespace gradebook
{
    class Book
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades;
    }
}