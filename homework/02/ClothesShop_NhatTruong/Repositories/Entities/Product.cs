using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Productname { get; set; } = null!;

    public int? Supplierid { get; set; }

    public int? Categoryid { get; set; }

    public string Size { get; set; } = null!;

    public int Stock { get; set; }

    public string? Description { get; set; }

    public byte[] Images { get; set; } = null!;

    public string Colors { get; set; } = null!;

    public DateOnly Releasedate { get; set; }

    public double? Discount { get; set; }

    public int? UnitSold { get; set; }

    public decimal Price { get; set; }

    public bool Status { get; set; }

    public int Typeid { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual Type Type { get; set; } = null!;
}
