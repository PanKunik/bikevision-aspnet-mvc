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
    
    public partial class EmployeeInThePosition
    {
        public System.DateTime dateOfEmployment { get; set; }
        public int Employee_idEmployee { get; set; }
        public int Position_idPosition { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}