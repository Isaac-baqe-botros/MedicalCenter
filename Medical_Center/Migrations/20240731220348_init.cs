using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalCenter.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

        //    migrationBuilder.CreateTable(
        //        name: "Departments",
        //        columns: table => new
        //        {
        //            DepartmentID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            DepartmentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
        //            Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Departments", x => x.DepartmentID);
        //        });

            //    migrationBuilder.CreateTable(
            //        name: "InsuranceProviders",
            //        columns: table => new
            //        {
            //            ProviderID = table.Column<int>(type: "int", nullable: false),
            //            ProviderName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            ContactNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //            Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //            Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            ContractDetails = table.Column<string>(type: "text", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__Insuranc__B54C689DF820D673", x => x.ProviderID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Patients",
            //        columns: table => new
            //        {
            //            PatientID = table.Column<int>(type: "int", nullable: false),
            //            FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
            //            Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
            //            Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //            PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //            Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            InsuranceDetails = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //            EmergencyContact = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__Patients__970EC346EF4E5F5B", x => x.PatientID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Doctors",
            //        columns: table => new
            //        {
            //            DoctorId = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            OfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            AvailabilitySchedule = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            DepartmentId = table.Column<int>(type: "int", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Doctors", x => x.DoctorId);
            //            table.ForeignKey(
            //                name: "FK_Doctors_Departments_DepartmentId",
            //                column: x => x.DepartmentId,
            //                principalTable: "Departments",
            //                principalColumn: "DepartmentID");
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Staff",
            //        columns: table => new
            //        {
            //            StaffID = table.Column<int>(type: "int", nullable: false),
            //            FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //            Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            ShiftSchedule = table.Column<string>(type: "text", nullable: true),
            //            DepartmentID = table.Column<int>(type: "int", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__Staff__96D4AAF7F6E3E3CA", x => x.StaffID);
            //            table.ForeignKey(
            //                name: "FK__Staff__Departmen__4E88ABD4",
            //                column: x => x.DepartmentID,
            //                principalTable: "Departments",
            //                principalColumn: "DepartmentID");
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Billing",
            //        columns: table => new
            //        {
            //            BillID = table.Column<int>(type: "int", nullable: false),
            //            PatientID = table.Column<int>(type: "int", nullable: true),
            //            DateOfBill = table.Column<DateTime>(type: "date", nullable: true),
            //            Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
            //            PaymentStatus = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //            PaymentMethod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__Billing__11F2FC4A5A36CC6A", x => x.BillID);
            //            table.ForeignKey(
            //                name: "FK__Billing__Patient__5DCAEF64",
            //                column: x => x.PatientID,
            //                principalTable: "Patients",
            //                principalColumn: "PatientID");
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Appointments",
            //        columns: table => new
            //        {
            //            AppointmentId = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            PatientId = table.Column<int>(type: "int", nullable: true),
            //            DoctorId = table.Column<int>(type: "int", nullable: true),
            //            AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //            AppointmentTime = table.Column<TimeSpan>(type: "time", nullable: true),
            //            ReasonForVisit = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
            //            table.ForeignKey(
            //                name: "FK_Appointments_Doctors_DoctorId",
            //                column: x => x.DoctorId,
            //                principalTable: "Doctors",
            //                principalColumn: "DoctorId");
            //            table.ForeignKey(
            //                name: "FK_Appointments_Patients_PatientId",
            //                column: x => x.PatientId,
            //                principalTable: "Patients",
            //                principalColumn: "PatientID");
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MedicalRecords",
            //        columns: table => new
            //        {
            //            RecordID = table.Column<int>(type: "int", nullable: false),
            //            PatientID = table.Column<int>(type: "int", nullable: true),
            //            DoctorID = table.Column<int>(type: "int", nullable: true),
            //            DateOfVisit = table.Column<DateTime>(type: "date", nullable: true),
            //            Diagnosis = table.Column<string>(type: "text", nullable: true),
            //            Treatment = table.Column<string>(type: "text", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__MedicalR__FBDF78C9C47AF90E", x => x.RecordID);
            //            table.ForeignKey(
            //                name: "FK__MedicalRe__Docto__5812160E",
            //                column: x => x.DoctorID,
            //                principalTable: "Doctors",
            //                principalColumn: "DoctorId");
            //            table.ForeignKey(
            //                name: "FK__MedicalRe__Patie__571DF1D5",
            //                column: x => x.PatientID,
            //                principalTable: "Patients",
            //                principalColumn: "PatientID");
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Prescriptions",
            //        columns: table => new
            //        {
            //            PrescriptionID = table.Column<int>(type: "int", nullable: false),
            //            RecordID = table.Column<int>(type: "int", nullable: true),
            //            MedicationName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //            Dosage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            Frequency = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //            Duration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK__Prescrip__40130812DA200FBE", x => x.PrescriptionID);
            //            table.ForeignKey(
            //                name: "FK__Prescript__Recor__5AEE82B9",
            //                column: x => x.RecordID,
            //                principalTable: "MedicalRecords",
            //                principalColumn: "RecordID");
            //        });

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Appointments_DoctorId",
            //        table: "Appointments",
            //        column: "DoctorId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Appointments_PatientId",
            //        table: "Appointments",
            //        column: "PatientId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Billing_PatientID",
            //        table: "Billing",
            //        column: "PatientID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Doctors_DepartmentId",
            //        table: "Doctors",
            //        column: "DepartmentId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MedicalRecords_DoctorID",
            //        table: "MedicalRecords",
            //        column: "DoctorID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MedicalRecords_PatientID",
            //        table: "MedicalRecords",
            //        column: "PatientID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Prescriptions_RecordID",
            //        table: "Prescriptions",
            //        column: "RecordID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Staff_DepartmentID",
            //        table: "Staff",
            //        column: "DepartmentID");
            }

            /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            //migrationBuilder.DropTable(
            //    name: "Appointments");

            //migrationBuilder.DropTable(
            //    name: "Billing");

            //migrationBuilder.DropTable(
            //    name: "InsuranceProviders");

            //migrationBuilder.DropTable(
            //    name: "Prescriptions");

            //migrationBuilder.DropTable(
            //    name: "Staff");

            //migrationBuilder.DropTable(
            //    name: "MedicalRecords");

            //migrationBuilder.DropTable(
            //    name: "Doctors");

            //migrationBuilder.DropTable(
            //    name: "Patients");

            //migrationBuilder.DropTable(
            //    name: "Departments");
        }
    }
}
