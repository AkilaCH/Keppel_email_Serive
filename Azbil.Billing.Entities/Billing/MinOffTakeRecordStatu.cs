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

namespace Azbil.Billing.Entities.Billing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MinOffTakeRecordStatu : IEntity
    {
        [Key]
        public int MinOffTakeRecordStatusId { get; set; }
        public int MinOffTakeRecordId { get; set; }
        public string Status { get; set; }
        public int InsertedUserId { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public int ModifiedUserId { get; set; }
    }
}
