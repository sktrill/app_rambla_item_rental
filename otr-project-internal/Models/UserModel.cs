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
    public partial class UserModel
    {
        public UserModel()
        {
            this.Agreements = new HashSet<Agreement>();
            this.ItemModels = new HashSet<ItemModel>();
            this.Orders = new HashSet<Order>();
            this.ThreadModels = new HashSet<ThreadModel>();
            this.Badges = new HashSet<Badge>();
        }
    
        public string Email { get; set; }
        public string ActivationId { get; set; }
        public bool isFacebookUser { get; set; }
        public string FacebookUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string UserImageFileModelId { get; set; }
        public string PostalCode { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public decimal Earnings { get; set; }
    
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual Country Country { get; set; }
        public virtual FacebookUser FacebookUser { get; set; }
        public virtual ICollection<ItemModel> ItemModels { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<ThreadModel> ThreadModels { get; set; }
        public virtual UserImageFileModel UserImageFileModel { get; set; }
        public virtual ICollection<Badge> Badges { get; set; }
    }
    
}
