namespace MSBuildLogsExtended.EntityFrameworkContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	[Table("dbo.BuildEventCode")]
    public partial class BuildEventCode 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildEventCode ()
        {
            this.BuildLogs = new HashSet<BuildLog>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Int32 Id { get; set; }

        [Required]
        [StringLength(100)]
        public System.String EventCode { get; set; }

        [StringLength(1500)]
        public System.String Description { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public ICollection<BuildLog> BuildLogs { get; set; }



    }
}

