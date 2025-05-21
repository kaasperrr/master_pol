using System;
using System.Collections.Generic;

namespace Master.Entities;

public partial class ProductType
{
    public int IdProductType { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
