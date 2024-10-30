namespace Dino.Api.Models.Dto
{
    public class DinosaurDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Classification { get; set; }
        public string? Diet { get; set; }
        public string? Period { get; set; }
    }
}