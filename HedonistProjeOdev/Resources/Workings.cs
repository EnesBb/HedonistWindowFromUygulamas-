//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HedonistProjeOdev.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workings
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int HotelID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int Status { get; set; }
    
        public virtual Hotels Hotels { get; set; }
    }
}
