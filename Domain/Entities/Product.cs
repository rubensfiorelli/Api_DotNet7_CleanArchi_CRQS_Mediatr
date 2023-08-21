using Domain.Primitives;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product(string title, string description, decimal price) : base()
        {
            Title = title;
            Description = description;
            Price = price;
            IsDeleted = false;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool IsDeleted { get; private set; }

        public void Update(string newTitle, string newDescription, decimal newPrice)
        {
            Title = newTitle;
            Description = newDescription;
            Price = newPrice;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
