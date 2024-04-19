using System;
using System.Collections.Generic;

namespace StorageManagement_v1.Models;

public partial class Order
{
    public int OrdersId { get; set; }

    public DateOnly? OrdersDay { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
