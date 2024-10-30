namespace Dino.Api.Models.Data
{
    // This class doesn’t have any dependency on EF Core. It just defines the properties of the data that will be stored in the database.
    public class Dinosaur
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Classification { get; set; }
        public string? Diet { get; set; }
        public string? Period { get; set; }
    }
}
