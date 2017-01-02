namespace MSBuildLogsExtended.EntityFrameworkContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	[Table("dbo.Build")]
    public partial class Build 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Build ()
        {
            this.BuildLogs = new HashSet<BuildLog>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Int64 Id { get; set; }

        public System.Int32 SolutionId { get; set; }

        [Required]
        [StringLength(100)]
        public System.String Name { get; set; }

        [StringLength(1500)]
        public System.String Description { get; set; }

        public System.DateTime BuildStartTime { get; set; }


        public Solution Solution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public ICollection<BuildLog> BuildLogs { get; set; }



    }
}

