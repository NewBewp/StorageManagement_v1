using System;
using System.Collections.Generic;

namespace StorageManagement_v1.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public double? Leght { get; set; }

    public double? Thickness { get; set; }

    public double? Weight { get; set; }

    public string? Materials { get; set; }

    public string? Describes { get; set; }

    public int? ProductTypeId { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ProductType? ProductType { get; set; }
}
