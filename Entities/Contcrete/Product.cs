﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Contcrete
{
//Public demek bu class'a diğer katmanlar da ulaşabilsin demektir.Diğer katmanlar Entities klasörüyle iş yaptıkları için buraya public verdik.
    public class Product:IEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
