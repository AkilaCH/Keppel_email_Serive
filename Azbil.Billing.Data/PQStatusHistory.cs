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

namespace Azbil.Billing.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PQStatusHistory : IEntity
    {
        public int PQStatusHistoryId { get; set; }
        public string Status { get; set; }
        public int PQId { get; set; }
        public int InsertedUserId { get; set; }
        public System.DateTime InsertedTime { get; set; }
    }
}
