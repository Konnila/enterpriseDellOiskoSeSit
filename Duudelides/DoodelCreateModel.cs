using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Duudelides
{
    public class DoodelCreateModel
    {
        [Required]
        public string Title { get; set; }

        public string Beginning { get; set; }
        public string Ending { get; set; }
    }
}