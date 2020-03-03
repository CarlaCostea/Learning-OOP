﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClassBook.Tests
{
    public class StudentClassBookTests
    {
        [Fact]
        public void AddStudentInClassBookTest()
        {
            Student student = new Student("Maria");
            StudentsClassBook catalog = new StudentsClassBook();

            catalog.AddStudent(student);

            Assert.True(catalog.VerifyStudentInList("Maria"));
        }

        [Fact]
        public void ReturnPozitionOfStudentInSortedList2Students()
        {
            Student student = new Student("Maria");
            StudentsClassBook catalog = new StudentsClassBook();
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
  
            catalog.AddStudent(student);

            Student student2 = new Student("Ana");
            student2.AddGradeInGrades(new Grade(Subject.English, 7.0));

            catalog.AddStudent(student2);


            Assert.Equal(1, catalog.ReturnPozitionOfStudent("Ana"));
        }

        [Fact]
        public void ReturnPozitionOfStudentInSortedList3Students()
        {
            Student student = new Student("Maria");
            StudentsClassBook catalog = new StudentsClassBook();
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));
            catalog.AddStudent(student);

            Student student2 = new Student("Ana");
            student2.AddGradeInGrades(new Grade(Subject.English, 7.0));
            student2.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student2.AddGradeInGrades(new Grade(Subject.Mathematics, 8.0));
            student2.AddGradeInGrades(new Grade(Subject.Mathematics, 6.0));
            catalog.AddStudent(student2);

            Student student3 = new Student("Paul");
            student3.AddGradeInGrades(new Grade(Subject.English, 10.0));
            student3.AddGradeInGrades(new Grade(Subject.English, 10.0));
            student3.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));
            student3.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));
            catalog.AddStudent(student3);

            Assert.Equal(2, catalog.ReturnPozitionOfStudent("Ana"));
        }
    }
}
