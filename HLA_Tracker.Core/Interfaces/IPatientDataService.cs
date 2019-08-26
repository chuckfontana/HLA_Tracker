using HLA_Tracker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Interfaces
{
    public interface IPatientDataService
    {
        IEnumerable<Patient> GetAllPatients();
    }
}
