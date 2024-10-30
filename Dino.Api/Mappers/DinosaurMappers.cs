using Dino.Api.Models.Data;
using Dino.Api.Models.Dto;

namespace Dino.Api.Mappers
{
    public static class DinosaurMappers
    {
        public static DinosaurDto ToDinosaurDto(this Dinosaur dinosaur)
        {
            return new DinosaurDto
            {
                Id = dinosaur.Id,
                Name = dinosaur.Name,
                Classification = dinosaur.Classification,
                Diet = dinosaur.Diet,
                Period = dinosaur.Period
            };
        }
    }
}
