using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace tzEmployers.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int? EmployerId{ get; set; }
        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }

    }
}
