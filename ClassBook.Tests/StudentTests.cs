using System;
using Xunit;

namespace ClassBook.Tests
{
    public class StudentTests
    {

        [Fact]
        public void GetGeneralGradeForOneSubject()
        {
            Student student = new Student("ANA");

            student.AddGradeInGrades(new Grade(Subject.Mathematics, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));

            Assert.Equal(9.0, student.GetGeneralGrades(Subject.Mathematics));
        }

        [Fact]
        public void GeneralGradeTest()
        {
            Student student = new Student("ANA");
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.English, 9.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Mathematics, 10.0));
            student.AddGradeInGrades(new Grade(Subject.History, 8.0));
            student.AddGradeInGrades(new Grade(Subject.History, 10.0));
            student.AddGradeInGrades(new Grade(Subject.Romanian, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Romanian, 10.0));
            student.AddGradeInGrades(new Grade(Subject.Physics, 8.0));
            student.AddGradeInGrades(new Grade(Subject.Physics, 10.0));

            Assert.Equal(9.0, student.GeneralGrade());
        }


    }
}
