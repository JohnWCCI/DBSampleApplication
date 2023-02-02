using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole
{
    [Table("Course")]
    public class CourseModel
    {

        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; } = null!;
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentModel>? Enrollments { get; set; } 
    }
}
