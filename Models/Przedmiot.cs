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
    
    public partial class Przedmiot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Przedmiot()
        {
            this.SzczegolySprzedazy = new HashSet<SzczegolySprzedazy>();
        }
    
        public int idPrzedmiot { get; set; }
        public string nazwaPrzedmiotu { get; set; }
        public string opisPrzedmiotu { get; set; }
        public decimal cena { get; set; }
        public Nullable<double> waga { get; set; }
        public string wymiary { get; set; }
        public int TypPrzedmiotu_idTypPrzedmiotu { get; set; }
        public Nullable<int> Kategoria_idKategoria { get; set; }
    
        public virtual Kategoria Kategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SzczegolySprzedazy> SzczegolySprzedazy { get; set; }
        public virtual TypPrzedmiotu TypPrzedmiotu { get; set; }
    }
}
