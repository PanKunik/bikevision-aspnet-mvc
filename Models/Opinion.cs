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
    
    public partial class Opinion
    {
        public int idOpinion { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string opinion1 { get; set; }
        public int Customer_idCustomer { get; set; }
        public int Item_idItem { get; set; }
        public int Points_idPoints { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
        public virtual Point Point { get; set; }
    }
}
