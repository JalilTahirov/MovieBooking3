//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieBooking3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMovie
    {
        public int UserMovieId { get; set; }
        public Nullable<int> MovieId { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> MovieTime { get; set; }
        public Nullable<int> PurchaseCount { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
