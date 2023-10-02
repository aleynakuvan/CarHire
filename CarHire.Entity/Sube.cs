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
    [Table("Sube")]
    public class Sube
    {
      
            [StringLength(25)]
            
            public string Adi { get; set; }
            [StringLength(25)]
           
            public string Adres { get; set; }
        [Required, StringLength(70)]
        public string Telephone { get; set; }


    }
}
