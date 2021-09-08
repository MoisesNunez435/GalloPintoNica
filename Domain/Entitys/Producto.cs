using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entitys
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Producto
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public int Existencia { get; set; }
        [JsonProperty]
        public decimal Precio { get; set; }
        [JsonProperty]
        public DateTime FechaVencimiento { get; set; }
        [JsonProperty]
        public UnidadMedida UnidadMedida { get; set; }

        public class ProductoPriceComparer : IComparer<Producto>
        {
            public int Compare(Producto e1, Producto e2)
            {
                if (e1 == null || e2 == null)
                {
                    throw new ArgumentException("Error, los objetos no peden ser nulos.");
                }
                if (e1.Precio > e2.Precio)
                {
                    return 1;
                }
                else if (e1.Precio < e2.Precio)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
