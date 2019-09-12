using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HLA_Tracker.Core.Domain;
using HLA_Tracker.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HLA_Tracker.Web.Pages.Patients
{
    public class EditModel : PageModel
    {
        private readonly IPatientDataService _patientDataService;
        private readonly IHtmlHelper _htmlHelper;
        public Patient Patient { get; set; }
        public IEnumerable<SelectListItem> Genders{ get; set; }
        public EditModel(IPatientDataService patientDatatService, IHtmlHelper htmlHelper)
        {
            _patientDataService = patientDatatService;
            _htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int patientId)
        {
            Patient = _patientDataService.GetById(patientId);
            Genders = _htmlHelper.GetEnumSelectList<Gender>();

            if(Patient == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}