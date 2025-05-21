using System;
using System.Collections.Generic;

namespace Master.Entities;

public partial class Product
{
    public int IdProduct { get; set; }

    public string Name { get; set; } = null!;

    public int IdProductType { get; set; }

    public virtual ProductType IdProductTypeNavigation { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
