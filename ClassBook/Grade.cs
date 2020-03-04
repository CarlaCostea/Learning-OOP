using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBook
{
    public class Grade
    {
        private double grade;
        public Subject subject;

        public Grade(Subject subject, double grade)
        {
            this.grade = grade;
            this.subject = subject;
        }

        internal double AddToSum(double sumOfGrades)
        {
            return sumOfGrades + grade;
        }
    }
}
