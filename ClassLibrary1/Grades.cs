//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<short> Grade { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public Nullable<int> ExamId { get; set; }
    
        public virtual Exams Exams { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
