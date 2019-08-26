using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Domain
{
    public class BaseObject
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public User CreatedBy { get; set; }
        public DateTime EditDateTime { get; set; }
        public User EditedBy { get; set; }
    }
}
