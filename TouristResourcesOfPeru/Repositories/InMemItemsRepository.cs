using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristResourcesOfPeru.Entities;

namespace TouristResourcesOfPeru.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item
            {
                Id = Guid.NewGuid(),
                NOMBRE_DEL_RECURSO = "Festividad Del Señor De Los Temblores",
                CATEGORIA = "5. ACONTECIMIENTOS PROGRAMADOS",
                TIPO_DE_CATEGORIA = "Fiestas",
                SUB_TIPO_CATEGORIA = "Fiestas religiosas-patronales",
                LATITUD = -71.9801M,
                LONGITUD = -13.5153M
            },
            new Item
            {
                Id = Guid.NewGuid(),
                NOMBRE_DEL_RECURSO = "Laguna De Langui-Layo",
                CATEGORIA = "1. SITIOS NATURALES",
                TIPO_DE_CATEGORIA = "g. Cuerpo de Agua",
                SUB_TIPO_CATEGORIA = "Lagunas",
                LATITUD = -71.166020M,
                LONGITUD = -14.499080M
            },
        };

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.FromResult(items);
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            var item = items.Where(item => item.Id == id).SingleOrDefault();
            return await Task.FromResult(item);
        }

        public async Task CreateItemAsync(Item item)
        {
            items.Add(item);
            await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
            await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
            await Task.CompletedTask;
        }
    }
}
