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
    
    public partial class UsersDoodle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DoodelId { get; set; }
    
        public virtual Doodel Doodel { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
