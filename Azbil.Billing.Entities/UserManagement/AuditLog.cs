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
    
    public partial class AuditLog : IEntity
    {
        public int auditLogId { get; set; }
        public int userId { get; set; }
        public string userFullName { get; set; }
        public string activity { get; set; }
        public System.DateTime dateTime { get; set; }
        public int LogType { get; set; }
        public string Summary { get; set; }
        public string ActionName { get; set; }
        public string Controller { get; set; }
        public int SessionId { get; set; }
    }
}