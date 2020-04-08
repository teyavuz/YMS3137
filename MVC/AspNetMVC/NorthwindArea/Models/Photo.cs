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
    
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            this.PhotoComments = new HashSet<PhotoComment>();
        }
    
        public int PhotoID { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }
        public string PhotoTitle { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoComment> PhotoComments { get; set; }
        public virtual User User { get; set; }
    }
}