namespace KT_24_BoundedClasses
{
    public class Product : Entity
    {
        public string Name { get; init; }

        public Product(int id, string name) : base(id)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Товар [Id: {Id}, Название: {Name}]";
        }
    }
}