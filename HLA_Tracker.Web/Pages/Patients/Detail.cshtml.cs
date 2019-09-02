using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HLA_Tracker.Core.Domain;
using HLA_Tracker.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HLA_Tracker.Web.Pages.Patients
{
    public class DetailModel : PageModel
    {
        private readonly IPatientDataService _patientDataService;
        public Patient Patient { get; set; }
        public DetailModel(IPatientDataService patientDataSerice)
        {
            _patientDataService = patientDataSerice;
        }

        public IActionResult OnGet(int patientId)
        {
            Patient = _patientDataService.GetById(patientId);
            
            if(Patient == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}