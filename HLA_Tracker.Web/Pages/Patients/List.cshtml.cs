using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HLA_Tracker.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HLA_Tracker.Core.Domain;

namespace HLA_Tracker.Web.Pages.Patients
{
    public class ListModel : PageModel
    {
        private readonly IPatientDataService _patientDataService;

        public IEnumerable<Patient> Patients { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IPatientDataService patientDataSerice)
        {
            _patientDataService = patientDataSerice;
        }
        public void OnGet()
        {
            this.Patients = _patientDataService.GetPatientByName(SearchTerm);
        }
    }
}