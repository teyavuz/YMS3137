//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindArea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhotoComment
    {
        public int PhotoCommentID { get; set; }
        public int UserId { get; set; }
        public int PhotoId { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
    
        public virtual Photo Photo { get; set; }
        public virtual User User { get; set; }
    }
}
