using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Supplier
{
    public int Supplierid { get; set; }

    public string? Suppliername { get; set; }

    public string Supplierimage { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
