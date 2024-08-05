using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? Location { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Doctor> Doctors { get; } = new List<Doctor>();

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();
}
