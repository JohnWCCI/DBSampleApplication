using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    [Table("Enrollment")]
    public class EnrollmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual CourseModel Course { get; set; } = null!;
        public virtual StudentModel Student { get; set; } = null!;
    }
}
