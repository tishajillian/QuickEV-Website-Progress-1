//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickEV_Website.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleUser { get; set; }
        public Nullable<int> IdKomunitas { get; set; }
        public Nullable<int> IdRelawan { get; set; }
    
        public virtual Komunitas Komunita { get; set; }
        public virtual Relawan Relawan { get; set; }
    }
}
