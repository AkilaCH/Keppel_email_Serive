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

    public partial class MSSQLAccessLog : IEntity
    {
        [Key]
        public int LogId { get; set; }
        public System.DateTime LogDateTime { get; set; }
        public string UserName { get; set; }
        public string ClientIP { get; set; }
        public string LogStatus { get; set; }
    }
}
