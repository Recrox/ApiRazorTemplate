using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class BaseEntity
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
