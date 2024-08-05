using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Prescription
{
    public int PrescriptionId { get; set; }

    public int? RecordId { get; set; }

    public string? MedicationName { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public virtual MedicalRecord? Record { get; set; }
}
