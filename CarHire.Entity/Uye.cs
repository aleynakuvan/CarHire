using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarHire.Entity
{
    [Table("Üye")]
    public class Uye
    {
      
            [StringLength(25)]
            [DisplayName("İsim")]
            public string Name { get; set; }
            [StringLength(25)]
            [DisplayName("Soyisim")]
            public string Surname { get; set; }
            [Required, StringLength(25)]
            public string Username { get; set; }
          
            [Required, StringLength(70)]
            public string Email { get; set; }

            [Required, StringLength(8)]//MinLength(6),MaxLength(8)
            public string Password { get; set; }
        [Required, StringLength(70)]
        public string Telephone { get; set; }

        public DateTime registrationdate { get; set; }


    }
}
