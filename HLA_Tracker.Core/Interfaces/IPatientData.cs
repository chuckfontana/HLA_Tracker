using HLA_Tracker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Interfaces
{
    public interface IPatientData
    {
        IEnumerable<Patient> GetPatientByName(string name);
        Patient GetById(int id);
    }
}
