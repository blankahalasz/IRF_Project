//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRF_beadando
{
    using System;
    using System.Collections.Generic;
    
    public partial class Edzo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Edzo()
        {
            this.Eredmenies = new HashSet<Eredmeny>();
            this.Sportoloes = new HashSet<Sportolo>();
        }
    
        public string FELH_NEV { get; set; }
        public string NEV { get; set; }
        public string EMAIL { get; set; }
        public string JELSZO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eredmeny> Eredmenies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sportolo> Sportoloes { get; set; }
    }
}