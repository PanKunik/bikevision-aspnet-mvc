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
    
    public partial class NoteToService
    {
        public int Note_idNote { get; set; }
        public int Service_idService { get; set; }
        public System.DateTime date { get; set; }
        public string AspNetUser_idAspNetUser { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Note Note { get; set; }
        public virtual Service Service { get; set; }
    }
}
