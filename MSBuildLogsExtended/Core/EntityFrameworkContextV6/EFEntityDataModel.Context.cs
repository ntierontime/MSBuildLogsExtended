//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace MSBuildLogsExtended.EntityFrameworkContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
	using System.Data.Entity.Core.Objects;

    public partial class MSBuildLogsExtendedEntities : DbContext
    {
        public MSBuildLogsExtendedEntities()
            : base("name=MSBuildLogsExtendedEntities")
        {
        }
    
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
    

        public DbSet<Build> Builds { get; set; }



        public DbSet<BuildEventCode> BuildEventCodes { get; set; }



        public DbSet<BuildLog> BuildLogs { get; set; }



        public DbSet<Solution> Solutions { get; set; }





    }
}

