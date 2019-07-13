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
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.SaleDetails = new HashSet<SaleDetails>();
        }
    
        public int idItem { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public decimal price { get; set; }
        public Nullable<double> weight { get; set; }
        public string dimensions { get; set; }
        public int ItemType_idItemType { get; set; }
        public int Category_idCategory { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ItemType ItemType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetails> SaleDetails { get; set; }
    }
}