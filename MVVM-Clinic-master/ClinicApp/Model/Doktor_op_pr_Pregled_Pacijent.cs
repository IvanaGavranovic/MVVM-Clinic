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
            this.Ishod_Pregleda = new HashSet<Ishod_Pregleda>();
        }
    
        public int PacijentPacijent_Id { get; set; }
        public int PacijentPacijent_Id1 { get; set; }
        public int Doktor_opste_prakse_Pregled_Doktor_opste_prakseDoktor_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ishod_Pregleda> Ishod_Pregleda { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
