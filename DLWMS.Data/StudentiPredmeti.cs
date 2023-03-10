using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }

        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        
        public Predmeti Predmet { get; set; }
    }
}
