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
    public partial class CartItemModel
    {
        public int id { get; set; }
        public string CartId { get; set; }
        public string ItemId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime PickupDate { get; set; }
        public System.DateTime DropoffDate { get; set; }
        public decimal itemTotal { get; set; }
    
        public virtual ItemModel ItemModel { get; set; }
    }
    
}