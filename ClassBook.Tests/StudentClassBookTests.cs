using System;
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
    }
}
