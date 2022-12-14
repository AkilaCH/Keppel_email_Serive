//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azbil.Billing.Entities.UserManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UMSDB : DbContext
    {
        public UMSDB()
            : base("name=UMSDB")
        {
        }

        public UMSDB(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmailHistory> EmailHistories { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<MainMenu> MainMenus { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<ProfileFeature> ProfileFeatures { get; set; }
        public virtual DbSet<SubMenu> SubMenus { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }
        public virtual DbSet<VwFeature> VwFeatures { get; set; }
        public virtual DbSet<PWHistory> PWHistories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PWControlSetting> PWControlSettings { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogStatu> ActivityLogStatus { get; set; }
        public virtual DbSet<VwUser> VwUsers { get; set; }
        public virtual DbSet<AccessLog> AccessLogs { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<MSSQLAccessLog> MSSQLAccessLogs { get; set; }
        public virtual DbSet<MSSQLLogHistory> MSSQLLogHistories { get; set; }
    }
}
