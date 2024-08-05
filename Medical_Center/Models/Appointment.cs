using System;
using System.Collections.Generic;

namespace Medical_Center.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public TimeSpan? AppointmentTime { get; set; }

    public string? ReasonForVisit { get; set; }

    public string? Status { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }
}
