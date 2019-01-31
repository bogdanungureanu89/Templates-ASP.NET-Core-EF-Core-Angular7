namespace Test.Data.Entities
{
    public abstract class BaseEntity : IDataEntity
    {
        //Set key, columns and table related properties here
        public int Id { get; set; }
    }
}
