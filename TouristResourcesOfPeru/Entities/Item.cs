using System;

namespace TouristResourcesOfPeru.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
        public int CODIGO_DEL_RECURSO { get; set; }
        public string NOMBRE_DEL_RECURSO { get; set; }
        public string CATEGORIA { get; set; }
        public string TIPO_DE_CATEGORIA { get; set; }
        public string SUB_TIPO_CATEGORIA { get; set; }
        public string URL { get; set; }
        public decimal LATITUD { get; set; }
        public decimal LONGITUD { get; set; }

    }
}
