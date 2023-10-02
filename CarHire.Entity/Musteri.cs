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
    [Table("Müşteri")]
    public class Musteri
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

        [Required, StringLength(70)]
        public string Telephone { get; set; }
        [Required, StringLength(70)]
        public string Adress { get; set; }

        public virtual List<Uye> Uye { get; set; }


    }
}
