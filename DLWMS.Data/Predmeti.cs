using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("Predmeti")]
    public class Predmeti
    {
        public int id { get; set; }
        public string Naziv { get; set; }
    }
}
