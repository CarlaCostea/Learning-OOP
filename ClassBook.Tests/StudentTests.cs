using System;
using Xunit;

namespace ClassBook.Tests
{
    public class StudentTests
    {
        [Fact]
        public void GradeInListOfGrades()
        {
            Student student = new Student("ANA");
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));

            Assert.True(student.VerifyGradetInList(9.0));       
        }

        [Fact]
        public void GeneralGradeTest()
        {
            Student student = new Student("ANA");
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));

            Assert.Equal(9.0, student.GetGeneralGrade());
        }


    }
}
