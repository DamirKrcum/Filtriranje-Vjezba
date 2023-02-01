using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("Uloge")]    
    public class Uloge
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

    }
}
