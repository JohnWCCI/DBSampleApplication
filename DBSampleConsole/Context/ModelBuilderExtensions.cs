using DBSampleConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace DBSampleConsole
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().HasData(
            new StudentModel { Id = 1, FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 2, FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 3, FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 4, FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 5, FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 6, FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 7, FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2022-09-01") },
          new StudentModel { Id = 8, FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2022-09-01") });


            modelBuilder.Entity<CourseModel>().HasData(
            new CourseModel { Id = 1050, Title = "Chemistry", Credits = 3, },
         new CourseModel { Id = 4022, Title = "Microeconomics", Credits = 3, },
         new CourseModel { Id = 4041, Title = "Macroeconomics", Credits = 3, },
         new CourseModel { Id = 1045, Title = "Calculus", Credits = 4, },
         new CourseModel { Id = 3141, Title = "Trigonometry", Credits = 4, },
         new CourseModel { Id = 2021, Title = "Composition", Credits = 3, },
         new CourseModel { Id = 2042, Title = "Literature", Credits = 4, });


            modelBuilder.Entity<EnrollmentModel>().HasData(
            new EnrollmentModel {Id=1, StudentID = 1, CourseID = 1050, Grade = Grade.A },
           new EnrollmentModel {Id=2, StudentID = 1, CourseID = 4022, Grade = Grade.C },
           new EnrollmentModel {Id=3, StudentID = 1, CourseID = 4041, Grade = Grade.B },
           new EnrollmentModel {Id=4, StudentID = 2, CourseID = 1045, Grade = Grade.B },
           new EnrollmentModel {Id=5, StudentID = 2, CourseID = 3141, Grade = Grade.F },
           new EnrollmentModel {Id=6, StudentID = 2, CourseID = 2021, Grade = Grade.F },
           new EnrollmentModel {Id=7, StudentID = 3, CourseID = 1050, Grade = Grade.B },
           new EnrollmentModel {Id=8, StudentID = 4, CourseID = 1050, Grade = Grade.B },
           new EnrollmentModel {Id=9, StudentID = 4, CourseID = 4022, Grade = Grade.F },
           new EnrollmentModel {Id=10, StudentID = 5, CourseID = 4041, Grade = Grade.C },
           new EnrollmentModel {Id=11, StudentID = 6, CourseID = 1045, Grade = Grade.B },
           new EnrollmentModel {Id=12, StudentID = 7, CourseID = 3141, Grade = Grade.A });
        }
    }
}
