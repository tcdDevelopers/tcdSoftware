//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCDApplication.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ProjectDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ProjectDetails()
        {
            this.tbl_CustomerDetails = new HashSet<tbl_CustomerDetails>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CustomerDetails> tbl_CustomerDetails { get; set; }
    }
}