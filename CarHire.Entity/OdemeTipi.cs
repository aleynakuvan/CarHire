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
    [Table("ÖdemeTipi")]
    public class OdemeTipi
    {
        public string Nakit { get; set; }

        public string Kredi { get; set; }
        public string Eft { get; set; }

    }
}
