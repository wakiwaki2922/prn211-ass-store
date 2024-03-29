﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Model;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierAddress { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<FlowerBouquet> FlowerBouquets { get; set; } = new List<FlowerBouquet>();
}
