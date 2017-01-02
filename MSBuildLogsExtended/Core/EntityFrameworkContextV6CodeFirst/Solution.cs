namespace MSBuildLogsExtended.EntityFrameworkContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	[Table("dbo.Solution")]
    public partial class Solution 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solution ()
        {
            this.Builds = new HashSet<Build>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Int32 Id { get; set; }

        [StringLength(100)]
        public System.String ExternalParentId { get; set; }

        [Required]
        [StringLength(100)]
        public System.String Name { get; set; }

        [StringLength(1500)]
        public System.String Description { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public ICollection<Build> Builds { get; set; }



    }
}

