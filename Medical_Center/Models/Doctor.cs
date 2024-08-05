using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Specialization { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? OfficeAddress { get; set; }

    public string? AvailabilitySchedule { get; set; }

    public int? DepartmentId { get; set; }

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<MedicalRecord> MedicalRecords { get; } = new List<MedicalRecord>();
}
