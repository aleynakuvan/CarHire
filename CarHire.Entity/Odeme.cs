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
    [Table("Ödeme")]
    public class Odeme
    {
      
            [StringLength(25)]
            
            public int Odememiktari { get; set; }
            [StringLength(25)]
           
            public string Odemetipi { get; set; }
            [Required]
            public DateTime Odemetarihi { get; set; }
            
         
      
        public virtual List<Kiralama> Kiralama { get; set; }


    }
}
