//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace otr_project_internal.Models
{
    public partial class Order
    {
        public Order()
        {
            this.OrderDetailModels = new HashSet<OrderDetailModel>();
        }
    
        public string OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string PayPalToken { get; set; }
        public bool Confirmed { get; set; }
        public string User_Email { get; set; }
    
        public virtual ICollection<OrderDetailModel> OrderDetailModels { get; set; }
        public virtual UserModel UserModel { get; set; }
    }
    
}