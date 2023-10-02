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
    [Table("Araç")]
    public class Arac
    {
      
            [StringLength(25)]
            
            public string Marka { get; set; }
            [StringLength(25)]
           
            public string Model { get; set; }
            [Required]
            public DateTime Uretimyili { get; set; }
            
            [Required, StringLength(70)]
            public double KiralamaFiyati { get; set; }

        [StringLength(30)] //user.png
        public string Photo { get; set; }


    }
}
