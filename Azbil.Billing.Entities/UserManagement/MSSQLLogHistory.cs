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

    public partial class MSSQLLogHistory : IEntity
    {
        [Key]
        public int LogId { get; set; }
        public System.DateTime LogDate { get; set; }
        public string ProcessInfo { get; set; }
        public string Text { get; set; }
    }
}
