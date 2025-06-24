using System.ComponentModel.DataAnnotations.Schema;

namespace WebDataFerst.Models
{
    public class Product : BaseEntity
    {

        public decimal Price { get; set; }
        public virtual List<Photo> Photos { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(name: nameof(CategoryId))]
        public virtual Category Category { get; set; }

    }
}
