using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBSampleConsole.Models
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string FirstMidName { get; set; } = null!;
        [Required]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<EnrollmentModel>? Enrollments { get; set; }
    }
}
