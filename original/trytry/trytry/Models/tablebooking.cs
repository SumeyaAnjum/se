//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trytry.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tablebooking
    {
        public int TableId { get; set; }
        public string CityName { get; set; }
        public string HallName { get; set; }
        public string address { get; set; }
        public Nullable<int> personno { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> starttime { get; set; }
        public Nullable<System.TimeSpan> endtime { get; set; }
        public Nullable<int> budget { get; set; }
        public byte[] image { get; set; }
    }
}
