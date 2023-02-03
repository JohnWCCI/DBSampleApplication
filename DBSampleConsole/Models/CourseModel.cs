using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole.Models
{
    [Table("Course")]
    public class CourseModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(0, 4)]
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentModel>? Enrollments { get; set; }
    }
}
