//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections;

namespace EntityFrameWorkDatabaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee : IEnumerable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Email { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
