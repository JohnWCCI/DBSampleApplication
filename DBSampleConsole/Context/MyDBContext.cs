using DBSampleConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole.Context
{
    /// <summary>
    /// This class handles the Database Connection.
    /// </summary>
    public class MyDBContext : DbContext
    {
        /// <summary>
        /// You should change this to match you connection string
        /// </summary>
        //ToDo: Change this Conection String
        private const string conectionstring = @"Data Source=LocalHost;Initial Catalog=SampleDB2;Integrated Security=True";

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <remarks>This is used by Mirgation</remarks>
        public MyDBContext() : base()
        {}

        #region Database Set
        public DbSet<StudentModel> Students { get; set; } = null!;
        public DbSet<EnrollmentModel> Enrollments { get; set; } = null!;
        public DbSet<CourseModel> Courses { get; set; } = null!;
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conectionstring);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
