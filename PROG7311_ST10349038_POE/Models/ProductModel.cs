using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG7311_ST10349038_POE.Models
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductType { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal ProductPrice { get; set; }

        //This variable name was a mistake, but it breaks the entire app if I change it
        [Required]
        [DataType(DataType.Date)]
        public DateTime ProfileType { get; set; }


    }
}
