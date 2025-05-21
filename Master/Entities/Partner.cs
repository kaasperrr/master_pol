using System;
using System.Collections.Generic;

namespace Master.Entities;

public partial class Partner
{
    public int IdPartner { get; set; }

    public string Name { get; set; } = null!;

    public int IdPartnerType { get; set; }

    public int? Rating { get; set; }

    public string? Address { get; set; }

    public string? DirectorFirstName { get; set; }

    public string? DirectorMiddleName { get; set; }

    public string? DirectorLastName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual PartnerType IdPartnerTypeNavigation { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
