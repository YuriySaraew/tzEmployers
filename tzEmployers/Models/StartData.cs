using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tzEmployers.Models
{
    public class StartData
    {
        public static void Initialize(EmployerContext context)
        {
            if (!context.Departments.Any())
            {
                context.Departments.AddRange
                    (
                        new Department { Name = "Логистика" },
                        new Department { Name = "Кадры" },
                        new Department { Name = "Финансы" }
                    );
                context.SaveChanges();
            }

            if (!context.Employers.Any())
            {
                context.Employers.AddRange
                    (
                        new Employer { Firstname = "Сергей", Surname = "Иванов", Lastname = "Михайлович", Birthday = new DateTime(1980, 01, 01), Gen = 0, DepartmentId = 1 }
                    );
                context.SaveChanges();
            }

           
        }
    }
}
