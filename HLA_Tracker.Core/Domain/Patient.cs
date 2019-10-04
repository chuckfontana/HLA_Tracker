using System;
using System.Collections.Generic;
using System.Text;
using HLA_Tracker.Core.Domain;

namespace HLA_Tracker.Core.Domain
{
    public class Patient:BaseEntity
    {
        public string MRN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Suffix { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Race Race { get; set; }
        public string SSN { get; set; }
        public string FullName { get { return $"{LastName}, {FirstName}"; }}
    }
}
