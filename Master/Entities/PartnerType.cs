using System;
using System.Collections.Generic;

namespace Master.Entities;

public partial class PartnerType
{
    public int IdPartnerType { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
