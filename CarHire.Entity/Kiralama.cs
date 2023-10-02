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
    [Table("Kiralama")]
    public class Kiralama
    {
        [Required]
        public DateTime baslangictarih { get; set; }

        [Required]
        public DateTime bitistarihi { get; set; }

        public virtual List<Musteri> Musteri { get; set; }
        public virtual List<Arac> Arac { get; set; }


    }
}
