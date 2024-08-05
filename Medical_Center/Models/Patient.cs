using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? InsuranceDetails { get; set; }

    public string? EmergencyContact { get; set; }

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual ICollection<Billing> Billings { get; } = new List<Billing>();

    public virtual ICollection<MedicalRecord> MedicalRecords { get; } = new List<MedicalRecord>();
}
