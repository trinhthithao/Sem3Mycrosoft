//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sub_Comment
    {
        public int id { get; set; }
        public string sub_Comment1 { get; set; }
        public int Comment_id { get; set; }
        public int Traveler_id { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updateAt { get; set; }
    
        public virtual Comment Comment { get; set; }
        public virtual Traveler Traveler { get; set; }
    }
}
