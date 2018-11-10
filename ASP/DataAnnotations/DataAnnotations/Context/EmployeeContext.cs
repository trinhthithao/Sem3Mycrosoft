using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DataAnnotations.Models;

namespace DataAnnotations.Context
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}