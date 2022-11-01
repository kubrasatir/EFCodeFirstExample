using System.ComponentModel.DataAnnotations;

namespace PetShopWeb.InfrastructureEFCore.Entities
{
    public abstract class Animal
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        public string Color { get; set; }
    }
}
