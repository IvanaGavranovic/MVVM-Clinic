//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dijagnoza_Specijaliste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijagnoza_Specijaliste()
        {
            this.Doktor_specijalista_Uput = new HashSet<Doktor_specijalista_Uput>();
            this.Terapija_Specijaliste = new HashSet<Terapija_Specijaliste>();
        }
    
        public int Dijagnoza_Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktor_specijalista_Uput> Doktor_specijalista_Uput { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terapija_Specijaliste> Terapija_Specijaliste { get; set; }
    }
}