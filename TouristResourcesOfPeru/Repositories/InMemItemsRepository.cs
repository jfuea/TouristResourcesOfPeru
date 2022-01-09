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
                Name = "Festividad Del Señor De Los Temblores",
                Category = "5. ACONTECIMIENTOS PROGRAMADOS",
                TypeOfCategory = "Fiestas",
                SubTypeOfCategory = "Fiestas religiosas-patronales",
                Latitude = -71.9801M,
                Longitude = -13.5153M
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Laguna De Langui-Layo",
                Category = "1. SITIOS NATURALES",
                TypeOfCategory = "g. Cuerpo de Agua",
                SubTypeOfCategory = "Lagunas",
                Latitude = -71.166020M,
                Longitude = -14.499080M
            },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            var item = items.Where(item => item.Id == id).SingleOrDefault();
            return item;
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);

        }
    }
}
