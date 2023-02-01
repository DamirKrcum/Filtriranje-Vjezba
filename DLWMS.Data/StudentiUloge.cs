using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiUloge")]
    public class StudentiUloge
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int UogaId { get; set; }

    }
}

