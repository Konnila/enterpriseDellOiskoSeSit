using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duudelides.ViewModels
{
    public class DoodleModel
    {
        public string Title { get; set; }
        public List<string> Participants { get; set; }
        public List<ParticipantDaysModel>  ParticipantDays { get; set; }
        public DateTime Beginning { get; set; }
        public  DateTime Ending { get; set; }
    }
}