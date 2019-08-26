using HLA_Tracker.Core.Domain;
using HLA_Tracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HLA_Tracker.Infrastructure.TestData;

namespace HLA_Tracker.Infrastructure.Data
{
    public class PatientData : IPatientData
    {
        public IEnumerable<Patient> GetAllPatients()
        {
            return new HLATestData().GetAllPatients();
        }
    }
}
