using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Customer
    {

        [Key]
        public int IdCustomer { get; set; }
        [Required]
        [StringLength(30)]
        public string IdentifitionNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [StringLength(10)]
        public string Telephone { get; set; }
    }
}
