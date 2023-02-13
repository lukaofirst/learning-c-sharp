namespace _005_this_keyword.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public Car(Guid Id, string Name, string Model)
        {
            this.Id = Id;
            this.Name = Name;
            this.Model = Model;
        }
    }
}
