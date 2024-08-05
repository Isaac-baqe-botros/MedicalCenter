using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class InsuranceProvider
{
    public int ProviderId { get; set; }

    public string? ProviderName { get; set; }

    public string? ContactNumber { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? ContractDetails { get; set; }
}
