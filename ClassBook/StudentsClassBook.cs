using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBook
{
    public class StudentsClassBook
    {
        private Student[] students = new Student[10];
        private int index = 0;

        public void AddStudent(Student student)
        {
            students.SetValue(student, index);
            index++;
        }

        public bool VerifyStudentInList(string name)
        {
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].GetName() == name)
                {
                    return true;
                }
            }

            return false;
        }

        private void QuickSort(Student[] students, int start, int end)
        {
            int i;
            if (start >= end)
            {
                return;
            }

            i = Partition(students, start, end);

            QuickSort(students, start, i - 1);
            QuickSort(students, i + 1, end);
        }

        private int Partition(Student[] students, int start, int end)
        {
            Student temp;
            double p = students[end].GetGeneralGrade();
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (students[j].GetGeneralGrade() > p)
                {
                    i++;
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }

            temp = students[i + 1];
            students[i + 1] = students[end];
            students[end] = temp;
            return i + 1;
        }

        public int ReturnPozitionOfStudent(string name)
        {
            QuickSort(students, 0, index - 1);
            for ( int i = 0; i < index; i++)
            {
                if(students[i].GetName() == name)
                {
                    return i;
                }
            }

            return 0;
        }

    }
}
