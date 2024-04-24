using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Type
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
