using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace tzEmployers.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public Gender Gen { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }
}
