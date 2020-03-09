using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBook
{
    public enum Subject
    {
        Mathematics,
        Physics,
        Romanian,
        English,
        History
    }
    public class Student
    {
        readonly string studentName;
        readonly Grade[] grades = new Grade[10];
        private int index = 0;

        public Student(string studentName)
        {
            this.studentName = studentName;
        }

        public void AddGradeInGrades(Grade grade)
        {
            grades.SetValue(grade, index);
            index++;
        }

        public double GetGeneralGrades(Subject subject)
        {
            double sumOfGrades = 0;
            double actualSumOfGrades = 0;
            int indexPerSubject = 0;
            for (int i = 0; i < index; i++)
            {
                actualSumOfGrades = sumOfGrades;
                sumOfGrades = grades[i].AddToSum(subject, sumOfGrades);
                if (sumOfGrades != actualSumOfGrades)
                    {
                    indexPerSubject++;
                    }
            }

            return sumOfGrades / indexPerSubject;
        }

        public double GeneralGrade()
        {
            const int numberOfSubjects = 5;
            double sumOfGeneral = GetGeneralGrades(Subject.English) + GetGeneralGrades(Subject.History) + GetGeneralGrades(Subject.Mathematics) + GetGeneralGrades(Subject.Physics) + GetGeneralGrades(Subject.Mathematics);
            return sumOfGeneral/numberOfSubjects;
        }

        internal bool HasName(string name)
        {
            return studentName == name;
        }
    }
}
