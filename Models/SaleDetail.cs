﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    
    public partial class SaleDetail
    {
        [Display(Name = "Wartość:")]
        [Required(ErrorMessage = "Wartość jest wymagana.")]
        public decimal value { get; set; }
        public int Sale_idSale { get; set; }
        public int Item_idItem { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
