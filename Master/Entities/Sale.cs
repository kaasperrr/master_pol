using System;
using System.Collections.Generic;

namespace Master.Entities;

public partial class Sale
{
    public int IdSale { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Quantity { get; set; }

    public DateTime SaleDate { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
