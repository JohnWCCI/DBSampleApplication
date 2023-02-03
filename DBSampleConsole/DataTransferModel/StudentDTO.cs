using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleConsole.DataTransferModel
{
    public class StudentDTO
    {
        public string StudentName { get; set; } = null!;
        public string CourseName { get; set; } = null!;
        public string? Grade { get; set; }
    }
}
