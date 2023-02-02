using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstMidName { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<EnrollmentModel>? Enrollments { get; set; }
    }
}
