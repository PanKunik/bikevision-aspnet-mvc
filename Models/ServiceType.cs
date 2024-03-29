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
    
    public partial class ServiceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceType()
        {
            this.Services = new HashSet<Service>();
        }
    
        public int idServiceType { get; set; }
        [Display(Name = "Typ zlecenia:")]
        [Required(ErrorMessage = "Typ zlecenia jest wymagany.")]
        public string type { get; set; }
        [Display(Name = "Cena od:")]
        public Nullable<int> priceFrom { get; set; }
        [Display(Name = "Cena do:")]
        public Nullable<int> priceTo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
