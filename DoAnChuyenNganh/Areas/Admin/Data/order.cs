//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnChuyenNganh.Areas.Admin.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public string OrderID { get; set; }
        public string DiscountID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<System.DateTime> OrderDay { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<bool> STATUS { get; set; }
    }
}