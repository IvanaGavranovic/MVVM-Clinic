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
    
    public partial class Doktor_op_pr_Pregled_Pacijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktor_op_pr_Pregled_Pacijent()
        {
            this.Pacijents = new HashSet<Pacijent>();
            this.Ishod_Pregleda = new HashSet<Ishod_Pregleda>();
            this.Pregleds = new HashSet<Pregled>();
        }
    
        public int PacijentPacijent_Id { get; set; }
        public int Doktor_opste_prakse_Pregled_Doktor_opste_prakseDoktor_Id { get; set; }
        public string Id { get; set; }
    
        public virtual Doktor Doktors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pacijent> Pacijents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ishod_Pregleda> Ishod_Pregleda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
