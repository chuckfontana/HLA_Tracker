﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Domain
{
    public class User:BaseObject
    { 
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
