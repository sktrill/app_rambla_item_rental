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
    public partial class Agreement
    {
        public Agreement()
        {
            this.Categories = new HashSet<Category>();
            this.ItemModels = new HashSet<ItemModel>();
        }
    
        public string Id { get; set; }
        public string FileName { get; set; }
        public int ContentLength { get; set; }
        public string ContentType { get; set; }
        public string UserModelEmail { get; set; }
    
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<ItemModel> ItemModels { get; set; }
        public virtual UserModel UserModel { get; set; }
    }
    
}
