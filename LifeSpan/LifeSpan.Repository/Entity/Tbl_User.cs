//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifeSpan.Repository.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_User
    {
        public long User_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile_No { get; set; }
        public System.DateTime DOB { get; set; }
        public string Type { get; set; }
        public bool Is_Deleted { get; set; }
        public System.DateTime Created_Time_Stamp { get; set; }
        public System.DateTime Updated_Time_Stamp { get; set; }
    }
}
