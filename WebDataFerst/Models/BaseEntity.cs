using System.ComponentModel.DataAnnotations;

namespace WebDataFerst.Models
{
    public class BaseEntity
    {
        [Key]
        int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
