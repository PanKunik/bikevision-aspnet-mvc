//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bikevision.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUsersDiscountCode
    {
        public string AspNetUser_Id { get; set; }
        public int DiscountCode_idDiscountCode { get; set; }
        public byte numberOfUses { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual DiscountCode DiscountCode { get; set; }
    }
}
