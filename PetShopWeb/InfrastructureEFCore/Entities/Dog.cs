namespace PetShopWeb.InfrastructureEFCore.Entities
{
    public class Dog: Animal
    { 
        public int AnimalTypeId { get; set; }
        public int FeedTypeId { get; set; }
        public byte BirdType { get; set; }
        public virtual AnimalType AnimalType { get; set; }
        public virtual FeedType FeedType { get; set; }
    }
}
