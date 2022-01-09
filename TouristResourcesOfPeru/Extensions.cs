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
                Name = item.NOMBRE_DEL_RECURSO,
                Category = item.CATEGORIA,
                TypeOfCategory = item.TIPO_DE_CATEGORIA,
                SubTypeOfCategory = item.SUB_TIPO_CATEGORIA,
                Latitude = item.LATITUD,
                Longitude = item.LONGITUD,
            };
        }

        public static Item AsItem(this ItemDto item)
        {
            return new Item
            {
                Id = item.Id,
                NOMBRE_DEL_RECURSO = item.Name,
                CATEGORIA = item.Category,
                TIPO_DE_CATEGORIA = item.TypeOfCategory,
                SUB_TIPO_CATEGORIA = item.SubTypeOfCategory,
                LATITUD = item.Latitude,
                LONGITUD = item.Longitude,
            };
        }

        public static Item AsItem(this CreateItemDto item)
        {
            return new Item
            {
                NOMBRE_DEL_RECURSO = item.Name,
                CATEGORIA = item.Category,
                TIPO_DE_CATEGORIA = item.TypeOfCategory,
                SUB_TIPO_CATEGORIA = item.SubTypeOfCategory,
                LATITUD = item.Latitude,
                LONGITUD = item.Longitude,
            };
        }

    }
}
