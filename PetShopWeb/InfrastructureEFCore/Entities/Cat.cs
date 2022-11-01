namespace PetShopWeb.InfrastructureEFCore.Entities
{
    public class Cat: Animal
    {
        public int AnimalTypeId { get; set; }
        public int FeedTypeId { get; set; } 
        public virtual AnimalType AnimalType { get; set; }
        public virtual FeedType FeedType { get; set; }
    }
}
