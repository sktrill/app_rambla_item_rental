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
    public partial class Address
    {
        public Address()
        {
            this.ItemModels = new HashSet<ItemModel>();
        }
    
        public int Id { get; set; }
        public string ItemModelId { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    
        public virtual ICollection<ItemModel> ItemModels { get; set; }
    }
    
}
