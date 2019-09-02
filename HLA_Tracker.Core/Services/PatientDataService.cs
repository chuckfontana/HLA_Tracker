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
        public IEnumerable<Patient> GetPatientByName(string name)
        {
            return _patientData.GetPatientByName(name);
        }
        public Patient GetById(int id)
        {
            return _patientData.GetById(id);
        }
    }
}
