using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole
{
    public class MyDBContext : DbContext
    {
        private const string conectionstring = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ContosoUniversity1;Integrated Security=SSPI;";

        public MyDBContext() : base()
        {
           
        }

        public DbSet<StudentModel> Students { get; set; } = null!;
        public DbSet<EnrollmentModel> Enrollments { get; set; } = null!;
        public DbSet<CourseModel> Courses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conectionstring);
            base.OnConfiguring(optionsBuilder);
        }
      
    }
}
