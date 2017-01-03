namespace MSBuildLogsExtended.EntityFrameworkContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	[Table("dbo.BuildLog")]
    public partial class BuildLog 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildLog ()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Int64 Id { get; set; }

        public System.Int64 BuildId { get; set; }

        public System.Int32 BuildEventCodeId { get; set; }

        [StringLength(1500)]
        public System.String Message { get; set; }

        public System.DateTime EventTime { get; set; }


        public Build Build { get; set; }

        public BuildEventCode BuildEventCode { get; set; }



    }
}