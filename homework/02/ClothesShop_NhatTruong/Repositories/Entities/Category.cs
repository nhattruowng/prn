using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Category
{
    public int Categoryid { get; set; }

    public string? Categoryname { get; set; }

    public int? TypeId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Type? Type { get; set; }
}
