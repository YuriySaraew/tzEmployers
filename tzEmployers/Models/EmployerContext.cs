using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace tzEmployers.Models
{
    public class EmployerContext : DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }



        public EmployerContext(DbContextOptions<EmployerContext> options) : base(options) => Database.EnsureCreated();

        public EmployerContext() { }

    }
}
