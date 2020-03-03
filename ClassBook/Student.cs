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

        private Grade[] GetGrades()
        {
            return grades;
        }

        public bool VerifyGradetInList(double grade)
        {
            for (int i = 0; i < index; i++)
            {
                if (grades[i].GetGrade() == grade)
                {
                    return true;
                }
            }

            return false;
        }

        public double GeneralGrade(Grade[] grades)
        {
            double sumOfGrades = 0;
            for(int i = 0; i < index; i++)
            {
                sumOfGrades += grades[i].GetGrade();
            }

            return sumOfGrades/index;
        }

        public double GetGeneralGrade()
        {
            return GeneralGrade(GetGrades());
        }
    }
}
