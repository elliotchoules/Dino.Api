using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Dino.Api.Models.Data
{
    // This class doesn’t have any dependency on EF Core. It just defines the properties of the data that will be stored in the database.
    public class Dinosaur
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("classification")]
        public string? Classification { get; set; }

        [JsonPropertyName("diet")]
        public string? Diet { get; set; }

        [JsonPropertyName("period")]
        public string? Period { get; set; }
    }
}
