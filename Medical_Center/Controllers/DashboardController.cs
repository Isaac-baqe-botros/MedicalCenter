using Medical_Center.Models;
using Medical_Center.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medical_Center.Controllers
{
     
        public class DashboardController : Controller
        {
            private readonly MedicalCenterContext _context;

            public DashboardController(MedicalCenterContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
                var viewModel = new DashboardViewModel
                {
                    TotalPatients = await _context.Patients.CountAsync(),
                    TotalAppointments = await _context.Appointments.CountAsync(),
                    TotalDoctors = await _context.Doctors.CountAsync(),
                    TotalBilling = (decimal)await _context.Billings.SumAsync(b => b.Amount)
                };

                return View(viewModel);
            }
        }
    }

