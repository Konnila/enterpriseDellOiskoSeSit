//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duudelides
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDoodelChoices
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int UserDoodelId { get; set; }
    
        public virtual Day Day { get; set; }
        public virtual UsersDoodle UsersDoodle { get; set; }
    }
}
