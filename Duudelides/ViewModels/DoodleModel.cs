using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duudelides.ViewModels
{
    public class DoodleModel
    {
        public string Title { get; set; }
        public List<ParticipantDaysModel>  Participants { get; set; }
        public DateTime Beginning { get; set; }
        public  DateTime Ending { get; set; }
        public List<int> ParticipantIds { get; set; }

    }
}