using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entitys
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

    }
}
