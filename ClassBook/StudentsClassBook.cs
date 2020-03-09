using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBook
{
    public class StudentsClassBook
    {
        private readonly Student[] students = new Student[10];
        private int index = 0;

        public void AddStudent(Student student)
        {
            students.SetValue(student, index);
            index++;
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
            double p = students[end].GeneralGrade();
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (students[j].GeneralGrade() > p)
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

        public int StudentPosition(string name)
        {
            QuickSort(students, 0, index - 1);
            for ( int i = 0; i < index; i++)
            {
                if(students[i].HasName(name))
                {
                    return i+1;
                }
            }

            return 0;
        }

        public Student StudentAtPosition(int position)
        {
            if (position > index  || position < 1)
            {
                return null;
            }

            QuickSort(students, 0, index - 1);
            return students[position - 1];
        }

    }
}
