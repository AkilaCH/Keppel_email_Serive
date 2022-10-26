//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// imports IEntity interface 
using Azbil.Billing.Entities.Interfaces;

namespace Azbil.Billing.Entities.UserManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class VwUser : IEntity
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public string userStatus { get; set; }
        public byte[] userImage { get; set; }
        public int insertUserId { get; set; }
        public System.DateTime updatedDatetime { get; set; }
        public System.DateTime insertedDatetime { get; set; }
        public System.DateTime pwExpireDatetime { get; set; }
        public int profileId { get; set; }
        public string profileDescription { get; set; }
        public int accountStatus { get; set; }
    }
}
