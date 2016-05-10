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
    public partial class ItemModel
    {
        public ItemModel()
        {
            this.BlackoutDates = new HashSet<BlackoutDate>();
            this.CartItemModels = new HashSet<CartItemModel>();
            this.ItemImageFileModels = new HashSet<ItemImageFileModel>();
            this.OrderDetailModels = new HashSet<OrderDetailModel>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int CategoryId { get; set; }
        public int AddressId { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public decimal CostPerDay { get; set; }
        public decimal SecurityDeposit { get; set; }
        public bool isActive { get; set; }
        public string UserModelEmail { get; set; }
        public string AgreementId { get; set; }
        public int ImageCount { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Agreement Agreement { get; set; }
        public virtual ICollection<BlackoutDate> BlackoutDates { get; set; }
        public virtual ICollection<CartItemModel> CartItemModels { get; set; }
        public virtual Category Category { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<ItemImageFileModel> ItemImageFileModels { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<OrderDetailModel> OrderDetailModels { get; set; }
        public virtual UserModel UserModel { get; set; }
    }
    
}