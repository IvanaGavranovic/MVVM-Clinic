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
    
    public partial class Pregled
    {
        public Pregled()
        {
        }
        public Pregled(string opis, DateTime termin, int doktor_opste_prakse_PregledDoktor_opste_prakseDoktor_Id, bool obavljen)
        {
            Opis = opis;
            Termin = termin;
            Doktor_opste_prakse_PregledDoktor_opste_prakseDoktor_Id = doktor_opste_prakse_PregledDoktor_opste_prakseDoktor_Id;
            Obavljen = obavljen;
        }

        public int Pregled_Id { get; set; }
        public string Opis { get; set; }
        public System.DateTime Termin { get; set; }
        public int Doktor_opste_prakse_PregledDoktor_opste_prakseDoktor_Id { get; set; }
        public bool Obavljen { get; set; }
    
        public virtual Doktor_op_pr_Pregled_Pacijent Doktor_op_pr_Pregled_Pacijent { get; set; }
    }
}
