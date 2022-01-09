using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristResourcesOfPeru.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string TypeOfCategory { get; set; }
        public string SubTypeOfCategory { get; set; }
        [Range(-90, 90)]
        public decimal Latitude { get; set; }
        [Range(-90, 90)]
        public decimal Longitude { get; set; }
    }
}
