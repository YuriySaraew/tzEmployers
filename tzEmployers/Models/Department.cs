using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.RightsManagement;
using System.Text;

namespace tzEmployers.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }


    }
}
