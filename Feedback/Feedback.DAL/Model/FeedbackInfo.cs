//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feedback.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeedbackInfo
    {
        public int Id { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateBy { get; set; }
    
        public virtual QuestionInfo QuestionInfo { get; set; }
        public virtual StudentInfo StudentInfo { get; set; }
    }
}