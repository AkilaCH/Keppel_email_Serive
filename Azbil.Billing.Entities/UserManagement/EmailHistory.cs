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
    
    public partial class EmailHistory : IEntity
    {
        public int emailHistoryId { get; set; }
        public int userId { get; set; }
        public int emailTemplateId { get; set; }
        public string emailContent { get; set; }
        public System.DateTime emailSentDatetime { get; set; }
    }
}
