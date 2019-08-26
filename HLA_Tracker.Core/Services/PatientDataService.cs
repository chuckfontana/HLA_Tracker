using HLA_Tracker.Core.Domain;
using HLA_Tracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Services
{
    public class PatientDataService : IPatientDataService
    {
        private readonly IPatientData _patientData;

        public PatientDataService(IPatientData patientData)
        {
            _patientData = patientData;
        }
        public IEnumerable<Patient> GetAllPatients()
        {
            return _patientData.GetAllPatients();
        }
    }
}
