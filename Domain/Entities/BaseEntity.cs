namespace Domain.Entities
{
    public abstract class BaseEntity<TPK>
    {
        public TPK? id { get; set; }
    }
}
