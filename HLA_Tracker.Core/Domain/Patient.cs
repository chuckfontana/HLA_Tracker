using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Domain
{
    public class Patient:BaseObject
    {
        public string MRN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        public Enums.Gender Gender { get; set; }

    }
}
