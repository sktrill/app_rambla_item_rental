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
    public partial class FacebookUser
    {
        public FacebookUser()
        {
            this.UserModels = new HashSet<UserModel>();
        }
    
        public string Id { get; set; }
        public string AccessToken { get; set; }
        public System.DateTime Expires { get; set; }
        public string UserModelEmail { get; set; }
    
        public virtual ICollection<UserModel> UserModels { get; set; }
    }
    
}