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
    
    public partial class tbl_CustomerTransactionDetails
    {
        public int CustomerTransactionId { get; set; }
        public int CustFlatId { get; set; }
        public int Payment1 { get; set; }
        public int Payment2 { get; set; }
        public int Payment3 { get; set; }
        public int Payment4 { get; set; }
        public int Payment5 { get; set; }
        public int Payment6 { get; set; }
        public int Payment7 { get; set; }
    
        public virtual tbl_CustomerFlatDetails tbl_CustomerFlatDetails { get; set; }
    }
}
