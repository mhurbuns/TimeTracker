//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeSheetDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unit
    {
        public Unit()
        {
            this.TimeSheetDetails = new HashSet<TimeSheetDetail>();
        }
    
        public System.Guid UnitId { get; set; }
        public int DurationMinutes { get; set; }
        public int Unit1 { get; set; }
    
        public virtual ICollection<TimeSheetDetail> TimeSheetDetails { get; set; }
    }
}
