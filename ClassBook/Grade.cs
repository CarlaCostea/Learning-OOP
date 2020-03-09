using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBook
{
    public class Grade
    {
        private double grade;
        private Subject subject;

        public Grade(Subject subject, double grade)
        {
            this.grade = grade;
            this.subject = subject;
        }

        internal double AddToSum(Subject requiredSubject, double sumOfGrades)
        {
            return sumOfGrades + (requiredSubject == subject
                    ? grade
                    : 0);
        }
    }
}
