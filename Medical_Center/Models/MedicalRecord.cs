using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class MedicalRecord
{
    public int RecordId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? DateOfVisit { get; set; }

    public string? Diagnosis { get; set; }

    public string? Treatment { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual ICollection<Prescription> Prescriptions { get; } = new List<Prescription>();
}
