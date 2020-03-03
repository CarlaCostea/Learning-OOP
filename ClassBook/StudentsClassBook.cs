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
    }
}
