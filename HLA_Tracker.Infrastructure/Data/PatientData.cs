using HLA_Tracker.Core.Domain;
using HLA_Tracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HLA_Tracker.Infrastructure.TestData;
using System.Linq;

namespace HLA_Tracker.Infrastructure.Data
{
    public class PatientData : IPatientData
    {
        private List<Patient> _patients;

        public PatientData()
        {
            _patients = new HLATestData().GetAllPatients();
        }

        public Patient GetById(int id)
        {
            return _patients.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Patient> GetPatientByName(string name = null)
        {
            return new HLATestData().GetAllPatients().Where(p => String.IsNullOrEmpty(name) || p.LastName.StartsWith(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
