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
    
    public partial class discount
    {
        public string DiscountID { get; set; }
        public string DisplayName { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<int> NumberOfUse { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string UpdateBy { get; set; }
    }
}
