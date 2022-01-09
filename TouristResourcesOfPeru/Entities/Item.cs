using System;

namespace TouristResourcesOfPeru.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TypeOfCategory { get; set; }
        public string SubTypeOfCategory { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
