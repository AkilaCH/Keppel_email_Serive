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

    public partial class Owner : IEntity
    {
        [Key]
        public string Name { get; set; }
        public string AddressLine_1 { get; set; }
        public string AddressLine_2 { get; set; }
        public string AddressLine_3 { get; set; }
        public string AddressLine_4 { get; set; }
        public string WebSite { get; set; }
        public string CoRegNo { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public int InsertedUserId { get; set; }
        public System.DateTime InsertedDateTime { get; set; }
    }
}
