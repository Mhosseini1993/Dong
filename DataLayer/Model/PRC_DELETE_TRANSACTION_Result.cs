//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Model
{
    using System;
    
    public partial class PRC_DELETE_TRANSACTION_Result
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> GoodsID { get; set; }
        public Nullable<bool> IsBuyer { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<int> Get { get; set; }
        public Nullable<int> Pay { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> IsCheckOut { get; set; }
        public Nullable<int> GroupID { get; set; }
    }
}
