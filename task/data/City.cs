using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.data
{
    [Table("City")]
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("country")]
        public int Countey_id { get; set; }

        public Country country { get; set; }


    }
}
