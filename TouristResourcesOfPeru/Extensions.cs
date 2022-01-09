using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristResourcesOfPeru.Dtos;
using TouristResourcesOfPeru.Entities;

namespace TouristResourcesOfPeru
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Category = item.Category,
                TypeOfCategory = item.TypeOfCategory,
                SubTypeOfCategory = item.SubTypeOfCategory,
                Latitude = item.Latitude,
                Longitude = item.Longitude,
            };
        }
    }
}
