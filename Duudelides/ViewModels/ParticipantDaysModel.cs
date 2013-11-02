using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duudelides.ViewModels
{
    public class ParticipantDaysModel
    {
        public string User { get; set; }
        public List<DateTime> Days { get; set; }
    }
}