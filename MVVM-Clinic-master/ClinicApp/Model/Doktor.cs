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

    public partial class Doktor : Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Doktor()
        {
                
        }
        
        /* public Doktor()
        {
            this.Doktor_opste_prakse_Pregled1 = new HashSet<Doktor_opste_prakse_Pregled1>();
            this.Doktor_specijalista_Uput = new HashSet<Doktor_specijalista_Uput>();
            this.Doktor_Departman = new HashSet<Doktor_Departman>();
        }*/

        public Doktor(string ime, string prezime, string korisnickoIme, string lozinka, string email, string kontakt, string ulica, string broj, string grad, string specijalizacija, int klinika_Id, int departman_Id, string uloga) : base(ime, prezime, kontakt, email, ulica, grad, broj, korisnickoIme, lozinka, uloga)
        {
            Specijalizacija = specijalizacija;
            Klinika_Id = klinika_Id;
            Departman_Id = departman_Id;
            Uloga = uloga;
            this.Doktor_specijalista_Uput = new HashSet<Doktor_specijalista_Uput>();
            this.Doktor_Departman = new HashSet<Doktor_Departman>();
        }

        public int Doktor_Id { get; set; }
        public string Specijalizacija { get; set; }
        public int Klinika_Id { get; set; }
        public int Departman_Id { get; set; }
        public string Uloga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktor_specijalista_Uput> Doktor_specijalista_Uput { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktor_Departman> Doktor_Departman { get; set; }
    }
}
