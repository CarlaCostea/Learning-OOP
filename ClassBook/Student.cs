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
        private string studentName;
        private Grade[] grades = new Grade[10];
        private int index = 0;

        public Student(string studentName)
        {
            this.studentName = studentName;
        }

        public string GetName()
        {
            return studentName;
        }

        public void AddGradeInGrades(Grade grade)
        {
            grades.SetValue(grade, index);
            index++;
        }

        public double GetGeneralGrades(Subject subject)
        {
            double sumOfGrades = 0;
            int indexPerSubject = 0;
            for (int i = 0; i < index; i++)
            {
                if (grades[i].subject == subject)
                {
                    sumOfGrades = grades[i].AddToSum(sumOfGrades);
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

    }
}
