//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketID { get; set; }
        public Nullable<int> TheaterID { get; set; }
        public Nullable<int> MovieID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public string Row { get; set; }
        public Nullable<short> Seat { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
