//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppDatabaseTesting
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<short> Grade1 { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public Nullable<int> ExamId { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}