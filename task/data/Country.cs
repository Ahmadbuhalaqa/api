using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.data
{
    [Table("Country")]
    public class Country
    {
        public int iD { get; set; }
        [Required]
        public string Name { get; set; }

        public int Code { get; set; }
    }
}
