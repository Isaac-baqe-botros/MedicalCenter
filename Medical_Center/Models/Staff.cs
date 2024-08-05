using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Role { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? ShiftSchedule { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
