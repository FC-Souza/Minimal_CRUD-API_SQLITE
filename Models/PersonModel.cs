namespace Person.Models
{
    public class PersonModel
    {

        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        //Guid is a unique identifier
        //init will work only once, after that it will be readonly
        public Guid Id { get; init; }

        public string Name { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
        }

        //Delete a specific person permanently
        public void Delete()
        {
            Name = "Disabled";
        }

    }
}
