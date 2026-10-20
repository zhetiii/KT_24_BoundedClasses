namespace KT_24_BoundedClasses
{
    public abstract class Entity
    {
        public int Id { get; init; }

        protected Entity(int id)
        {
            Id = id;
        }
    }
}