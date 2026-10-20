namespace KT_24_BoundedClasses
{
    public class Customer : Entity
    {
        public string Email { get; init; }

        public Customer(int id, string email) : base(id)
        {
            Email = email;
        }

        public override string ToString()
        {
            return $"Клиент [Id: {Id}, Email: {Email}]";
        }
    }
}